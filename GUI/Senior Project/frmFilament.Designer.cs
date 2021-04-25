namespace Senior_Project
{
    partial class frmFilament
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilamentNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilamentColor = new System.Windows.Forms.TextBox();
            this.txtFilamentCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilamentDensity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filament";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filament Notes";
            // 
            // txtFilamentNotes
            // 
            this.txtFilamentNotes.Location = new System.Drawing.Point(37, 313);
            this.txtFilamentNotes.Multiline = true;
            this.txtFilamentNotes.Name = "txtFilamentNotes";
            this.txtFilamentNotes.Size = new System.Drawing.Size(551, 125);
            this.txtFilamentNotes.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filament Color";
            // 
            // txtFilamentColor
            // 
            this.txtFilamentColor.Location = new System.Drawing.Point(128, 79);
            this.txtFilamentColor.Name = "txtFilamentColor";
            this.txtFilamentColor.Size = new System.Drawing.Size(100, 20);
            this.txtFilamentColor.TabIndex = 4;
            // 
            // txtFilamentCost
            // 
            this.txtFilamentCost.Location = new System.Drawing.Point(128, 122);
            this.txtFilamentCost.Name = "txtFilamentCost";
            this.txtFilamentCost.Size = new System.Drawing.Size(100, 20);
            this.txtFilamentCost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filament Cost";
            // 
            // txtFilamentDensity
            // 
            this.txtFilamentDensity.Location = new System.Drawing.Point(128, 164);
            this.txtFilamentDensity.Name = "txtFilamentDensity";
            this.txtFilamentDensity.Size = new System.Drawing.Size(100, 20);
            this.txtFilamentDensity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Filament Density";
            // 
            // frmFilament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.txtFilamentDensity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFilamentCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilamentColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilamentNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFilament";
            this.Text = "frmFilament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilamentNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilamentColor;
        private System.Windows.Forms.TextBox txtFilamentCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilamentDensity;
        private System.Windows.Forms.Label label5;
    }
}