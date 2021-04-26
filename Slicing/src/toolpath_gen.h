#ifndef TOOLPATH_GEN_H
#define TOOLPATH_GEN_H

#include <fstream>
#include <iostream>
#include "../lib/toolpath_settings.h"
#include "../lib/toolpath_settings.cpp"
#include "../lib/perimeter.h"
#include "../lib/perimeter.cpp"
#include "../lib/layer.h"
#include "../lib/layer.cpp"

class Generator
{
    private:
        std::string turnFanOn();
        bool checkFanSetting();
        std::string travel(dot d);
        std::string out_path;
        Settings config;

    public:
        Generator(std::string PATH);
        void open_File();
        void print_XYE(Layer layer);
        void init_settings(std::string PATH);
        float get_extLength(dot a, dot b);
        std::string test_travel(dot a);
};

#endif