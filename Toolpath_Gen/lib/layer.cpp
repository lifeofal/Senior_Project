#include "layer.h"
#include <iostream>

Layer::Layer()
{ }

Layer Layer::copy()
{
    Layer temp;
    temp.insertV(data);
    return temp;
}

void Layer::insert(Perimeter _per)
{
    data.push_back(_per);
}

void Layer::insertZ(float m_z)
{
    z_height = m_z;
}

void Layer::set_Solid(bool m_bool)
{
    is_solid = m_bool;
}

void Layer::drop()
{
    data.erase(data.begin());
}

Perimeter Layer::get_Perimeter()
{
    return data.front();
}

float Layer::get_Z()
{
    return z_height;
}

bool Layer::is_Solid()
{
    return is_solid;
}

bool Layer::isEmpty()
{
    return data.empty();
}

void Layer::printSize()
{
    std::cout<<"Size of vector: " << data.size();
}

void Layer::insertV(std::vector<Perimeter> layer_vector)
{
    data = layer_vector;
}