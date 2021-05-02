namespace Senior_Project
{
    partial class frmSettings
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
            this.panSidebar = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panBody = new System.Windows.Forms.Panel();
            this.panBottom = new System.Windows.Forms.Panel();
            this.panSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panSidebar
            // 
            this.panSidebar.Controls.Add(this.listBox1);
            this.panSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSidebar.Location = new System.Drawing.Point(0, 0);
            this.panSidebar.Name = "panSidebar";
            this.panSidebar.Size = new System.Drawing.Size(210, 481);
            this.panSidebar.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            "General",
            "Filament",
            "Shortcuts",
            "Notes"});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 436);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panBody
            // 
            this.panBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBody.Location = new System.Drawing.Point(210, 0);
            this.panBody.Name = "panBody";
            this.panBody.Size = new System.Drawing.Size(600, 450);
            this.panBody.TabIndex = 0;
            // 
            // panBottom
            // 
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(210, 450);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(600, 31);
            this.panBottom.TabIndex = 2;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 481);
            this.Controls.Add(this.panBody);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panSidebar;
        private System.Windows.Forms.Panel panBody;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panBottom;
    }
}