#ifndef LINES_H
#define LINES_H

#include <vector>
#include "layer.cpp"
#include <sstream>

using namespace std;

struct line
{
    dot xy1;
    dot xy2;
    void insertXY(float x1, float y1, float x2, float y2)
    {
        xy1.x = x1;
        xy1.y = y1;
        xy2.x = x2;
        xy2.y = y2;
    }

    string print()
    {
        stringstream sstream;

        sstream <<"P1: ("<<xy1.x<<","<<xy1.y<<")\tP2: ("<<xy2.x<<","<<xy2.y<<")\n";

        return sstream.str();
    }
};

class Lines
{
    public:
        Lines();
        

        void insertline(float x1, float y1, float x2, float y2);
        void insert(line n);

        Layer sort();

        bool isEmpty();
        void showV();

    private:
        void insertV(vector<line> v);
        vector<line> data;
        dot first;


};

#endif