namespace Senior_Project
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thereIsNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabController = new System.Windows.Forms.TabControl();
            this.createNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fielToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1300, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fielToolStripMenuItem
            // 
            this.fielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fielToolStripMenuItem.Name = "fielToolStripMenuItem";
            this.fielToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fielToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.createNewTabToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thereIsNoneToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // thereIsNoneToolStripMenuItem
            // 
            this.thereIsNoneToolStripMenuItem.Name = "thereIsNoneToolStripMenuItem";
            this.thereIsNoneToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.thereIsNoneToolStripMenuItem.Text = "There is none";
            this.thereIsNoneToolStripMenuItem.Click += new System.EventHandler(this.thereIsNoneToolStripMenuItem_Click);
            // 
            // tabController
            // 
            this.tabController.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabController.Location = new System.Drawing.Point(0, 24);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(1300, 970);
            this.tabController.TabIndex = 1;
            // 
            // createNewTabToolStripMenuItem
            // 
            this.createNewTabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.removeTabToolStripMenuItem});
            this.createNewTabToolStripMenuItem.Name = "createNewTabToolStripMenuItem";
            this.createNewTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewTabToolStripMenuItem.Text = "Tabs";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // removeTabToolStripMenuItem
            // 
            this.removeTabToolStripMenuItem.Name = "removeTabToolStripMenuItem";
            this.removeTabToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeTabToolStripMenuItem.Text = "Remove Tab";
            this.removeTabToolStripMenuItem.Click += new System.EventHandler(this.removeTabToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 994);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Senior Project Slicer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thereIsNoneToolStripMenuItem;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.ToolStripMenuItem createNewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTabToolStripMenuItem;
    }
}

