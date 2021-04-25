using System;
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

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayCheckedItems();
        }

        public void displayCheckedItems()
        {
            int i;
            string s;
            s = "Checked items:\n";
            for (i = 0; i <= (lstShortcuts.Items.Count - 1); i++)
            {
                if (lstShortcuts.GetItemChecked(i))
                {
                    s = s + "Item " + (i + 1).ToString() + " = " + lstShortcuts.Items[i].ToString() + "\n";
                }
            }
            Console.WriteLine(s);
        }
    }
}
