#include "toolpath_gen.h"

#define _USE_MATH_DEFINES

#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <math.h>


// Settings config("../settings/config.ini");

Generator::Generator(char *path) 
{
    Settings temp_config;
    std::string temp_path(path);
    temp_config.set_path("C:\\Users\\rnmos\\source\\repos\\ToolpathGen\\resource\\config.ini");
    config = temp_config;
    file_name = temp_path += config.s_get_setting("output_filename_format");
    // temp.~Settings();
}

void Generator::open_File() 
{
    ofstream gcode(file_name);
    
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
    // cout<<"Big Layer Size: ";
    // _l.printSize();
    ofstream gcode;
    gcode.open(file_name, ios_base::app);
    while(!layer.isEmpty())
    {
        
        gcode << "\nG1 Z" << layer.get_Z() << " F" << (config.f_get_setting("travel_speed")*60) << "\n";    // Set Z Height
        float loc_extLength = 0;
        Perimeter loc_perimeter = layer.get_Perimeter();

        loc_perimeter.get_front(); // Travel to first point && pop the point to put it into last_point in perimeter class
        loc_perimeter.insert(loc_perimeter.get_front());
        gcode << travel(loc_perimeter.get_front());
        loc_extLength += config.f_get_setting("retract_length");
        loc_perimeter.drop();

        // cycle throught the next points while .get_Perimeter()
        while(!loc_perimeter.isEmpty())
        {
            loc_extLength += get_extLength(loc_perimeter.get_front(), loc_perimeter.get_last());
            gcode << "\nG1 X" << loc_perimeter.get_front().x << " Y" << loc_perimeter.get_front().y << " E" << loc_extLength;          
            loc_perimeter.drop();
        }
        gcode << "\nG1 E" << config.s_get_setting("retract_length") <<  " F" << (config.f_get_setting("retract_speed") * 60);

        layer.drop(); //Drop perimeter from layer when finished
    }

    gcode.close();
}

string Generator::turnFanOn()
{
    return("\nM107");
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
    output << "\nG92 E0";
    output << "\nG1 X" << d.x << " Y" << d.y << " F" << (config.f_get_setting("travel_speed")*60);
    output << "\nG1 E" << config.s_get_setting("retract_length") << " F" << (config.f_get_setting("retract_speed") * 60);
    output << "\nG1 F" << (config.f_get_setting("perimeter_speed")*60);
    return output.str();
}

float Generator::get_extLength(dot a, dot b)
{
    float nozDiam = config.f_get_setting("nozzle_diameter");
    float layHeight = config.f_get_setting("layer_height");
    float filDiam = config.f_get_setting("filament_diameter");
    float length = sqrt( pow( ( a.x-b.x), 2.0) + pow((a.y-b.y), 2.0) );
    float volumeL = ((4/3)* M_PI * (nozDiam/2) * (nozDiam/2) * (layHeight/2)) + ((layHeight * (nozDiam-layHeight) * length) + (M_PI * pow((layHeight/2), 2.0) * layHeight) );
    float extLength = volumeL / ( M_PI * pow( (filDiam / 2), 2.0));
    extLength = extLength * config.f_get_setting("extrusion_multiplier");
    return extLength;
}

void Generator::close_File()
{
    ofstream gcode;
    gcode.open(file_name, ios_base::app);
    gcode << "\nG92 E0"; //set extruder to 0
    gcode << "\n; Filament specific end gcode";
    gcode << "\n; End gcode for filament";
    gcode << "\n\nM104 S0"; //set extruder temp to 0
    gcode << "\nG28 X0"; // home x axis
    gcode << "\nM84"; // disable all motors
    gcode << "\n" << config.s_get_setting("end_gcode");

    gcode.close();
}