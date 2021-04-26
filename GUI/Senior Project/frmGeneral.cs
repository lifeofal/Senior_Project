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
        public frmGeneral()
        {
            InitializeComponent();
        }

        public void resetValues()
        {
            cbBedShape.SelectedIndex = 0;
            cbPrintersSupported.SelectedIndex = 0;
            txtPrinterNotes.Text = "";
        }
    }
}
