#ifndef PERIMETER_H
#define PERIMETER_H

#include <vector>
#include <cmath>

using namespace std;

float PRECISION = 0.001f;

struct dot
{
    float x;
    float y;
    bool operator!=(dot a)
    {
        if(fabs(a.x-x) < PRECISION && fabs(a.y-y) < PRECISION)
            return false;
        else
            return true;
    }

    bool operator==(dot a)
    {
        if(fabs(a.x-x) < PRECISION && fabs(a.y-y) < PRECISION)
            return true;
        else
            return false;
    }
};

class Perimeter
{
    public:
        Perimeter();
        
        Perimeter copy();

        void insertxy(float _x, float _y);
        void insert(dot _dot);
        void drop();
        dot get_front();
        dot get_back();

        bool isEmpty();
        void showV();

        void printSize();

        dot back();

        /* TODO:: 
            *

        //*/
    private:
        void insertV(vector<dot> perimeter_v);
        vector<dot> data;
        dot last_point;


};

#endif