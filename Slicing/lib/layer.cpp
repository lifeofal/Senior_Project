#include "layer.h"

Layer::Layer()
{ }

Layer Layer::copy()
{
    Layer temp;
    temp.insertq(data);
    return temp;
}

void Layer::insert(Perimeter _per)
{
    data.push(_per);
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
    data.pop();
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
    std::cout<<"Size of Queue: " << data.size();
}

void Layer::insertq(std::queue<Perimeter> q)
{
    data = q;
}