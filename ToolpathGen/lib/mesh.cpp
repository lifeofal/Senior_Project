#include "mesh.h"
#include <iostream>

using namespace std;

Mesh::Mesh(){

}

void Mesh::insertXYZ(float x1, float y1, float z1, 
    float x2, float y2, float z2, 
    float x3, float y3, float z3, 
    float vx, float vy, float vz){
        Triangle adder;
        Point temp1;
        Point temp2;
        Point temp3;

        temp1.x = x1;
        temp1.y = y1;
        temp1.z = z1;

        temp2.x = x2;
        temp2.y = y2;
        temp2.z = z2;

        temp3.x = x3;
        temp3.y = y3;
        temp3.z = z3;

        adder.insertPoints(temp1, temp2, temp3);

        temp1.x = vx;
        temp1.y = vy;
        temp1.z = vz;

        adder.insertNormPoint(temp1);

        data.push_back(adder);

        
    }
void Mesh::insertPoints(Point a, Point b, Point c, Point v){
    Triangle adder;

    adder.insertPoints(a,b,c);
    adder.insertNormPoint(v);

    data.push_back(adder);
}
void Mesh::insertTriangle(Triangle a){
    data.push_back(a);
}

Triangle Mesh::getTrig(){ //return the top triangle in the vector
    return data[0];
} 
void Mesh::trim(float currentZHeight){ // delete all triangles below current z height
    for(vector<Triangle>::iterator itr = data.begin(); itr != data.end(); ++itr) {
        if(itr->maxZHeight() < currentZHeight) {
            iter_swap(itr,data.end());
            data.erase(data.end());
        }
    }
} 
