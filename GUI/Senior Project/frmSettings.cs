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

        Form currentForm;

        public List<Form> forms;

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
            createFormInstances();
            setMainPanelForm(currentIndex);
        }

        public void createFormInstances()
        {
            forms = new List<Form>();
            
            forms.Add(new frmGeneral(this) { TopLevel = false, TopMost = true });
            forms.Add(new frmFilament(this) { TopLevel = false, TopMost = true });
            forms.Add(new frmShortcuts() { TopLevel = false, TopMost = true });
            forms.Add(new frmNotes(this) { TopLevel = false, TopMost = true });
        }


        public void setMainPanelForm(int formID)
        {
            Form form = null;

            switch (formID)
            {
                case 0: // General Settings Tab
                    form = new frmGeneral(this) { TopLevel = false, TopMost = true };
                    break;
                case 1: // Filament Tab
                    form = new frmFilament(this) { TopLevel = false, TopMost = true };
                    break;
                case 2: 
                    form = new frmShortcuts() { TopLevel = false, TopMost = true };
                    break;
                case 3: 
                    form = new frmNotes(this) { TopLevel = false, TopMost = true };
                    break;
            }

            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panBody.Controls.Clear(); //Clears Panel Before Placing New Form
            this.panBody.Controls.Add(form);
            
            form.Show();
        }

        private void button2_Click(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        public List<String> generateSettings()
        {
            List<String> data = new List<String>();

            return null;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setMainPanelForm(listBox1.SelectedIndex);
        }
        public void getData(List<SettingsObject> list, int formIndex)
        {
            main.saveSettings(list, formIndex);
        }

        public List<SettingsObject> getPrevSettings(int formIndex)
        {
            List<SettingsObject> obj = main.returnAdvSettings(formIndex);
            return obj;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
