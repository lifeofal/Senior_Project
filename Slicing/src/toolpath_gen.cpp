#include "toolpath_gen.h"

#define _USE_MATH_DEFINES

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <math.h>


// Settings config("../settings/config.ini");

Generator::Generator(std::string path) 
{
    Settings temp;
    temp.set_path(path);
    config = temp;
    // temp.~Settings();
}

void Generator::open_File() 
{
    out_path = config.s_get_setting("output_filename_format") += ".gcode";
    ofstream gcode(config.s_get_setting("output_filename_format") += ".gcode");
    
    if (checkFanSetting())                                                                      //check if fan should always be on
        gcode << "M107" << endl;
    gcode << "M104 S" << config.s_get_setting("first_layer_temperature") << endl;                //set first layer extruder temp
    gcode << config.s_get_setting("start_gcode") << endl;                                       //lift the nozzle
    
    gcode << "; gcode for filament" << endl << endl;

    gcode << "M109 S" << config.s_get_setting("first_layer_temperature") << endl;                //wait until extruder reaches target temp
    gcode << "G21" << endl;                                                                     //using metric values
    gcode << "G90" << endl;                                                                     //set to absolute positioning
    gcode << "M82" << endl;                                                                     //sets extruder to absolute mode
    gcode << "G92 E0" << endl;                                                                  //sets extruder to position 0
    gcode.close();
}

void Generator::print_XYE(Layer _l)
{
    Layer layer = _l;
    cout<<"Big Layer Size: ";
    _l.printSize();
    ofstream gcode;
    gcode.open(out_path, ios_base::app);
    while(!layer.isEmpty())
    {
        
        gcode << "\nG1 Z" << layer.get_Z() << " F" << (config.f_get_setting("travel_speed")*60) << "\n";    // Set Z Height
        layer.get_Perimeter().get_points(); // Travel to first point && pop the point to put it into last_point in perimeter class
        // cycle throught the next points while .get_Perimeter()
        gcode << travel(layer.get_Perimeter().get_points());
        layer.get_Perimeter().insert(layer.get_Perimeter().get_points());
        layer.get_Perimeter().drop();

        Perimeter loc_perimeter = layer.get_Perimeter();
        while(!loc_perimeter.isEmpty())
        {
            gcode << "\nG1 X" << loc_perimeter.get_points().x << " Y" << loc_perimeter.get_points().y << " E" << get_extLength(loc_perimeter.get_points(), loc_perimeter.get_last_point()) << endl;
            cout<<"XYE showQ"<<endl;
            loc_perimeter.showq();
            loc_perimeter.drop();
        }

        layer.drop(); //Leave alone
    }

    gcode.close();
}

string Generator::turnFanOn()
{
    return("M107");
}

bool Generator::checkFanSetting()
{
    if(config.s_get_setting("fan_always_on") == "1")
        return true;
    else
        return false;
}

std::string Generator::travel(dot d)
{
    std::stringstream output;
    output << "G1 E-" << config.s_get_setting("retract_length") <<  " F" << (config.f_get_setting("retract_speed") * 60) << "\nG92 E0\n" << "G1 X" << d.x << " Y" << d.y << " F" << (config.f_get_setting("travel_speed")*60) << "\nG1 E" << config.s_get_setting("retract_length") << " F" << (config.f_get_setting("retract_speed") * 60) << "\nG1 F" << (config.f_get_setting("perimeter_speed")*60) << endl;
    return output.str();
}

float Generator::get_extLength(dot a, dot b)
{
    float nozDiam = config.f_get_setting("nozzle_diameter");
    float layHeight = config.f_get_setting("layer_height");
    float filDiam = config.f_get_setting("filament_diameter");
    float length = sqrt( pow( ( a.x-b.x), 2.0) + pow((a.y-b.y), 2.0) );
    float volumeL = ((4/3)* M_PI * (nozDiam/2) * (nozDiam/2) * (layHeight/2)) + ((layHeight * (nozDiam-layHeight) * length) + (M_PI * pow((layHeight/2), 2.0) * layHeight) );
    float extLength = (volumeL / pow((M_PI * (filDiam / 2)), 2.0) * layHeight);
    return extLength;
}