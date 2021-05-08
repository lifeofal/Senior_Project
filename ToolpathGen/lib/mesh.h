#ifndef MESH_H
#define MESH_H

#include <vector>
#include "triangle.cpp"

using namespace std;

class Mesh {
    public:
        Mesh();

        void insertXYZ(float x1, float y1, float z1, 
            float x2, float y2, float z2, 
            float x3, float y3, float z3, 
            float vx, float vy, float vz);
        void insertPoints(Point a, Point b, Point c, Point v);
        void insertTriangle(Triangle a);

        Triangle getTrig(int i); //return the top triangle in the vector
        vector<Triangle>::iterator begin();
        vector<Triangle>::iterator end();

        void trim(float currentZHeight); // delete all triangles below current z height

        void printMesh();

    private:
        vector<Triangle> data;

};

#endif