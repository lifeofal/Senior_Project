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
        frmMainBody main;
        public List<String> previousSettings;
        public List<String> defaultSettings;
        public frmSettings()
        {
            InitializeComponent();
            int currentIndex = listBox1.SelectedIndex = 0;
            setMainPanelForm(currentIndex);
        }

        public frmSettings(frmMainBody main)
        {
            InitializeComponent();
            this.main = main;
            int currentIndex = listBox1.SelectedIndex = 0;
            setMainPanelForm(currentIndex);
        }

        public List<Form> createFormInstances()
        {
            List<Form> forms = new List<Form>();

            forms.Add(new frmSettingsGeneral());

            return forms;
        }
        //Use this method to select certain panel for settings
        public void setMainPanelForm(int formID)
        {
            Form form = null;

            switch (formID)
            {
                case 0: // General Settings Tab
                    form = new frmSettingsGeneral() { TopLevel = false, TopMost = true };
                    break;
                case 1: // Account Manager Form
                    form = new frmGeneral() { TopLevel = false, TopMost = true };
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
    }
}
