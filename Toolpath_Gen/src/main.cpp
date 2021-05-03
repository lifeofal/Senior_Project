#include <iostream>
#include <string>
#include <fstream>
#include "../lib/toolpath_gen.cpp"

using namespace std;

double * slice(double point1X, double point1Y, double point1Z, 
	double point2X, double point2Y, double point2Z, 
	double point3X, double point3Y, double point3Z, 
	double currentzHeight);

double getMaxZ(int &trigs);

double getZIncrement();

int main() {
	fstream TrigData;
	double point1x, point1y, point1z, point2x, point2y, point2z, point3x, point3y, point3z;
	string conversion; 
	int trigs;
	double maxZ = getMaxZ(trigs);
	double currentZheight = getZIncrement();
	double zIncrementer = getZIncrement();
	double* endpoints = new double[trigs * 3];
	int last = 0;
	
	while (currentZheight < maxZ) {
		TrigData.open("ModelData.txt", ios::in);
		while (!TrigData.eof()) {
			TrigData >> conversion;
			point1x = stod(conversion);
			TrigData >> conversion;
			point1y = stod(conversion);
			TrigData >> conversion;
			point1z = stod(conversion);

			TrigData >> conversion;
			point2x = stod(conversion);
			TrigData >> conversion;
			point2y = stod(conversion);
			TrigData >> conversion;
			point2z = stod(conversion);

			TrigData >> conversion;
			point3x = stod(conversion);
			TrigData >> conversion;
			point3y = stod(conversion);
			TrigData >> conversion;
			point3z = stod(conversion);

			double *recentEnpoints = slice(point1x, point1y, point1z, point2x, point2y, point2z, point3x, point3y, point3z, 0.01);
			if (recentEnpoints != NULL) {
				for (int i = 0; i < 3; i++) {
					endpoints[last] = recentEnpoints[i];
					last++;
				}
			}


			TrigData >> conversion;
			TrigData >> conversion;
			TrigData >> conversion;
			TrigData >> conversion;
		}
		//here is where the sort will need to be called. then it will need to b pushed into a layer and the layer will need to be written to gcode.
		TrigData.close();
		currentZheight += zIncrementer;
	}
	/*
	double zHeight = -19.8;
	int numOfHeights = 1;
	double point1[3] = { 0.0, 0.0, -20.0 };
	double point2[3] = { 10.0, 10.0, -10.0 };
	double point3[3] = { 20.0, 0.0, -20.0 };
	double* normal = NULL;
	Triangle *test = new Triangle(point1, point2, point3, normal);
	
	double * endpoints = slice(0.0, 0.0, -20.0, 10.0, 10.0, -10.0, 20.0, 0.0, -20.0, zHeight);
	for (int i = 0; i < 6; i++) {
		cout << endpoints[i] << ", ";
		cout << endl;
	}*/



}

/*We will call their program. need to make a "generation" object, then use open file command. then, as we slice, 
at the end of every layer, call the print_xye with the "layer" object we are going to generate. The layers will 
be made up of "perimeter" objects. The perimeter objects are made of dot objects, which are xy coordinates.*/




double * slice(double point1X, double point1Y, double point1Z,
	double point2X, double point2Y, double point2Z,
	double point3X, double point3Y, double point3Z,
	double currentZHeight) {


	/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
	 * ordered pairs for each point, and feature flag for if it is above the current z height or not.      *
	 * A 0.0 in the last position means it is below the z height, anything else in the last position means *
	 * it is above or equal to the z height.                                                               *
	 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
	double point1[4] = { point1X,point1Y,point1Z,0.0 };
	double point2[4] = { point2X,point2Y,point2Z,0.0 };
	double point3[4] = { point3X,point3Y,point3Z,0.0 };

	//Check to see how many are above and how many are below the zHeight
	int numAbove = 0;
	int numBelow = 0;

	if (point1[2] >= currentZHeight) { //Point 1
		point1[3] = 1.1;
		numAbove++;
	}
	else {
		numBelow++;
	}
	if (point2[2] >= currentZHeight) { //Point 2
		point2[3] = 1.1;
		numAbove++;
	}
	else {
		numBelow++;
	}
	if (point2[2] >= currentZHeight) { //Point 3
		point2[3] = 1.1;
		numAbove++;
	}
	else {
		numBelow++;
	}
	//If all od triangle is above or below z height, no need to slice.
	if (numAbove == 3 || numBelow == 3) {
		return NULL;
	}//Otherwise, slice the triangle at the current zHeight:
	else {
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
		double x1, y1, z1, x2, y2, z2; //all 6 necesary coordinates for the endpoints
		if (point1[3] != point2[3]) { //This means the points are on opposite sides of the zHeight.
			double t = (currentZHeight - point1[2]) / (point2[2] - point1[2]);
			x1 = point1[0] + (t * (point2[0] - point1[0]));
			y1 = point1[1] + (t * (point2[1] - point1[1]));
			z1 = currentZHeight;

		} if (point1[3] != point3[3]) {
			double t = (currentZHeight - point1[2]) / (point3[2] - point1[2]);
			if (x1 == NULL) {
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
			double t = (currentZHeight - point2[2]) / (point3[2] - point2[2]);
			x2 = point2[0] + (t * (point3[0] - point2[0]));
			y2 = point2[1] + (t * (point3[1] - point2[1]));
			z2 = currentZHeight;
		}

		double intersectionPoints[6] = { x1,y1,z1,x2,y2,z2 };
		return intersectionPoints;

	}



}

double getZIncrement() {
	fstream forZIncrement;
	forZIncrement.open("config.ini", ios::in);
	string conversion;
	double z;

	while (1) {
		forZIncrement >> conversion;
		if (conversion == "layer_height") {
			break;
		}
	}
	forZIncrement >> conversion;
	forZIncrement >> conversion;
	z = stod(conversion);
	return z;

}


double getMaxZ(int &trigs) {
	fstream forMax;
	forMax.open("ModelData.txt", ios::in);
	string conversion;
	double max;
	while (!forMax.eof()) {
		trigs++;
		forMax >> conversion;
	}
	max = stod(conversion);

	trigs--;
	trigs = trigs / 4;

	return max;

}