#ifndef TOOLPATH_SETTINGS_H
#define TOOLPATH_SETTINGS_H

#include <string>
#include <map>

class Settings
{
    private:
        std::map<std::string, std::string> _settings;
    public:
        Settings();
        ~Settings();        
        void set_path(std::string path);
        float f_get_setting(std::string key);
        std::string s_get_setting(std::string key);
        
};

#endif