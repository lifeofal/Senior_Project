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
    

}
void Triangle::insertNormPoint(Point a){

}

Point Triangle::*getPoints(){

}

Point Triangle::getNorm(){

}

void Triangle::printTriangle(){

}


