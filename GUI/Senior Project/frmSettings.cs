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
    public partial class frmSettings : Form
    {
        frmMain main;
        public List<String> previousSettings;
        public List<String> defaultSettings;
        public frmGeneral generalSettings;
        public List<Form> forms;

        public frmSettings()
        {
            InitializeComponent();
            int currentIndex = listBox1.SelectedIndex = 0;
            forms = new List<Form>();
            generalSettings = new frmGeneral();
            setMainPanelForm(currentIndex);
        }

        public frmSettings(frmMain main)
        {
            InitializeComponent();
            this.main = main;
            int currentIndex = listBox1.SelectedIndex = 0;
            forms = new List<Form>();
            generalSettings = new frmGeneral();
            //createFormInstances();
            setMainPanelForm(currentIndex);
        }


        public void setMainPanelForm(int formID)
        {
            Form form = null;


            switch (formID)
            {
                case 0: // General Settings Tab
                    form = new frmGeneral() { TopLevel = false, TopMost = true } ;
                    break;
                case 1: // Filament Tab
                    form = new frmFilament() { TopLevel = false, TopMost = true };
                    break;
                case 2:
                    form = new frmShortcuts() { TopLevel = false, TopMost = true };
                    break;
                case 3:
                    form = new frmNotes() { TopLevel = false, TopMost = true };
                    break;
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panBody.Controls.Clear(); //Clears Panel Before Placing New Form
            this.panBody.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public List<String> generateSettings()
        {
            List<String> data = new List<String>();

            return null;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            //main.saveSettings();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setMainPanelForm(listBox1.SelectedIndex);
        }

        public void getData(List<String> data)
        {
            List<String> grabbedData = data;
        }
    }
}
