namespace Senior_Project
{
    partial class frmMainBody
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
            this.panModifier = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.btnNewTab = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnResetSTL = new System.Windows.Forms.Button();
            this.btnLoadSTL = new System.Windows.Forms.Button();
            this.pan3DModelArea = new System.Windows.Forms.Panel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.panSideBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ddPrintSettings = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddFilament = new System.Windows.Forms.ComboBox();
            this.ddPrinter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportGCode = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPerimeters = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtLayer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbExternalPerims = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbSpiral = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFirstLayer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ddTopInfill = new System.Windows.Forms.ComboBox();
            this.cbInitalBeforePerim = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGaps = new System.Windows.Forms.CheckBox();
            this.ddFillPattern = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ddBottomInfill = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddFillDens = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSizeComp = new System.Windows.Forms.TextBox();
            this.panModifier.SuspendLayout();
            this.pan3DModelArea.SuspendLayout();
            this.panSideBar.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPerimeters)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panModifier
            // 
            this.panModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panModifier.Controls.Add(this.panel1);
            this.panModifier.Controls.Add(this.btnCloseTab);
            this.panModifier.Controls.Add(this.btnNewTab);
            this.panModifier.Controls.Add(this.btnSettings);
            this.panModifier.Controls.Add(this.btnResetSTL);
            this.panModifier.Controls.Add(this.btnLoadSTL);
            this.panModifier.Dock = System.Windows.Forms.DockStyle.Top;
            this.panModifier.Location = new System.Drawing.Point(0, 0);
            this.panModifier.Margin = new System.Windows.Forms.Padding(6);
            this.panModifier.Name = "panModifier";
            this.panModifier.Size = new System.Drawing.Size(2560, 65);
            this.panModifier.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(340, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 44);
            this.panel1.TabIndex = 2;
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.Location = new System.Drawing.Point(178, 12);
            this.btnCloseTab.Margin = new System.Windows.Forms.Padding(6);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(150, 44);
            this.btnCloseTab.TabIndex = 1;
            this.btnCloseTab.Text = "Close Tab";
            this.btnCloseTab.UseVisualStyleBackColor = true;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.Location = new System.Drawing.Point(16, 10);
            this.btnNewTab.Margin = new System.Windows.Forms.Padding(6);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(150, 44);
            this.btnNewTab.TabIndex = 1;
            this.btnNewTab.Text = "New Tab";
            this.btnNewTab.UseVisualStyleBackColor = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(696, 10);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 48);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnResetSTL
            // 
            this.btnResetSTL.Location = new System.Drawing.Point(534, 12);
            this.btnResetSTL.Margin = new System.Windows.Forms.Padding(6);
            this.btnResetSTL.Name = "btnResetSTL";
            this.btnResetSTL.Size = new System.Drawing.Size(150, 46);
            this.btnResetSTL.TabIndex = 0;
            this.btnResetSTL.Text = "Reset View";
            this.btnResetSTL.UseVisualStyleBackColor = true;
            this.btnResetSTL.Click += new System.EventHandler(this.btnResetSTL_Click);
            // 
            // btnLoadSTL
            // 
            this.btnLoadSTL.Location = new System.Drawing.Point(372, 12);
            this.btnLoadSTL.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoadSTL.Name = "btnLoadSTL";
            this.btnLoadSTL.Size = new System.Drawing.Size(150, 46);
            this.btnLoadSTL.TabIndex = 0;
            this.btnLoadSTL.Text = "Load STL";
            this.btnLoadSTL.UseVisualStyleBackColor = true;
            this.btnLoadSTL.Click += new System.EventHandler(this.btnLoadSTL_Click);
            // 
            // pan3DModelArea
            // 
            this.pan3DModelArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pan3DModelArea.Controls.Add(this.elementHost1);
            this.pan3DModelArea.Controls.Add(this.userControl1);
            this.pan3DModelArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan3DModelArea.Location = new System.Drawing.Point(0, 65);
            this.pan3DModelArea.Margin = new System.Windows.Forms.Padding(6);
            this.pan3DModelArea.Name = "pan3DModelArea";
            this.pan3DModelArea.Size = new System.Drawing.Size(1914, 1320);
            this.pan3DModelArea.TabIndex = 3;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1914, 1320);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(1564, 1148);
            this.userControl1.Margin = new System.Windows.Forms.Padding(6);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(300, 288);
            this.userControl1.TabIndex = 1;
            // 
            // panSideBar
            // 
            this.panSideBar.BackColor = System.Drawing.Color.Silver;
            this.panSideBar.Controls.Add(this.tableLayoutPanel4);
            this.panSideBar.Controls.Add(this.groupBox3);
            this.panSideBar.Controls.Add(this.groupBox2);
            this.panSideBar.Controls.Add(this.groupBox1);
            this.panSideBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panSideBar.Location = new System.Drawing.Point(1914, 65);
            this.panSideBar.Margin = new System.Windows.Forms.Padding(6);
            this.panSideBar.Name = "panSideBar";
            this.panSideBar.Size = new System.Drawing.Size(646, 1320);
            this.panSideBar.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.ddPrintSettings, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ddFilament, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.ddPrinter, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnExportGCode, 1, 3);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(18, 12);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(610, 192);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Print Settings:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ddPrintSettings
            // 
            this.ddPrintSettings.FormattingEnabled = true;
            this.ddPrintSettings.Items.AddRange(new object[] {
            "- Default -"});
            this.ddPrintSettings.Location = new System.Drawing.Point(234, 6);
            this.ddPrintSettings.Margin = new System.Windows.Forms.Padding(6);
            this.ddPrintSettings.Name = "ddPrintSettings";
            this.ddPrintSettings.Size = new System.Drawing.Size(366, 33);
            this.ddPrintSettings.TabIndex = 1;
            this.ddPrintSettings.Text = "- Default -";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filament :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ddFilament
            // 
            this.ddFilament.FormattingEnabled = true;
            this.ddFilament.Items.AddRange(new object[] {
            "- Default -"});
            this.ddFilament.Location = new System.Drawing.Point(234, 54);
            this.ddFilament.Margin = new System.Windows.Forms.Padding(6);
            this.ddFilament.Name = "ddFilament";
            this.ddFilament.Size = new System.Drawing.Size(366, 33);
            this.ddFilament.TabIndex = 1;
            this.ddFilament.Text = "- Default - ";
            // 
            // ddPrinter
            // 
            this.ddPrinter.FormattingEnabled = true;
            this.ddPrinter.Items.AddRange(new object[] {
            "- Default -"});
            this.ddPrinter.Location = new System.Drawing.Point(234, 102);
            this.ddPrinter.Margin = new System.Windows.Forms.Padding(6);
            this.ddPrinter.Name = "ddPrinter";
            this.ddPrinter.Size = new System.Drawing.Size(366, 33);
            this.ddPrinter.TabIndex = 1;
            this.ddPrinter.Text = "- Default -";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Printer :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExportGCode
            // 
            this.btnExportGCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportGCode.Location = new System.Drawing.Point(430, 150);
            this.btnExportGCode.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportGCode.Name = "btnExportGCode";
            this.btnExportGCode.Size = new System.Drawing.Size(174, 36);
            this.btnExportGCode.TabIndex = 3;
            this.btnExportGCode.Text = "Export G-Code";
            this.btnExportGCode.UseVisualStyleBackColor = true;
            this.btnExportGCode.Click += new System.EventHandler(this.btnExportGCode_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(22, 781);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(606, 296);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Layers and Perimeters";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.31915F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68085F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbExternalPerims, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbSpiral, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 37);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(576, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.txtPerimeters);
            this.panel5.Location = new System.Drawing.Point(324, 150);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 36);
            this.panel5.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.Dock = System.Windows.Forms.DockStyle.Left;
            this.label19.Location = new System.Drawing.Point(200, 0);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 36);
            this.label19.TabIndex = 11;
            this.label19.Text = "(minimum)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPerimeters
            // 
            this.txtPerimeters.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtPerimeters.Location = new System.Drawing.Point(0, 0);
            this.txtPerimeters.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerimeters.Name = "txtPerimeters";
            this.txtPerimeters.Size = new System.Drawing.Size(200, 31);
            this.txtPerimeters.TabIndex = 10;
            this.txtPerimeters.ValueChanged += new System.EventHandler(this.txtPerimeters_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.txtLayer);
            this.panel4.Location = new System.Drawing.Point(324, 102);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(246, 36);
            this.panel4.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Location = new System.Drawing.Point(196, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 36);
            this.label18.TabIndex = 10;
            this.label18.Text = " mm";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLayer
            // 
            this.txtLayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLayer.Location = new System.Drawing.Point(0, 0);
            this.txtLayer.Margin = new System.Windows.Forms.Padding(6);
            this.txtLayer.Name = "txtLayer";
            this.txtLayer.Size = new System.Drawing.Size(196, 31);
            this.txtLayer.TabIndex = 9;
            this.txtLayer.Text = "0";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(306, 48);
            this.label12.TabIndex = 0;
            this.label12.Text = "External perimeters first :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbExternalPerims
            // 
            this.cbExternalPerims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbExternalPerims.Location = new System.Drawing.Point(324, 6);
            this.cbExternalPerims.Margin = new System.Windows.Forms.Padding(6);
            this.cbExternalPerims.Name = "cbExternalPerims";
            this.cbExternalPerims.Size = new System.Drawing.Size(246, 36);
            this.cbExternalPerims.TabIndex = 1;
            this.cbExternalPerims.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(306, 48);
            this.label13.TabIndex = 2;
            this.label13.Text = "First layer height :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 96);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(306, 48);
            this.label14.TabIndex = 3;
            this.label14.Text = "Layer height:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 144);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(306, 48);
            this.label15.TabIndex = 4;
            this.label15.Text = "Perimeters:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 192);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(306, 52);
            this.label16.TabIndex = 5;
            this.label16.Text = "Spiral vase :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSpiral
            // 
            this.cbSpiral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbSpiral.Location = new System.Drawing.Point(324, 198);
            this.cbSpiral.Margin = new System.Windows.Forms.Padding(6);
            this.cbSpiral.Name = "cbSpiral";
            this.cbSpiral.Size = new System.Drawing.Size(246, 40);
            this.cbSpiral.TabIndex = 6;
            this.cbSpiral.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtFirstLayer);
            this.panel3.Location = new System.Drawing.Point(324, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 36);
            this.panel3.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Location = new System.Drawing.Point(196, 0);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 36);
            this.label17.TabIndex = 9;
            this.label17.Text = "mm or %";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstLayer
            // 
            this.txtFirstLayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFirstLayer.Location = new System.Drawing.Point(0, 0);
            this.txtFirstLayer.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirstLayer.Name = "txtFirstLayer";
            this.txtFirstLayer.Size = new System.Drawing.Size(196, 31);
            this.txtFirstLayer.TabIndex = 8;
            this.txtFirstLayer.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(18, 377);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(618, 392);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infill";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.60825F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.39175F));
            this.tableLayoutPanel2.Controls.Add(this.ddTopInfill, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cbInitalBeforePerim, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbGaps, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ddFillPattern, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.ddBottomInfill, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ddFillDens, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 37);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 342);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ddTopInfill
            // 
            this.ddTopInfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddTopInfill.FormattingEnabled = true;
            this.ddTopInfill.Items.AddRange(new object[] {
            "Rectilinear",
            "Concentric",
            "Hilbert Curve"});
            this.ddTopInfill.Location = new System.Drawing.Point(318, 286);
            this.ddTopInfill.Margin = new System.Windows.Forms.Padding(6);
            this.ddTopInfill.Name = "ddTopInfill";
            this.ddTopInfill.Size = new System.Drawing.Size(258, 33);
            this.ddTopInfill.TabIndex = 1;
            this.ddTopInfill.Text = "Rectilinear";
            // 
            // cbInitalBeforePerim
            // 
            this.cbInitalBeforePerim.AutoSize = true;
            this.cbInitalBeforePerim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbInitalBeforePerim.Location = new System.Drawing.Point(318, 230);
            this.cbInitalBeforePerim.Margin = new System.Windows.Forms.Padding(6);
            this.cbInitalBeforePerim.Name = "cbInitalBeforePerim";
            this.cbInitalBeforePerim.Size = new System.Drawing.Size(258, 44);
            this.cbInitalBeforePerim.TabIndex = 2;
            this.cbInitalBeforePerim.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 62);
            this.label11.TabIndex = 0;
            this.label11.Text = "Top infil pattern :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 56);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bottom infill pattern :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGaps
            // 
            this.cbGaps.AutoSize = true;
            this.cbGaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbGaps.Location = new System.Drawing.Point(318, 118);
            this.cbGaps.Margin = new System.Windows.Forms.Padding(6);
            this.cbGaps.Name = "cbGaps";
            this.cbGaps.Size = new System.Drawing.Size(258, 44);
            this.cbGaps.TabIndex = 2;
            this.cbGaps.UseVisualStyleBackColor = true;
            // 
            // ddFillPattern
            // 
            this.ddFillPattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddFillPattern.FormattingEnabled = true;
            this.ddFillPattern.Items.AddRange(new object[] {
            "Rectinliear",
            "Aligned Rectilinear",
            "Grid",
            "Cubic",
            "Concentric"});
            this.ddFillPattern.Location = new System.Drawing.Point(318, 174);
            this.ddFillPattern.Margin = new System.Windows.Forms.Padding(6);
            this.ddFillPattern.Name = "ddFillPattern";
            this.ddFillPattern.Size = new System.Drawing.Size(258, 33);
            this.ddFillPattern.TabIndex = 1;
            this.ddFillPattern.Text = "Rectilinear";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 56);
            this.label10.TabIndex = 0;
            this.label10.Text = "Initial before perimeters :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddBottomInfill
            // 
            this.ddBottomInfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddBottomInfill.FormattingEnabled = true;
            this.ddBottomInfill.Items.AddRange(new object[] {
            "Rectinliear",
            "Concentric",
            "Hilbert Curve"});
            this.ddBottomInfill.Location = new System.Drawing.Point(318, 6);
            this.ddBottomInfill.Margin = new System.Windows.Forms.Padding(6);
            this.ddBottomInfill.Name = "ddBottomInfill";
            this.ddBottomInfill.Size = new System.Drawing.Size(258, 33);
            this.ddBottomInfill.TabIndex = 1;
            this.ddBottomInfill.Text = "Rectilinear";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 56);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fill Density :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ddFillDens
            // 
            this.ddFillDens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddFillDens.FormattingEnabled = true;
            this.ddFillDens.Items.AddRange(new object[] {
            "0%",
            "20%",
            "40%",
            "60%",
            "80%",
            "100%"});
            this.ddFillDens.Location = new System.Drawing.Point(318, 62);
            this.ddFillDens.Margin = new System.Windows.Forms.Padding(6);
            this.ddFillDens.Name = "ddFillDens";
            this.ddFillDens.Size = new System.Drawing.Size(258, 33);
            this.ddFillDens.TabIndex = 1;
            this.ddFillDens.Text = "0%";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 168);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 56);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fill Pattern :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(300, 56);
            this.label8.TabIndex = 0;
            this.label8.Text = "Fill Gaps :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(18, 227);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(618, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.95189F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.04811F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(18, 37);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(582, 46);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 46);
            this.label4.TabIndex = 0;
            this.label4.Text = "XY Size Compensation";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtSizeComp);
            this.panel6.Location = new System.Drawing.Point(319, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(256, 34);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(176, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 34);
            this.label5.TabIndex = 2;
            this.label5.Text = "mm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSizeComp
            // 
            this.txtSizeComp.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSizeComp.Location = new System.Drawing.Point(0, 0);
            this.txtSizeComp.Margin = new System.Windows.Forms.Padding(6);
            this.txtSizeComp.Name = "txtSizeComp";
            this.txtSizeComp.Size = new System.Drawing.Size(176, 31);
            this.txtSizeComp.TabIndex = 1;
            this.txtSizeComp.Text = "0";
            this.txtSizeComp.TextChanged += new System.EventHandler(this.txtSizeComp_TextChanged);
            // 
            // frmMainBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2560, 1385);
            this.Controls.Add(this.pan3DModelArea);
            this.Controls.Add(this.panSideBar);
            this.Controls.Add(this.panModifier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainBody";
            this.Text = "frmMainBody";
            this.panModifier.ResumeLayout(false);
            this.pan3DModelArea.ResumeLayout(false);
            this.panSideBar.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPerimeters)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panModifier;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnResetSTL;
        private System.Windows.Forms.Button btnLoadSTL;
        private System.Windows.Forms.Panel pan3DModelArea;
        private System.Windows.Forms.Panel panSideBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddPrintSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddFilament;
        private System.Windows.Forms.ComboBox ddPrinter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportGCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown txtPerimeters;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtLayer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbExternalPerims;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbSpiral;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFirstLayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox ddTopInfill;
        private System.Windows.Forms.CheckBox cbInitalBeforePerim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbGaps;
        private System.Windows.Forms.ComboBox ddFillPattern;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ddBottomInfill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddFillDens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSizeComp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Button btnNewTab;
        private System.Windows.Forms.UserControl userControl1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}