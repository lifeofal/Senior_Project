#include "perimeter.h"
#include <iostream>

Perimeter::Perimeter() {}

Perimeter Perimeter::copy()
{
    Perimeter temp;
    temp.insertV(data);
    return temp;
}

void Perimeter::insertV(vector<dot> perimeter_v)
{
    data = perimeter_v;
}

void Perimeter::insertxy(float x, float y)
{
    dot temp;
    temp.x = x;
    temp.y = y;
    data.push_back(temp);
}

void Perimeter::insert(dot perimeter_dot)
{
    data.push_back(perimeter_dot);
}

dot Perimeter::get_front()
{
    return data.front();
}

dot Perimeter::get_last()
{
    return last_point;
}

void Perimeter::drop()
{
    last_point = data.front();
    data.erase(data.begin());
}

bool Perimeter::isEmpty()
{
    return data.empty();
}

void Perimeter::printSize()
{
    std::cout<<"Size of vector: " << data.size();
}

void Perimeter::showV()
{
    vector<dot> g = data;
    while (!g.empty()) {
        dot n;
        n = g.front();
        cout << "X: " << n.x << "\tY: " << n.y <<endl;
        data.erase(data.begin());
    }
    g = vector<dot>();
    cout << '\n';
}

dot Perimeter::back()
{
    return data.back();
}

bool Perimeter::is_internal()
{
    return isInternal;
}

void Perimeter::set_internal(bool set)
{
    isInternal = set;
}