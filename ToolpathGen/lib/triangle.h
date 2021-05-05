#ifndef TRIANGLE_H
#define TRIANGLE_H

#include <vector>

using namespace std;

struct Point{
    float x;
    float y;
    float z;

};

class Triangle {
    public:
        Triangle();

        void insertXYZ(float x1, float y1, float z1, float x2, float y2, float z2, float x3, float y3, float z3);
        void insertPoints(Point a, Point b, Point c);

        void insertNormXYZ(float x, float y, float z);
        void insertNormPoint(Point a);

        Point *getPoints();
        Point getNorm();

        float maxZHeight();

        void printTriangle();


    private:
        Point points[3];
        Point normal;

};

#endif