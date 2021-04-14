﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace Senior_Project
{
    public partial class frmMainBody : Form
    {
        frmMain mainForm;
        //UserControl1 userControl;
        List<String> settings;
        public frmMainBody(frmMain form)
        {
            InitializeComponent();
            //userControl = new UserControl1();
            mainForm = form;
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            mainForm.createTabbedPages();
        }

        private void btnCloseTab_Click(object sender, EventArgs e)
        {
            mainForm.removeCurrentPage();
        }

        private void btnLoadSTL_Click(object sender, EventArgs e)
        {
            String fullFilePath = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "stl",
                Filter = "stl files (*.stl)|*.stl",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fullFilePath = openFileDialog1.FileName;
                elementHost1.Child = new UserControl1(fullFilePath);
                mainForm.renameCurrentTab(openFileDialog1.SafeFileName);
                //userControl.changeSTLModel(@"C:\Users\Johnathon\Desktop\DAF CF met trailer.STL");
            }
        }

        private void btnResetSTL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will remove the current STL file.");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Form Should Pop Up Here");
        }

        private void userControl2_Load(object sender, EventArgs e)
        {

        }

        private void btnExportGCode_Click(object sender, EventArgs e)
        {
            List<SettingsObject> settingsOutput = generateSettingsOutput();
            List<String> configDefaults = generateDefaultConfigFile();

            foreach(SettingsObject x in settingsOutput)
            {

                int indexFound = configDefaults.FindIndex(str => str.Contains(x.get_gSO()));
                if (indexFound != -1)
                {
                    configDefaults[indexFound] = configDefaults[indexFound] + " " + x.get_config_Value();
                }
               
            }

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Write the string array to a new file
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "config.ini")))
            {
                foreach (string line in configDefaults)
                    outputFile.WriteLine(line);
            }




        }

        private List<SettingsObject> generateSettingsOutput()
        {
            List<SettingsObject> setList = new List<SettingsObject>();

            SettingsObject setObject;

            List<String> settings = new List<String>();

            //Top Printer Settings

            if (ddPrintSettings.SelectedItem != null)
            {
                setObject = new SettingsObject("print_host", ddPrintSettings.SelectedItem.ToString());

                settings.Add("Print Setting : " + ddPrintSettings.SelectedItem.ToString());
            }
            else
            {
                setObject = new SettingsObject("print_host", "Default");
                settings.Add("Print Setting : Default");
            }

            setList.Add(setObject);

            if (ddFilament.SelectedItem != null)
            {
                setObject = new SettingsObject("filament_settings_id", ddFilament.SelectedItem.ToString());
                settings.Add("Filamenet Setting : " + ddFilament.SelectedItem.ToString());
            }
            else
            {
                setObject = new SettingsObject("filament_settings_id", "Default");
                settings.Add("Filamenet Setting : Default");
            }
            setList.Add(setObject);

            if (ddPrinter.SelectedItem != null)
            {
                setObject = new SettingsObject("print_settings_id", ddPrinter.SelectedItem.ToString());
                settings.Add("Printer Setting : " + ddPrinter.SelectedItem.ToString());
            }
            else
            {
                setObject = new SettingsObject("print_settings_id", "Default");
                settings.Add("Printer Setting : Default");
            }
            setList.Add(setObject);

            //Advanced Settings Group

            setObject = new SettingsObject("xy_size_compensation", txtSizeComp.Text.ToString());
            settings.Add("XY Size Compensation Setting : " + txtSizeComp.Text.ToString());
            setList.Add(setObject);

            //Infill Settings Group
            if (ddBottomInfill.SelectedItem != null)
            {
                setObject = new SettingsObject("bottom_infill_pattern", ddBottomInfill.SelectedItem.ToString());
                settings.Add("Bottom Infill Pattern : " + ddBottomInfill.SelectedItem.ToString());
            }
            else
            {
                setObject = new SettingsObject("bottom_infill_pattern", "Default");
                settings.Add("Bottom Infill Pattern : Default");
            }
            setList.Add(setObject);
            if (ddFillDens.SelectedItem != null)
            {
                settings.Add("Fill Density : " + ddFillDens.SelectedItem.ToString());
            }
            else
            {
                settings.Add("Fill Density : Default");
            }
            settings.Add("Fill Gaps : " + cbGaps.Checked.ToString());
            if (ddFillPattern.SelectedItem != null)
            {
                settings.Add("Fill Pattern : " + ddFillPattern.SelectedItem.ToString());
            }
            else
            {
                settings.Add("Fill Pattern : Default");
            }
            settings.Add("Infill before Perimeters : " + cbInitalBeforePerim.Checked.ToString());
            if (ddTopInfill.SelectedItem != null)
            {
                settings.Add("Top Infill Pattern : " + ddTopInfill.SelectedItem.ToString());
            }
            else
            {
                settings.Add("Top Infill Pattern : Default");
            }

            //Layers and Perimeters
            settings.Add("External Perimeters First : " + cbExternalPerims.Checked.ToString());
            settings.Add("First Layer Height : " + txtFirstLayer.Text.ToString());
            settings.Add("Layer Height : " + txtLayer.Text.ToString());
            settings.Add("Perimeters : " + txtPerimeters.Value.ToString());
            settings.Add("Sprial Vase : " + cbSpiral.Checked.ToString());


            return setList;
            //Form gcodeOutput = new frmOutput(settings);
            //gcodeOutput.Show();
        }

        private List<String> generateDefaultConfigFile()
        {
            string winDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"config_default.txt");
            //Reader
            StreamReader config = new StreamReader(winDir);

            List<String> settings = new List<string>();
            try
            {

                do
                {
                    string line = config.ReadLine();
                    int indexOf = line.IndexOf('=');
                    if (indexOf != -1)
                    {
                        settings.Add(line.Substring(0, indexOf + 1));
                    }




                }
                while (config.Peek() != -1);
            }
            catch
            {
                settings.Add("File is empty");
            }
            finally
            {
                config.Close();
            }




            Form gcodeTxTOutput = new frmOutput(settings);
            gcodeTxTOutput.Show();

            return settings;

            //Console.WriteLine(settings.ToString());



            //Top Printer Settings (Default)
            //settings.Add("printer_settings_id");
            //Advanced Settings Group

            //Infill Settings Group

            //Layers and Perimeters


        }

        private void txtPerimeters_ValueChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void txtSizeComp_TextChanged(object sender, EventArgs e)
        {

        }

        public void saveSettings(List<String> data)
        {
            settings = data;
        }
        
        public List<String> getSettings()
        {
            return settings;
        }
    }
}
