#ifndef LAYER_H
#define LAYER_H

#include "perimeter.cpp"
#include <vector>

class Layer
{
    public:
        Layer();

        Layer copy();
        
        void insert(Perimeter _per);
        void insertZ(float m_z);
        void set_Solid(bool m_bool);
        void drop();
        Perimeter get_Perimeter();
        float get_Z();
        bool is_Solid();

        bool isEmpty();
        void printSize();
    private:
        void insertV(std::vector<Perimeter> layer_vector);
        std::vector<Perimeter> data;
        float z_height;
        bool is_solid;

};

#endif