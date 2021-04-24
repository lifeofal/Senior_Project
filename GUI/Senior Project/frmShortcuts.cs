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
    public partial class frmShortcuts : Form
    {
        public frmShortcuts()
        {
            InitializeComponent();

            CheckBox checkbox = new CheckBox();
            checkbox.Name = "cb";
            checkbox.Text = "Bottom Infil Patterns";

            listBox1.Items.Add(checkbox);
        }
    }
}
