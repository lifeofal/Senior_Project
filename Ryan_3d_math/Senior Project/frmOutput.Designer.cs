namespace Senior_Project
{
    partial class frmOutput
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
            this.txtGCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGCode
            // 
            this.txtGCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGCode.Location = new System.Drawing.Point(0, 0);
            this.txtGCode.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGCode.Multiline = true;
            this.txtGCode.Name = "txtGCode";
            this.txtGCode.Size = new System.Drawing.Size(2155, 1037);
            this.txtGCode.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1029, 1106);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2155, 1190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGCode);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "frmOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOutput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGCode;
        private System.Windows.Forms.Button button1;
    }
}