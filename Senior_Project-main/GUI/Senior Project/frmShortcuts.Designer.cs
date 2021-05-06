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
            this.panBottom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panBottom.SuspendLayout();
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
            this.lstShortcuts.Size = new System.Drawing.Size(576, 403);
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
            // panBottom
            // 
            this.panBottom.Controls.Add(this.button2);
            this.panBottom.Controls.Add(this.btnApply);
            this.panBottom.Controls.Add(this.button3);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 449);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(600, 31);
            this.panBottom.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(431, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmShortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);

            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstShortcuts);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShortcuts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmShortcuts";
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstShortcuts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button3;
    }
}