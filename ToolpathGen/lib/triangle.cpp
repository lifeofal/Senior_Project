#include "triangle.h"
#include <iostream>

using namespace std;

Triangle::Triangle() {

}

void Triangle::insertXYZ(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3){
    Point temp;
    
    temp.x = x1;
    temp.y = y1;
    temp.z = z1;
    points[0] = temp;

    temp.x = x2;
    temp.y = y2;
    temp.z = z2;
    points[1] = temp;

    temp.x = x3;
    temp.y = y3;
    temp.z = z3;
    points[2] = temp;

}
void Triangle::insertPoints(Point a, Point b, Point c){
    points[0] = a;
    points[1] = b;
    points[2] = c;

}

void Triangle::insertNormXYZ(float x, float y, float z){
    Point temp;
    temp.x = x;
    temp.y = y;
    temp.z = z;

    normal = temp;

}
void Triangle::insertNormPoint(Point a){
    normal = a;

}

Point *Triangle::getPoints(){
    return points;

}

Point Triangle::getNorm(){
    return normal;
}

float Triangle::maxZHeight() {
    float max;
    max = points[0].z;
    if(max < points[1].z) 
        max = points[1].z;
    if(max < points[2].z)
        max = points[2].z;
    return max;
}

void Triangle::printTriangle(){
    cout << "Point 1: " << points[0].x << ", " << points[0].y << ", " << points[0].z << endl;
    cout << "Point 2: " << points[1].x << ", " << points[1].y << ", " << points[1].z << endl;
    cout << "Point 3: " << points[2].x << ", " << points[2].y << ", " << points[2].z << endl;
    cout << "Normal: " << normal.x << ", " << normal.y << ", " << normal.z << endl;
}


