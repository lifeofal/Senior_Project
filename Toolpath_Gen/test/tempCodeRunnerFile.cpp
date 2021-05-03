#include <string>
#include <iostream>
#include <fstream>
#include <vector>
#include <iterator>
#include <map>
#include <queue>
#include "../lib/toolpath_gen.h"
#include "../lib/toolpath_gen.cpp"

using namespace std;

queue<Layer> dummy_builder(float b);

int main()
{
    // Settings setting;
    // setting.set_path("../settings/config.ini");
    // float setting1 = setting.f_get_setting("adaptive_slicing");
    // cout<<"Test1"<<setting1<<endl;
    // string setting2 = setting.s_get_setting("end_filament_gcode");
    // cout<<"Test2"<<setting2;
    
    // cout<<"hello world";
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
    g1.close_File();

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
    for(float i = 0; i < b; i+=0.1)
    {
        Perimeter p;
        Layer l;
        p.insert(a1);
        p.insert(a2);
        p.insert(a3);
        p.insert(a4);

        a1.x += 0.05;
        a1.y += 0.05;
        a2.x -= 0.05;
        a2.y += 0.05;
        a3.x -= 0.05;
        a3.y -= 0.05;
        a4.x += 0.05;
        a4.y -= 0.05;
        // p.showq();
        l.insert(p);
        l.is_Solid();
        l.insertZ(i);
        temp.push(l);
    }

    return temp;
}