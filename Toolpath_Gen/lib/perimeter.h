#ifndef PERIMETER_H
#define PERIMETER_H

#include <vector>
#include <queue>
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

        void insertxy(float x, float y);
        void insert(dot n);
        void drop();
        dot get_points();
        dot get_last_point();

        bool isEmpty();
        void showq();

        void printSize();

        dot back();

        /* TODO:: 
            *

        //*/
    private:
        void insertq(queue<dot> q);
        queue<dot> data;
        dot last_vector;


};

#endif