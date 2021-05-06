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
    Layer temp;
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
            checkLines.insert(checkLines.get_front());
            checkLines.drop();
            checkLines.get_front();
            checkLines.get_last();
        }
        
        ++cursor;
    }
}

int Layer::orientation(dot p, dot q, dot r)
{
    int val = (q.y - p.y) * (r.x - q.x) - (q.x - p.x) * (r.y - q.y);
    if (val == 0) return 0;
    return (val > 0)? 1: 2;
}

bool Layer::doIntersect(dot p1, dot q1, dot p2, dot q2)
{
    int o1 = orientation(p1, q1, p2);
    int o2 = orientation(p1, q1, q2);
    int o3 = orientation(p2, q2, p1);
    int o4 = orientation(p2, q2, q1);

    if (o1 != o2 && o3 != o4)
        return true;

    if (o1 == 0 && onSegment(p1, p2, q1)) return true;

    if (o2 == 0 && onSegment(p1, q2, q1)) return true;

    if (o3 == 0 && onSegment(p2, p1, q2)) return true;

    if (o4 == 0 && onSegment(p2, q1, q2)) return true;

    return false;
}

bool Layer::onSegment(dot p, dot q, dot r)
{
    if (q.x <= max(p.x, r.x) && q.x >= min(p.x, r.x) && q.y <= max(p.y, r.y) && q.y >= min(p.y, r.y))
        return true;
    return false;
}