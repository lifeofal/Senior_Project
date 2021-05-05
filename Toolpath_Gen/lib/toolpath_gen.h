#ifndef TOOLPATH_GEN_H
#define TOOLPATH_GEN_H

#include <fstream>
#include <iostream>
#include "toolpath_settings.cpp"
#include "lines.cpp"

class Generator
{
    private:
        std::string turnFanOn();
        bool checkFanSetting();
        std::string travel(dot d);
        std::string out_path, file_name;
        Settings config;

    public:
        Generator(std::string path);
        void open_File();
        void close_File();
        void print_XYE(Layer layer);
        void init_settings(std::string PATH);
        float get_extLength(dot a, dot b);

};

#endif