#include "layer.h"
#include <iostream>

#define INF 10000

Layer::Layer()
{ }

Layer Layer::copy()
{
    Layer temp;
    temp.insertV(data);
    return temp;
}

Layer Layer::offset(float nozDiam)
{

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

void Layer::check_internal()
{
    if(data.size()<2)
    {
        data.front().set_internal(false);
        return;
    }
    vector<Perimeter>::iterator cursor = data.begin(); // create iterator to check every perimeter
    while(cursor != data.end())
    {
        vector<Perimeter>::iterator checkP = data.begin();

        dot castDot = cursor->get_front();
        dot extreme;
        extreme.x = INF;
        extreme.y = castDot.y;
        int intersectSum = 0;
        if(checkP == cursor)
        {
            ++cursor;
            continue;
        }
        while(checkP != data.end())
        {
            Perimeter checkLines = checkP->copy();

        }
        
        ++cursor;
    }
}