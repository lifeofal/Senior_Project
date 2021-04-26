using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class frmFilament : Form, FormAbstraction
    {

        List<String> savedSettings;
        int formIndex = 1;
        public frmFilament()
        {
            InitializeComponent();
        }
        public int getFormIndex()
        {
            return formIndex;
        }

        public List<SettingsObject> GetSettings()
        {
            List<SettingsObject> setList = new List<SettingsObject>();
            SettingsObject setting_object;

            //List<String> filSettings = new List<String>();

            //--------Color

            if(txtFilamentColor.Text.ToString() != null)
            {
                setting_object = new SettingsObject("filament_colour", txtFilamentColor.Text.ToString());

            }
            else
            {
                setting_object = new SettingsObject("filament_colour", "");
            }
            setList.Add(setting_object);

            //---------Cost
            if (txtFilamentCost.Text.ToString() != null)
            {
                setting_object = new SettingsObject("filament_cost", txtFilamentCost.Text.ToString());

            }
            else
            {
                setting_object = new SettingsObject("filament_cost", "");
            }
            setList.Add(setting_object);

            //--------Density
            if (txtFilamentDensity.Text.ToString() != null)
            {
                setting_object = new SettingsObject("filament_density", txtFilamentDensity.Text.ToString());

            }
            else
            {
                setting_object = new SettingsObject("filament_density", "");
            }
            setList.Add(setting_object);

            return setList;
        }
    }
}
