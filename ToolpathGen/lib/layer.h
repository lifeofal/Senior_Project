#ifndef LAYER_H
#define LAYER_H

#include "perimeter.cpp"
#include <vector>

class Layer
{
    public:
        Layer();

        Layer copy();

        Layer offset(float nozDiam);
        
        void insert(Perimeter _per);
        void insertZ(float m_z);
        void set_Solid(bool m_bool);
        void drop();
        Perimeter get_Perimeter();
        float get_Z();
        bool is_Solid();

        bool isEmpty();
        void printSize();
        void check_internal();
 
    private:
        void insertV(std::vector<Perimeter> layer_vector);
        std::vector<Perimeter> data;
        float z_height;
        bool is_solid;
        int orientation(dot p, dot q, dot r);
        bool doIntersect(dot p1, dot q1, dot p2, dot q2);
        bool onSegment(dot p, dot q, dot r);
};

#endif