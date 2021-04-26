// #include "../lib/toolpath_settings.h"
// #include "../lib/toolpath_settings.cpp"
#include <string>
#include <iostream>
#include <fstream>
#include <vector>
#include <iterator>
#include <map>
// #include "../lib/perimeter.h"
// #include "../lib/perimeter.cpp"
// #include "../lib/layer.h"
// #include "../lib/layer.cpp"
#include <queue>
#include "../src/toolpath_gen.h"
#include "../src/toolpath_gen.cpp"

using namespace std;

queue<Layer> dummy_builder(float b);

int main()
{
    queue<Layer> m = dummy_builder(35);
    // cout<<"built builder"<<endl;
    // while(!m.empty())
    // {
    //     Perimeter _perimeter = m.front().get_Perimeter();
    //     cout<<"\n\nZ:"<<m.front().get_Z()<<endl;;
    //     cout<<"First Perimeter";
    //     _perimeter.showq();
    //     _perimeter.drop();
    //     cout<<"Second Perimeter";
    //     _perimeter.showq();
    //     m.pop();
    // }

    Generator g1("../settings/config.ini");

    g1.open_File();
    while(!m.empty())
    {
        g1.print_XYE(m.front());
        m.pop();
    }
}

queue<Layer> dummy_builder(float b)
{
    queue<Layer> temp;
    dot a1;
    dot a2;
    dot a3;
    dot a4;
    a1.x = 100+0;
    a1.y = 100+0;
    a2.x = 100+b;
    a2.y = 100+0;
    a3.x = 100+b;
    a3.y = 100+b;
    a4.x = 100+0;
    a4.y = 100+b;
    for(float i = 0; i < b/2; i+=0.1)
    {
        Perimeter p;
        Layer l;
        p.insert(a1);
        p.insert(a2);
        p.insert(a3);
        p.insert(a4);

        a1.x += 0.2;
        a1.y += 0.2;
        a2.x -= 0.2;
        a2.y += 0.2;
        a3.x -= 0.2;
        a3.y -= 0.2;
        a4.x += 0.2;
        a4.y -= 0.2;
        // p.showq();
        l.insert(p);
        l.insertZ(i);
        temp.push(l);
    }

    return temp;
}