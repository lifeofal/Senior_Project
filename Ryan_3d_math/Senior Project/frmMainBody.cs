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
    public partial class frmMainBody : Form
    {
        frmMain mainForm;
        public frmMainBody(frmMain form)
        {
            InitializeComponent();
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
                mainForm.renameCurrentTab(openFileDialog1.SafeFileName);
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
            generateSettingsOutput();
        }

        public void generateSettingsOutput()
        {
            List<String> settings = new List<String>();
            //Top Printer Settings
            settings.Add("Print Setting : " + ddPrintSettings.SelectedItem.ToString());
            settings.Add("Filamenet Setting : " + ddFilament.SelectedItem.ToString());
            settings.Add("Printer Setting : "+ddPrinter.SelectedItem.ToString());

            //Advanced Settings Group
            settings.Add("XY Size Compensation Setting : " + ddPrinter.SelectedItem.ToString());

            //Infill Settings Group
            settings.Add("Bottom Infill Pattern : " + ddBottomInfill.SelectedItem.ToString());
            settings.Add("Fill Density : " + ddFillDens.SelectedItem.ToString());
            settings.Add("Fill Gaps : " + cbGaps.Checked.ToString());
            settings.Add("Fill Pattern : " + ddFillPattern.SelectedItem.ToString());
            settings.Add("Infill before Perimeters : " + cbInitalBeforePerim.Checked.ToString());
            settings.Add("Top Infill Pattern : " + ddTopInfill.SelectedItem.ToString());

            //Layers and Perimeters
            settings.Add("External Perimeters First : " + cbExternalPerims.Checked.ToString());
            settings.Add("First Layer Height : " + txtFirstLayer.Text.ToString());
            settings.Add("Layer Height : " + ddFillPattern.SelectedItem.ToString());
            settings.Add("Perimeters : " + txtPerimeters.Value.ToString());
            settings.Add("Sprial Vase : " + cbSpiral.Checked.ToString());

            Form gcodeOutput = new frmOutput(settings);
            gcodeOutput.Show();
        }

        private void txtPerimeters_ValueChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
