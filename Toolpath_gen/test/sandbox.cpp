#include "../lib/toolpath_settings.h"
#include "../lib/toolpath_settings.cpp"
#include <string>
#include <iostream>
#include <fstream>
#include <vector>
#include <iterator>
#include <map>

using namespace std;



int main()
{
    Settings setting("../settings/config.ini");

    float setting1 = setting.f_get_setting("");
    cout<<setting1;
    string setting2 = setting.s_get_setting("end_filament_gcode");
    cout<<setting2;
}