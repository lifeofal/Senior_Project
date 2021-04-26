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
    public partial class frmGeneral : Form
    {
        int formIndex;
        frmSettings mainSettings;
        public frmGeneral(frmSettings main)
        {
            InitializeComponent();
            mainSettings = main;
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

            //--------Bed Shape

            if (cbBedShape.SelectedItem.ToString() != null)
            {
                setting_object = new SettingsObject("bed_shape", cbBedShape.Text.ToString());

            }
            else
            {
                setting_object = new SettingsObject("bed_shape", "");
            }
            setList.Add(setting_object);

            //---------Printer Setting
            if (cbPrintersSupported.SelectedItem.ToString() != null)
            {
                setting_object = new SettingsObject("printer_settings_id", cbPrintersSupported.SelectedItem.ToString());

            }
            else
            {
                setting_object = new SettingsObject("printer_settings_id", "");
            }
            setList.Add(setting_object);

            //--------Printer Notes
            if (txtPrinterNotes.Text.ToString() != null)
            {
                setting_object = new SettingsObject("printer_notes", txtPrinterNotes.Text.ToString());

            }
            else
            {
                setting_object = new SettingsObject("printer_notes", "");
            }
            setList.Add(setting_object);

            return setList;



        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            mainSettings.getData(GetSettings(), getFormIndex());
        }

        private void button1_Click(object sender, EventArgs e)//reset
        {
            cbBedShape.SelectedIndex = 0;
            cbPrintersSupported.SelectedIndex = 0;
            txtPrinterNotes.Text = "";
        }
    }
}
