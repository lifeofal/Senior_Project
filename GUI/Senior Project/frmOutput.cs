using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class frmOutput : Form
    {
        public List<String> settings;

        public frmOutput(List<String> settings)
        {
            InitializeComponent();
            this.settings = settings;
            txtGCode.Lines = settings.ToArray<String>();

            //Will need to get from C++ file to display in text file
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //.gcode file extension
            saveFileDialog();
        }

        public void saveFileDialog()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "GCode |*.gcode";
            saveFileDialog1.Title = "Select File location to save GCode";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();

                fs.Close();
            }

            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            
            foreach(String s in txtGCode.Lines)
            {
                sw.WriteLine(s);
            }

            sw.Close();
        }
    }
}
