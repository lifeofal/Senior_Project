#ifndef TOOLPATH_SETTINGS_H
#define TOOLPATH_SETTINGS_H

#include <string>
#include <map>

// comment to update git

class Settings
{
    private:
        std::map<std::string, std::string> _settings;
    public:
        Settings();
        void set_path(std::string PATH);
        ~Settings();
        float f_get_setting(std::string key);
        std::string s_get_setting(std::string key);
};

#endif