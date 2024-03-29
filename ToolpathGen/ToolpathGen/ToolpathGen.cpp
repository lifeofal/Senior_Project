#include <iostream>
#include <direct.h>
#include <string>
#include <fstream>
#include <filesystem>
#include <stdlib.h>
#include "..\lib\toolpath_gen.cpp"
#include "..\lib\mesh.cpp"

using namespace std;

string cwd;
string configDir;
string dataDir;
line slice(float point1X, float point1Y, float point1Z,
	float point2X, float point2Y, float point2Z,
	float point3X, float point3Y, float point3Z,
	float currentzHeight);

bool needsSlicing(float point1Z, float point2Z, float point3Z, float currentzHeight);

bool notFlat(float vx, float vy, float vz);

float getMaxZ();

void main_slice(char* output_path);

int main(int argc, char* argv[])
{
	std::cout << argv[1] << endl;
	main_slice(argv[1]);
	// cout << argv[1] << "\t" << argv[2];
}

void main_slice(char* output_path) {
	// outputPath += '/';
	cwd = _getcwd(NULL, 0);
	configDir = "";
	dataDir = cwd;
	for (int i = 0; i < cwd.length() - 28; i++)
	{
		if (cwd[i] == '\\')
		{
			configDir += '\\';
		}
		configDir += cwd[i];
	}
	configDir += "ToolpathGen\\resource\\config.ini";
	dataDir += "\\ModelData.txt";
	//cout << configDir << endl;
	//cout << dataDir << endl;

	float maxZ = getMaxZ();

	Settings forZHeight;
	forZHeight.set_path(configDir);
	float currentZheight = forZHeight.f_get_setting("layer_height");
	float zIncrementer = currentZheight;

	Lines my_lines;
	fstream TrigData;

	float point1x, point1y, point1z, point2x, point2y, point2z, point3x, point3y, point3z;
	float _vx, _vy, _vz;

	string conversion;

	Generator makesGCode(output_path, configDir);
	makesGCode.open_File();

	Layer layer;

	Mesh mesh;

	TrigData.open(dataDir, ios::in);
		while (!TrigData.eof()) {
			Triangle temp;
			TrigData >> conversion;
			//if the conversion is "#", then break
			if (conversion.compare("#") == 0) {
				break;
			}
			point1x = stof(conversion);
			TrigData >> conversion;
			point1y = stof(conversion);
			TrigData >> conversion;
			point1z = stof(conversion);

			TrigData >> conversion;
			point2x = stof(conversion);
			TrigData >> conversion;
			point2y = stof(conversion);
			TrigData >> conversion;
			point2z = stof(conversion);

			TrigData >> conversion;
			point3x = stof(conversion);
			TrigData >> conversion;
			point3y = stof(conversion);
			TrigData >> conversion;
			point3z = stof(conversion);

			TrigData >> conversion;// skip "V:"

			TrigData >> conversion;
			_vx = stof(conversion);
			TrigData >> conversion;
			_vy = stof(conversion);
			TrigData >> conversion;
			_vz = stof(conversion);

			temp.insertXYZ(point1x, point1y, point1z, point2x, point2y, point2z, point3x, point3y, point3z);
			temp.insertNormXYZ(_vx, _vy, _vz);

			mesh.insertTriangle(temp);
		}

		TrigData.close();

	while (currentZheight < maxZ) {
		
		mesh.trim(currentZheight);

		cout << "current layer height: " << currentZheight << endl;
		
		//cout << "currentz: " << currentZheight << "\t" << maxZ << "\t" << zIncrementer << endl;
		for(int i = 0; i < mesh.size(); i++) {
			Triangle checkSlice = mesh.getTrig(i);
			Point *points = checkSlice.getPoints();
			Point norm = checkSlice.getNorm();
			// cout<<"Needs slice: "<<needsSlicing(point1z, point2z, point3z, currentZheight)<<"\tNot Flat: "<<notFlat(_vx, _vy, _vz)<<endl;
			if (needsSlicing(points[0].z, points[1].z, points[2].z, currentZheight) && notFlat(norm.x, norm.y, norm.z))
			{
				line endpoints = slice(points[0].x, points[0].y, points[0].z, points[1].x, points[1].y, points[1].z, points[2].x, points[2].y, points[2].z, currentZheight);
				//add recentendpoints array to the lines vector
				// cout<<endpoints.xy2.x;

				// cout << "endpoints is not null" << endl;
				my_lines.insert(endpoints);

			}
		}
		//here is where the sort will need to be called on the lines vector. It will output a layer.
		my_lines.showV();
		layer = my_lines.sort();
		// cout<<"Got here finally"<<endl;
		layer.insertZ(currentZheight);
		makesGCode.print_XYE(layer);

		
		currentZheight += zIncrementer;
		// cout<<"currentz: "<<currentZheight<<"\t"<<maxZ<<"\t"<<zIncrementer<<endl;
	}

	makesGCode.close_File();

	//cout << output_path << endl;
}


bool needsSlicing(float point1Z, float point2Z, float point3Z, float currentZHeight)
{
	float maxZ = point1Z, minZ = point1Z;

	if (point2Z > maxZ)
		maxZ = point2Z;
	if (point3Z > maxZ)
		maxZ = point3Z;
	if (point2Z < minZ)
		minZ = point2Z;
	if (point3Z < minZ)
		minZ = point3Z;

	//cout << "Current Z: " << currentZHeight << "\tMinZ: " << minZ << "\tMaxZ: " << maxZ << "\tNeeds Slice: " << (currentZHeight >= minZ && currentZHeight <= maxZ) << endl;

	return (currentZHeight >= minZ && currentZHeight <= maxZ);
}

bool notFlat(float vx, float vy, float vz)
{
	if (vz == -1.0 || vz == 1.0)
	{
		return (vx != 0.0 || vy != 0.0);
	}
	return true;
}

line slice(float point1X, float point1Y, float point1Z,
	float point2X, float point2Y, float point2Z,
	float point3X, float point3Y, float point3Z,
	float currentZHeight) {


	float point1[4] = { point1X,point1Y,point1Z, 0.0 };
	float point2[4] = { point2X,point2Y,point2Z, 0.0 };
	float point3[4] = { point3X,point3Y,point3Z, 0.0 };

	if (point1[2] >= currentZHeight) {
		point1[3] = 1.1;
	}

	if (point2[2] >= currentZHeight) {
		point2[3] = 1.1;
	}

	if (point3[2] >= currentZHeight) {
		point3[3] = 1.1;
	}
	// cout << "slice returned val" << endl;
	/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
	* To slice the traingle at the current zHeight, we are going to use the parametric equations for     *
	* lines in 3 space. The "lines" we are looking at will actually be line segments from one point      *
	* of the triangle to another. We will only need to do this (and it will only work for) points that   *
	* are on oopposite sides of the current zHeight. For example, if we are looking at points point1     *
	* and point2, we want to know where the zHeight will intersect the line that runs through those      *
	* points. The parametric equations are as follows:                                                   *
	*   	x = point1[0] + t(point2[0] - point1[0])                                                     *
	*		y = point1[1] + t(point2[1] - point1[1])                                                     *
	*		z = point1[2] + t(point2[2] - point1[2])                                                     *
	* we know what the value for z will be, because it has to be equal to the z height. We use that      *
	* equation to solve for t, then plug t into the other equations to find the x and y coordinate.      *
	* Repeat until all relavent coordinates are found.                                                   *
	*  * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
	float x1 = -1, y1 = -1, z1 = -1, x2 = -1, y2 = -1, z2 = -1; //all 6 necesary coordinates for the endpoints
	if (point1[3] != point2[3]) { //This means the points are on opposite sides of the zHeight.
		float t = (currentZHeight - point1[2]) / (point2[2] - point1[2]);
		x1 = point1[0] + (t * (point2[0] - point1[0]));
		y1 = point1[1] + (t * (point2[1] - point1[1]));
		z1 = currentZHeight;

	} if (point1[3] != point3[3]) {
		float t = (currentZHeight - point1[2]) / (point3[2] - point1[2]);
		if (x1 < 0) {
			x1 = point1[0] + (t * (point3[0] - point1[0]));
			y1 = point1[1] + (t * (point3[1] - point1[1]));
			z1 = currentZHeight;
		}
		else {
			x2 = point1[0] + (t * (point3[0] - point1[0]));
			y2 = point1[1] + (t * (point3[1] - point1[1]));
			z2 = currentZHeight;
		}
	} if (point2[3] != point3[3]) {
		float t = (currentZHeight - point2[2]) / (point3[2] - point2[2]);
		x2 = point2[0] + (t * (point3[0] - point2[0]));
		y2 = point2[1] + (t * (point3[1] - point2[1]));
		z2 = currentZHeight;
	}

	line output;

	output.insertXY(x1, y1, x2, y2);
	return output;



}


float getMaxZ() {
	fstream forMax;
	forMax.open(dataDir, ios::in);
	string conversion;
	float max;
	forMax >> conversion;
	while (conversion.compare("#") != 0) {
		forMax >> conversion;
	}
	forMax >> conversion;
	max = stof(conversion);
	forMax.close();
	return max;

}