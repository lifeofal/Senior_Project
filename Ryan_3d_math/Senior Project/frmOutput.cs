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
    public partial class frmOutput : Form
    {
        public List<String> settings;

        public frmOutput(List<String> settings)
        {
            InitializeComponent();
            this.settings = settings;
            txtGCode.Lines = settings.ToArray<String>();
        }
    }
}
