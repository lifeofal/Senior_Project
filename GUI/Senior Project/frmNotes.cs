﻿using System;
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
    public partial class frmNotes : Form
    {
        private int formIndex = 3;

        frmSettings mainSettings;
        public frmNotes(frmSettings main)
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

            //--------Color

            if (txtNotes.Text.ToString() != null)
            {
                setting_object = new SettingsObject("notes", txtNotes.Text.ToString());

            }
            

            return setList;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            mainSettings.getData(GetSettings(), getFormIndex());
        }

        private void button1_Click(object sender, EventArgs e)//reset
        {
            txtNotes.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
