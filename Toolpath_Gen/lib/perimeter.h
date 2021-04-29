#ifndef PERIMETER_H
#define PERIMETER_H

#include <vector>
#include <queue>

using namespace std;

struct dot
{
    float x;
    float y;
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

        /* TODO:: 
            *

        //*/
    private:
        void insertq(queue<dot> q);
        queue<dot> data;
        dot last_vector;


};

#endif