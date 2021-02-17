using System;
using System.Windows.Forms;

namespace Senior_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            createTabbedPages();
        }

        /// Menu Bar Buttons ///
        
        /// File
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// Settings
        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings Form Should Pop Up Here");
        }

        /// Settings > Tabs
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTabbedPages();
        }
        private void removeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeCurrentPage();
        }


        /// Help
        private void thereIsNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Why even click it...");
        }

        public void createTabbedPages()
        {
            int tabCount = tabController.TabCount;
            tabController.TabPages.Add("New : " + tabCount);
            TabPage page = tabController.TabPages[tabCount];

            Panel centerPanel = new Panel();
            centerPanel.Dock = DockStyle.Fill;
            Form form = new frmMainBody(this) { TopLevel = false, TopMost = true };
            form.Dock = DockStyle.Fill;
            centerPanel.Controls.Add(form);
            page.Controls.Add(centerPanel);
            form.Show();
        }

        public void removeCurrentPage()
        {
            tabController.TabPages.RemoveAt(tabController.SelectedIndex);
        }

        public void renameCurrentTab(String name)
        {
            TabPage currentPage = tabController.TabPages[tabController.SelectedIndex];
            currentPage.Text = name;
        }
    }
}
