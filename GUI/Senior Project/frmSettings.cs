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
<<<<<<< HEAD
        public frmGeneral generalSettings;
        public List<Form> forms;

=======


        Form currentForm;

        public List<Form> forms;


>>>>>>> 4302ec724cfecdb7905ed9eebacf508daf44dedb
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
<<<<<<< HEAD
            generalSettings = new frmGeneral();
            //createFormInstances();
            setMainPanelForm(currentIndex);
=======
            

            forms.Add(new frmGeneral(this) { TopLevel = false, TopMost = true });
            forms.Add(new frmFilament(this) { TopLevel = false, TopMost = true });
            forms.Add(new frmShortcuts() { TopLevel = false, TopMost = true });
            forms.Add(new frmNotes(this) { TopLevel = false, TopMost = true });
>>>>>>> 4302ec724cfecdb7905ed9eebacf508daf44dedb
        }


        public void setMainPanelForm(int formID)
        {
            Form form = null;


            switch (formID)
            {
                case 0: // General Settings Tab
<<<<<<< HEAD
                    form = new frmGeneral() { TopLevel = false, TopMost = true } ;
=======
                    form = new frmGeneral(this) { TopLevel = false, TopMost = true };
>>>>>>> 4302ec724cfecdb7905ed9eebacf508daf44dedb
                    break;
                case 1: // Filament Tab
                    form = new frmFilament(this) { TopLevel = false, TopMost = true };
                    break;
                case 2:
                    form = new frmShortcuts() { TopLevel = false, TopMost = true };
                    break;
<<<<<<< HEAD
                case 3:
                    form = new frmNotes() { TopLevel = false, TopMost = true };
=======
                case 3: 
                    form = new frmNotes(this) { TopLevel = false, TopMost = true };
>>>>>>> 4302ec724cfecdb7905ed9eebacf508daf44dedb
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
<<<<<<< HEAD

        public void getData(List<String> data)
        {
            List<String> grabbedData = data;
=======
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

>>>>>>> 4302ec724cfecdb7905ed9eebacf508daf44dedb
        }
    }
}
