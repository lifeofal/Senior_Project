#include "perimeter.h"

Perimeter::Perimeter() {}

Perimeter Perimeter::copy()
{
    Perimeter temp;
    temp.insertq(data);
    return temp;
}

void Perimeter::insertq(queue<dot> q)
{
    data = q;
}

void Perimeter::insertxy(float x, float y)
{
    dot temp;
    temp.x = x;
    temp.y = y;
    data.push(temp);
}

void Perimeter::insert(dot n)
{
    data.push(n);
}

dot Perimeter::get_points()
{
    return data.front();
}

dot Perimeter::get_last_point()
{
    return last_vector;
}

void Perimeter::drop()
{
    last_vector = data.front();
    data.pop();
}

bool Perimeter::isEmpty()
{
    return data.empty();
}

void Perimeter::printSize()
{
    std::cout<<"Size of Queue: " << data.size();
}

void Perimeter::showq()
{
    queue<dot> g = data;
    while (!g.empty()) {
        dot n;
        n = g.front();
        cout << "X: " << n.x << "\tY: " << n.y <<endl;
        g.pop();
    }
    g = queue<dot>();
    cout << '\n';
}