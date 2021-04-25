namespace Senior_Project
{
    partial class frmShortcuts
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstShortcuts = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shortcuts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstShortcuts
            // 
            this.lstShortcuts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstShortcuts.FormattingEnabled = true;
            this.lstShortcuts.Items.AddRange(new object[] {
            "Avoid Crossing Perimeters",
            "Bottom Infill Pattern",
            "Brim Width",
            "Dont Support Bridges",
            "Fill Density",
            "Fill Pattern",
            "Layer Height",
            "Perimeters",
            "Spiral Vase",
            "Support Material",
            "Support Material Build Plate Only",
            "Top Infill Pattern"});
            this.lstShortcuts.Location = new System.Drawing.Point(12, 44);
            this.lstShortcuts.Name = "lstShortcuts";
            this.lstShortcuts.Size = new System.Drawing.Size(400, 403);
            this.lstShortcuts.TabIndex = 2;
            this.lstShortcuts.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 403);
            this.button1.TabIndex = 3;
            this.button1.Text = "Displays Checked Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmShortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstShortcuts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShortcuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmShortcuts";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstShortcuts;
        private System.Windows.Forms.Button button1;
    }
}