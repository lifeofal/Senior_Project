#include "toolpath_settings.h"
#include <iostream>
#include <fstream>
#include <string>
#include <iterator>
#include <map>

void Settings::set_path(std::string path)
{
    // Use the PATH as input to set all global variables, else they will be default values
    std::string line;
    std::ifstream _setting_f(path);

    _settings.clear();
        // Runs for every line
    while(getline(_setting_f, line))
    {
            // If string contains # then skip
        if(line.find("#") != std::string::npos)
            continue;
        
        std::string delimiter = " = ";
        size_t last = 0, next;
        std::string _setting_id, _setting_val;
            // Runs through contents of line to find delimiter.
        while((next = line.find(delimiter, last)) != std::string::npos)
        {
            _setting_id = line.substr(0,next);
            _setting_val = line.substr(next+delimiter.length(), line.length()-1);
            last = next + 1;
        }
        _settings.insert(std::pair<std::string, std::string>(_setting_id, _setting_val));
        // cout << "ID: |" << _setting_id << "|\tVal: |" << _setting_val << "|" << endl;
    }

    _setting_f.close();
}

Settings::Settings()
{
    // Do nothing :(
    _settings.clear();
}

Settings::~Settings()
{
    _settings.clear();
}

float Settings::f_get_setting(std::string key)
{
    // Won't handle taking a % well
    std::map<std::string, std::string>::iterator itr;
    if((itr = _settings.find(key)) != _settings.end())
    {
        return std::stof(itr->second);
    }
}

std::string Settings::s_get_setting(std::string key)
{
    std::map<std::string, std::string>::iterator itr;
    if((itr = _settings.find(key)) != _settings.end())
    {
        return itr->second;
    }
}