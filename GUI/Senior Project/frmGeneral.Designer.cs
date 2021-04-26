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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
<<<<<<< HEAD
            this.panBottom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panTopBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panBottom.SuspendLayout();
=======
            this.panTopBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
>>>>>>> ec7e53a76fcbae70adbf12b2348d531ac47e94dd
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
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bed Shape";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbBedShape
            // 
            this.cbBedShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBedShape.FormattingEnabled = true;
            this.cbBedShape.Items.AddRange(new object[] {
            "0x0",
            "280x0",
            "280x240",
            "0x240"});
            this.cbBedShape.Location = new System.Drawing.Point(180, 3);
            this.cbBedShape.Name = "cbBedShape";
            this.cbBedShape.Size = new System.Drawing.Size(121, 32);
            this.cbBedShape.TabIndex = 2;
            this.cbBedShape.Text = "0x0";
            // 
            // txtPrinterNotes
            // 
            this.txtPrinterNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrinterNotes.Location = new System.Drawing.Point(180, 93);
            this.txtPrinterNotes.Multiline = true;
            this.txtPrinterNotes.Name = "txtPrinterNotes";
            this.txtPrinterNotes.Size = new System.Drawing.Size(393, 280);
            this.txtPrinterNotes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 286);
            this.label3.TabIndex = 4;
            this.label3.Text = "Printer Notes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Printers Supported";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPrintersSupported
            // 
            this.cbPrintersSupported.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrintersSupported.FormattingEnabled = true;
            this.cbPrintersSupported.ItemHeight = 24;
            this.cbPrintersSupported.Items.AddRange(new object[] {
            "SV01"});
            this.cbPrintersSupported.Location = new System.Drawing.Point(180, 48);
            this.cbPrintersSupported.Name = "cbPrintersSupported";
            this.cbPrintersSupported.Size = new System.Drawing.Size(121, 32);
            this.cbPrintersSupported.TabIndex = 6;
            this.cbPrintersSupported.Text = "SV01";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.72917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.27083F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrinterNotes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbPrintersSupported, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbBedShape, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.06383F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 376);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
<<<<<<< HEAD
            // panBottom
            // 
            this.panBottom.Controls.Add(this.button2);
            this.panBottom.Controls.Add(this.btnApply);
            this.panBottom.Controls.Add(this.button1);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 449);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(600, 31);
            this.panBottom.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(512, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
=======
>>>>>>> ec7e53a76fcbae70adbf12b2348d531ac47e94dd
            // frmGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.panBottom);
=======
            this.ClientSize = new System.Drawing.Size(600, 450);
>>>>>>> ec7e53a76fcbae70adbf12b2348d531ac47e94dd
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGeneral";
            this.Text = "frmGeneral";
            this.panTopBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
<<<<<<< HEAD
            this.panBottom.ResumeLayout(false);
=======
>>>>>>> ec7e53a76fcbae70adbf12b2348d531ac47e94dd
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panBottom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button button1;
=======
>>>>>>> ec7e53a76fcbae70adbf12b2348d531ac47e94dd
    }
}