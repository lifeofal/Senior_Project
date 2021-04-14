using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Project
{
    class SettingsObject
    {
        private string gSO, config_Value;

        public SettingsObject()
        {
            gSO = "Default";
            config_Value = "Default";
        }
        public SettingsObject(string gSO, string config_Value)
        {
            this.gSO = gSO;
            this.config_Value = config_Value;
        }

        public string get_gSO()
        {
            return gSO;
        }
        public string get_config_Value()
        {
            return config_Value;
        }


        private void set_gSO(string gSO)
        {
            this.gSO = gSO;
        }

        private void set_config_Value(string config_Value)
        {
            this.config_Value = config_Value;
        }

    }
}
