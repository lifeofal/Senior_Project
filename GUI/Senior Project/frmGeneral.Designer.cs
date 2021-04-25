namespace Senior_Project
{
    partial class frmGeneral
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
            this.panTopBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBedShape = new System.Windows.Forms.ComboBox();
            this.txtPrinterNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPrintersSupported = new System.Windows.Forms.ComboBox();
            this.panTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTopBar
            // 
            this.panTopBar.Controls.Add(this.label1);
            this.panTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopBar.Location = new System.Drawing.Point(0, 0);
            this.panTopBar.Name = "panTopBar";
            this.panTopBar.Size = new System.Drawing.Size(600, 56);
            this.panTopBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "General";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bed Shape";
            // 
            // cbBedShape
            // 
            this.cbBedShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBedShape.FormattingEnabled = true;
            this.cbBedShape.Items.AddRange(new object[] {
            "0x0",
            "280x0",
            "280x240",
            "0x240"});
            this.cbBedShape.Location = new System.Drawing.Point(218, 77);
            this.cbBedShape.Name = "cbBedShape";
            this.cbBedShape.Size = new System.Drawing.Size(130, 32);
            this.cbBedShape.TabIndex = 2;
            this.cbBedShape.Text = "0x0";
            // 
            // txtPrinterNotes
            // 
            this.txtPrinterNotes.Location = new System.Drawing.Point(12, 293);
            this.txtPrinterNotes.Multiline = true;
            this.txtPrinterNotes.Name = "txtPrinterNotes";
            this.txtPrinterNotes.Size = new System.Drawing.Size(576, 145);
            this.txtPrinterNotes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Printer Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Printers Supported";
            // 
            // cbPrintersSupported
            // 
            this.cbPrintersSupported.FormattingEnabled = true;
            this.cbPrintersSupported.Items.AddRange(new object[] {
            "SV01"});
            this.cbPrintersSupported.Location = new System.Drawing.Point(218, 131);
            this.cbPrintersSupported.Name = "cbPrintersSupported";
            this.cbPrintersSupported.Size = new System.Drawing.Size(121, 21);
            this.cbPrintersSupported.TabIndex = 6;
            this.cbPrintersSupported.Text = "SV01";
            // 
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cbPrintersSupported);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrinterNotes);
            this.Controls.Add(this.cbBedShape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneral";
            this.Text = "frmGeneral";
            this.panTopBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTopBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBedShape;
        private System.Windows.Forms.TextBox txtPrinterNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPrintersSupported;
    }
}