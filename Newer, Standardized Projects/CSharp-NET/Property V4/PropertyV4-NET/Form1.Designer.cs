namespace PropertyV4_NET_REST
{
    partial class Form1
    {

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabRequest = new System.Windows.Forms.TabControl();
            this.tabDeeds = new System.Windows.Forms.TabPage();
            this.tabInputs = new System.Windows.Forms.TabControl();
            this.tabDeedInput = new System.Windows.Forms.TabPage();
            this.deeds_btnClear = new System.Windows.Forms.Button();
            this.deeds_mak = new System.Windows.Forms.TextBox();
            this.deeds_btnSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.deeds_apn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deeds_fips = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.deeds_ff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.deeds_id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabDeedColumns = new System.Windows.Forms.TabPage();
            this.deeds_chkAllCols = new System.Windows.Forms.CheckBox();
            this.deeds_cols = new System.Windows.Forms.CheckedListBox();
            this.tabProperty = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.property_btnClear = new System.Windows.Forms.Button();
            this.property_mak = new System.Windows.Forms.TextBox();
            this.property_btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.property_apn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.property_fips = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.property_ff = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.property_addressKey = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.property_id = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.property_chkAllCols = new System.Windows.Forms.CheckBox();
            this.property_cols = new System.Windows.Forms.CheckedListBox();
            this.tabHomesByOwner = new System.Windows.Forms.TabPage();
            this.homesByOwner_ff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.homesByOwner_mak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.homesByOwner_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.homesByOwner_btnClear = new System.Windows.Forms.Button();
            this.homesByOwner_btnSubmit = new System.Windows.Forms.Button();
            this.tabResponse = new System.Windows.Forms.TabControl();
            this.tabServiceResponse = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tabRESTRequest = new System.Windows.Forms.TabPage();
            this.txtRESTRequest = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabDeeds.SuspendLayout();
            this.tabInputs.SuspendLayout();
            this.tabDeedInput.SuspendLayout();
            this.tabDeedColumns.SuspendLayout();
            this.tabProperty.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabHomesByOwner.SuspendLayout();
            this.tabResponse.SuspendLayout();
            this.tabServiceResponse.SuspendLayout();
            this.tabRESTRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.tabRequest);
            this.panel1.Controls.Add(this.tabResponse);
            this.panel1.Location = new System.Drawing.Point(125, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 746);
            this.panel1.TabIndex = 1;
            // 
            // tabRequest
            // 
            this.tabRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabRequest.Controls.Add(this.tabDeeds);
            this.tabRequest.Controls.Add(this.tabProperty);
            this.tabRequest.Controls.Add(this.tabHomesByOwner);
            this.tabRequest.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabRequest.Location = new System.Drawing.Point(28, 22);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.SelectedIndex = 0;
            this.tabRequest.Size = new System.Drawing.Size(298, 693);
            this.tabRequest.TabIndex = 0;
            // 
            // tabDeeds
            // 
            this.tabDeeds.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabDeeds.Controls.Add(this.tabInputs);
            this.tabDeeds.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabDeeds.Location = new System.Drawing.Point(4, 22);
            this.tabDeeds.Name = "tabDeeds";
            this.tabDeeds.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeeds.Size = new System.Drawing.Size(290, 667);
            this.tabDeeds.TabIndex = 0;
            this.tabDeeds.Text = "Deeds";
            // 
            // tabInputs
            // 
            this.tabInputs.Controls.Add(this.tabDeedInput);
            this.tabInputs.Controls.Add(this.tabDeedColumns);
            this.tabInputs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInputs.Location = new System.Drawing.Point(15, 25);
            this.tabInputs.Name = "tabInputs";
            this.tabInputs.SelectedIndex = 0;
            this.tabInputs.Size = new System.Drawing.Size(258, 582);
            this.tabInputs.TabIndex = 0;
            // 
            // tabDeedInput
            // 
            this.tabDeedInput.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabDeedInput.Controls.Add(this.deeds_btnClear);
            this.tabDeedInput.Controls.Add(this.deeds_mak);
            this.tabDeedInput.Controls.Add(this.deeds_btnSubmit);
            this.tabDeedInput.Controls.Add(this.label16);
            this.tabDeedInput.Controls.Add(this.deeds_apn);
            this.tabDeedInput.Controls.Add(this.label3);
            this.tabDeedInput.Controls.Add(this.deeds_fips);
            this.tabDeedInput.Controls.Add(this.label15);
            this.tabDeedInput.Controls.Add(this.deeds_ff);
            this.tabDeedInput.Controls.Add(this.label10);
            this.tabDeedInput.Controls.Add(this.deeds_id);
            this.tabDeedInput.Controls.Add(this.label12);
            this.tabDeedInput.Location = new System.Drawing.Point(4, 24);
            this.tabDeedInput.Name = "tabDeedInput";
            this.tabDeedInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeedInput.Size = new System.Drawing.Size(250, 554);
            this.tabDeedInput.TabIndex = 0;
            this.tabDeedInput.Text = "Input";
            // 
            // deeds_btnClear
            // 
            this.deeds_btnClear.BackColor = System.Drawing.Color.LightGray;
            this.deeds_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deeds_btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deeds_btnClear.Location = new System.Drawing.Point(80, 501);
            this.deeds_btnClear.Name = "deeds_btnClear";
            this.deeds_btnClear.Size = new System.Drawing.Size(54, 23);
            this.deeds_btnClear.TabIndex = 4;
            this.deeds_btnClear.Text = "Clear";
            this.deeds_btnClear.UseVisualStyleBackColor = false;
            this.deeds_btnClear.Click += new System.EventHandler(this.deeds_btnClear_Click);
            // 
            // deeds_mak
            // 
            this.deeds_mak.Location = new System.Drawing.Point(17, 225);
            this.deeds_mak.Name = "deeds_mak";
            this.deeds_mak.Size = new System.Drawing.Size(216, 23);
            this.deeds_mak.TabIndex = 114;
            // 
            // deeds_btnSubmit
            // 
            this.deeds_btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.deeds_btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deeds_btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deeds_btnSubmit.Location = new System.Drawing.Point(140, 501);
            this.deeds_btnSubmit.Name = "deeds_btnSubmit";
            this.deeds_btnSubmit.Size = new System.Drawing.Size(93, 23);
            this.deeds_btnSubmit.TabIndex = 3;
            this.deeds_btnSubmit.Text = "Submit";
            this.deeds_btnSubmit.UseVisualStyleBackColor = false;
            this.deeds_btnSubmit.Click += new System.EventHandler(this.deeds_btnSubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 15);
            this.label16.TabIndex = 113;
            this.label16.Text = "Melissa Address Key (MAK)";
            // 
            // deeds_apn
            // 
            this.deeds_apn.Location = new System.Drawing.Point(16, 162);
            this.deeds_apn.Name = "deeds_apn";
            this.deeds_apn.Size = new System.Drawing.Size(217, 23);
            this.deeds_apn.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 111;
            this.label3.Text = "Assessor\'s Parcel Number (APN)";
            // 
            // deeds_fips
            // 
            this.deeds_fips.Location = new System.Drawing.Point(16, 99);
            this.deeds_fips.Name = "deeds_fips";
            this.deeds_fips.Size = new System.Drawing.Size(217, 23);
            this.deeds_fips.TabIndex = 110;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(14, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 15);
            this.label15.TabIndex = 109;
            this.label15.Text = "Fed. Info. Processing Standard (FIPS)";
            // 
            // deeds_ff
            // 
            this.deeds_ff.AllowDrop = true;
            this.deeds_ff.Location = new System.Drawing.Point(16, 288);
            this.deeds_ff.Multiline = true;
            this.deeds_ff.Name = "deeds_ff";
            this.deeds_ff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deeds_ff.Size = new System.Drawing.Size(217, 83);
            this.deeds_ff.TabIndex = 108;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "Free Form Input";
            // 
            // deeds_id
            // 
            this.deeds_id.Location = new System.Drawing.Point(16, 36);
            this.deeds_id.Name = "deeds_id";
            this.deeds_id.Size = new System.Drawing.Size(217, 23);
            this.deeds_id.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 103;
            this.label12.Text = "License String";
            // 
            // tabDeedColumns
            // 
            this.tabDeedColumns.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabDeedColumns.Controls.Add(this.deeds_chkAllCols);
            this.tabDeedColumns.Controls.Add(this.deeds_cols);
            this.tabDeedColumns.Location = new System.Drawing.Point(4, 24);
            this.tabDeedColumns.Name = "tabDeedColumns";
            this.tabDeedColumns.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeedColumns.Size = new System.Drawing.Size(250, 554);
            this.tabDeedColumns.TabIndex = 1;
            this.tabDeedColumns.Text = "Columns";
            // 
            // deeds_chkAllCols
            // 
            this.deeds_chkAllCols.AutoSize = true;
            this.deeds_chkAllCols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deeds_chkAllCols.ForeColor = System.Drawing.Color.White;
            this.deeds_chkAllCols.Location = new System.Drawing.Point(31, 30);
            this.deeds_chkAllCols.Name = "deeds_chkAllCols";
            this.deeds_chkAllCols.Size = new System.Drawing.Size(78, 19);
            this.deeds_chkAllCols.TabIndex = 1;
            this.deeds_chkAllCols.Text = "Select All";
            this.deeds_chkAllCols.UseVisualStyleBackColor = true;
            this.deeds_chkAllCols.CheckedChanged += new System.EventHandler(this.deeds_chkAllCols_CheckedChanged);
            // 
            // deeds_cols
            // 
            this.deeds_cols.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deeds_cols.ForeColor = System.Drawing.Color.Black;
            this.deeds_cols.FormattingEnabled = true;
            this.deeds_cols.Items.AddRange(new object[] {
            "grpDocInfor",
            "grpTxDefInfo",
            "grpTxAmtInfo",
            "grpPrimaryGrantor",
            "grpSecondaryGrantor",
            "grpPrimaryGrantee",
            "grpSecondaryGrantee",
            "grpTitleCompInfo",
            "grpMortgage1",
            "grpMortgage2",
            "grpValuation"});
            this.deeds_cols.Location = new System.Drawing.Point(31, 68);
            this.deeds_cols.Name = "deeds_cols";
            this.deeds_cols.Size = new System.Drawing.Size(186, 202);
            this.deeds_cols.TabIndex = 0;
            // 
            // tabProperty
            // 
            this.tabProperty.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabProperty.Controls.Add(this.tabControl1);
            this.tabProperty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProperty.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabProperty.Location = new System.Drawing.Point(4, 22);
            this.tabProperty.Name = "tabProperty";
            this.tabProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperty.Size = new System.Drawing.Size(290, 667);
            this.tabProperty.TabIndex = 1;
            this.tabProperty.Text = "Property";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 582);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.property_btnClear);
            this.tabPage1.Controls.Add(this.property_mak);
            this.tabPage1.Controls.Add(this.property_btnSubmit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.property_apn);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.property_fips);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.property_ff);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.property_addressKey);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.property_id);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input";
            // 
            // property_btnClear
            // 
            this.property_btnClear.BackColor = System.Drawing.Color.LightGray;
            this.property_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.property_btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.property_btnClear.ForeColor = System.Drawing.Color.Black;
            this.property_btnClear.Location = new System.Drawing.Point(80, 501);
            this.property_btnClear.Name = "property_btnClear";
            this.property_btnClear.Size = new System.Drawing.Size(54, 23);
            this.property_btnClear.TabIndex = 116;
            this.property_btnClear.Text = "Clear";
            this.property_btnClear.UseVisualStyleBackColor = false;
            this.property_btnClear.Click += new System.EventHandler(this.property_btnClear_Click);
            // 
            // property_mak
            // 
            this.property_mak.Location = new System.Drawing.Point(17, 288);
            this.property_mak.Name = "property_mak";
            this.property_mak.Size = new System.Drawing.Size(216, 23);
            this.property_mak.TabIndex = 128;
            // 
            // property_btnSubmit
            // 
            this.property_btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.property_btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.property_btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.property_btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.property_btnSubmit.Location = new System.Drawing.Point(140, 501);
            this.property_btnSubmit.Name = "property_btnSubmit";
            this.property_btnSubmit.Size = new System.Drawing.Size(93, 23);
            this.property_btnSubmit.TabIndex = 115;
            this.property_btnSubmit.Text = "Submit";
            this.property_btnSubmit.UseVisualStyleBackColor = false;
            this.property_btnSubmit.Click += new System.EventHandler(this.property_btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 127;
            this.label2.Text = "Melissa Address Key (MAK)";
            // 
            // property_apn
            // 
            this.property_apn.Location = new System.Drawing.Point(16, 225);
            this.property_apn.Name = "property_apn";
            this.property_apn.Size = new System.Drawing.Size(217, 23);
            this.property_apn.TabIndex = 126;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 15);
            this.label13.TabIndex = 125;
            this.label13.Text = "Assessor\'s Parcel Number (APN)";
            // 
            // property_fips
            // 
            this.property_fips.Location = new System.Drawing.Point(16, 162);
            this.property_fips.Name = "property_fips";
            this.property_fips.Size = new System.Drawing.Size(217, 23);
            this.property_fips.TabIndex = 124;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 15);
            this.label14.TabIndex = 123;
            this.label14.Text = "Fed. Info. Processing Standard (FIPS)";
            // 
            // property_ff
            // 
            this.property_ff.AllowDrop = true;
            this.property_ff.Location = new System.Drawing.Point(16, 351);
            this.property_ff.Multiline = true;
            this.property_ff.Name = "property_ff";
            this.property_ff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.property_ff.Size = new System.Drawing.Size(217, 83);
            this.property_ff.TabIndex = 122;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(15, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 15);
            this.label17.TabIndex = 121;
            this.label17.Text = "Free Form Input";
            // 
            // property_addressKey
            // 
            this.property_addressKey.Location = new System.Drawing.Point(16, 99);
            this.property_addressKey.Name = "property_addressKey";
            this.property_addressKey.Size = new System.Drawing.Size(217, 23);
            this.property_addressKey.TabIndex = 120;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(14, 81);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 119;
            this.label18.Text = "Address Key";
            // 
            // property_id
            // 
            this.property_id.Location = new System.Drawing.Point(16, 36);
            this.property_id.Name = "property_id";
            this.property_id.Size = new System.Drawing.Size(217, 23);
            this.property_id.TabIndex = 118;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(15, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 15);
            this.label19.TabIndex = 117;
            this.label19.Text = "License String";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.property_chkAllCols);
            this.tabPage2.Controls.Add(this.property_cols);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columns";
            // 
            // property_chkAllCols
            // 
            this.property_chkAllCols.AutoSize = true;
            this.property_chkAllCols.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.property_chkAllCols.ForeColor = System.Drawing.Color.White;
            this.property_chkAllCols.Location = new System.Drawing.Point(31, 30);
            this.property_chkAllCols.Name = "property_chkAllCols";
            this.property_chkAllCols.Size = new System.Drawing.Size(78, 19);
            this.property_chkAllCols.TabIndex = 3;
            this.property_chkAllCols.Text = "Select All";
            this.property_chkAllCols.UseVisualStyleBackColor = true;
            this.property_chkAllCols.CheckedChanged += new System.EventHandler(this.property_chkAllCols_CheckedChanged);
            // 
            // property_cols
            // 
            this.property_cols.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.property_cols.ForeColor = System.Drawing.Color.Black;
            this.property_cols.FormattingEnabled = true;
            this.property_cols.Items.AddRange(new object[] {
            "grpParcel",
            "grpLegal",
            "grpPropertyAddress",
            "grpParsedPropertyAddress",
            "grpPrimaryOwner",
            "grpSecondaryOwner",
            "grpOwnerAddress",
            "grpLastDeedOwnerInfo",
            "grpCurrentDeed",
            "grpTax",
            "grpPropertyUseInfo",
            "grpPropertySaleInfo",
            "grpPropertySize",
            "grpPool",
            "grpIntStructInfo",
            "grpIntRoomInfo",
            "grpIntAmenities",
            "grpExtStructInfo",
            "grpExtAmenities",
            "grpExtBuildings",
            "grpUtilities",
            "grpParking",
            "grpYardGardenInfo",
            "grpEstimatedValue",
            "grpShape"});
            this.property_cols.Location = new System.Drawing.Point(31, 68);
            this.property_cols.Name = "property_cols";
            this.property_cols.Size = new System.Drawing.Size(186, 454);
            this.property_cols.TabIndex = 2;
            // 
            // tabHomesByOwner
            // 
            this.tabHomesByOwner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabHomesByOwner.Controls.Add(this.homesByOwner_ff);
            this.tabHomesByOwner.Controls.Add(this.label6);
            this.tabHomesByOwner.Controls.Add(this.homesByOwner_mak);
            this.tabHomesByOwner.Controls.Add(this.label5);
            this.tabHomesByOwner.Controls.Add(this.homesByOwner_id);
            this.tabHomesByOwner.Controls.Add(this.label4);
            this.tabHomesByOwner.Controls.Add(this.homesByOwner_btnClear);
            this.tabHomesByOwner.Controls.Add(this.homesByOwner_btnSubmit);
            this.tabHomesByOwner.Location = new System.Drawing.Point(4, 22);
            this.tabHomesByOwner.Name = "tabHomesByOwner";
            this.tabHomesByOwner.Size = new System.Drawing.Size(290, 667);
            this.tabHomesByOwner.TabIndex = 2;
            this.tabHomesByOwner.Text = "Homes by Owner";
            // 
            // homesByOwner_ff
            // 
            this.homesByOwner_ff.AllowDrop = true;
            this.homesByOwner_ff.Location = new System.Drawing.Point(21, 178);
            this.homesByOwner_ff.Multiline = true;
            this.homesByOwner_ff.Name = "homesByOwner_ff";
            this.homesByOwner_ff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.homesByOwner_ff.Size = new System.Drawing.Size(253, 83);
            this.homesByOwner_ff.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "Free Form Input";
            // 
            // homesByOwner_mak
            // 
            this.homesByOwner_mak.Location = new System.Drawing.Point(20, 113);
            this.homesByOwner_mak.Name = "homesByOwner_mak";
            this.homesByOwner_mak.Size = new System.Drawing.Size(253, 22);
            this.homesByOwner_mak.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 93;
            this.label5.Text = "Melissa Address Key (MAK)";
            // 
            // homesByOwner_id
            // 
            this.homesByOwner_id.Location = new System.Drawing.Point(20, 47);
            this.homesByOwner_id.Name = "homesByOwner_id";
            this.homesByOwner_id.Size = new System.Drawing.Size(253, 22);
            this.homesByOwner_id.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 91;
            this.label4.Text = "License String";
            // 
            // homesByOwner_btnClear
            // 
            this.homesByOwner_btnClear.BackColor = System.Drawing.Color.LightGray;
            this.homesByOwner_btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homesByOwner_btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homesByOwner_btnClear.ForeColor = System.Drawing.Color.Black;
            this.homesByOwner_btnClear.Location = new System.Drawing.Point(120, 629);
            this.homesByOwner_btnClear.Name = "homesByOwner_btnClear";
            this.homesByOwner_btnClear.Size = new System.Drawing.Size(54, 23);
            this.homesByOwner_btnClear.TabIndex = 90;
            this.homesByOwner_btnClear.Text = "Clear";
            this.homesByOwner_btnClear.UseVisualStyleBackColor = false;
            this.homesByOwner_btnClear.Click += new System.EventHandler(this.homesByOwner_btnClear_Click);
            // 
            // homesByOwner_btnSubmit
            // 
            this.homesByOwner_btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.homesByOwner_btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homesByOwner_btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homesByOwner_btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.homesByOwner_btnSubmit.Location = new System.Drawing.Point(180, 629);
            this.homesByOwner_btnSubmit.Name = "homesByOwner_btnSubmit";
            this.homesByOwner_btnSubmit.Size = new System.Drawing.Size(93, 23);
            this.homesByOwner_btnSubmit.TabIndex = 89;
            this.homesByOwner_btnSubmit.Text = "Submit";
            this.homesByOwner_btnSubmit.UseVisualStyleBackColor = false;
            this.homesByOwner_btnSubmit.Click += new System.EventHandler(this.homesByOwner_btnSubmit_Click);
            // 
            // tabResponse
            // 
            this.tabResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResponse.Controls.Add(this.tabServiceResponse);
            this.tabResponse.Controls.Add(this.tabRESTRequest);
            this.tabResponse.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabResponse.Location = new System.Drawing.Point(350, 22);
            this.tabResponse.Name = "tabResponse";
            this.tabResponse.SelectedIndex = 0;
            this.tabResponse.Size = new System.Drawing.Size(709, 693);
            this.tabResponse.TabIndex = 15;
            // 
            // tabServiceResponse
            // 
            this.tabServiceResponse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabServiceResponse.Controls.Add(this.txtResponse);
            this.tabServiceResponse.Location = new System.Drawing.Point(4, 22);
            this.tabServiceResponse.Name = "tabServiceResponse";
            this.tabServiceResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceResponse.Size = new System.Drawing.Size(701, 667);
            this.tabServiceResponse.TabIndex = 1;
            this.tabServiceResponse.Text = "Service Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.White;
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.ForeColor = System.Drawing.Color.Black;
            this.txtResponse.Location = new System.Drawing.Point(-4, 0);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(709, 765);
            this.txtResponse.TabIndex = 0;
            // 
            // tabRESTRequest
            // 
            this.tabRESTRequest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabRESTRequest.Controls.Add(this.txtRESTRequest);
            this.tabRESTRequest.Controls.Add(this.label23);
            this.tabRESTRequest.Location = new System.Drawing.Point(4, 22);
            this.tabRESTRequest.Name = "tabRESTRequest";
            this.tabRESTRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRESTRequest.Size = new System.Drawing.Size(701, 667);
            this.tabRESTRequest.TabIndex = 2;
            this.tabRESTRequest.Text = "REST Request";
            // 
            // txtRESTRequest
            // 
            this.txtRESTRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRESTRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRESTRequest.Location = new System.Drawing.Point(30, 48);
            this.txtRESTRequest.Multiline = true;
            this.txtRESTRequest.Name = "txtRESTRequest";
            this.txtRESTRequest.Size = new System.Drawing.Size(638, 221);
            this.txtRESTRequest.TabIndex = 75;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(26, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 19);
            this.label23.TabIndex = 74;
            this.label23.Text = "REST Request:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(117, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Property V4 Sample";
            // 
            // lnkWiki
            // 
            this.lnkWiki.AutoSize = true;
            this.lnkWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWiki.LinkColor = System.Drawing.Color.SkyBlue;
            this.lnkWiki.Location = new System.Drawing.Point(439, 44);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(126, 15);
            this.lnkWiki.TabIndex = 7;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "Wiki Reference Guide";
            this.lnkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWiki_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1290, 840);
            this.Controls.Add(this.lnkWiki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property V4 Sample Code";
            this.panel1.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabDeeds.ResumeLayout(false);
            this.tabInputs.ResumeLayout(false);
            this.tabDeedInput.ResumeLayout(false);
            this.tabDeedInput.PerformLayout();
            this.tabDeedColumns.ResumeLayout(false);
            this.tabDeedColumns.PerformLayout();
            this.tabProperty.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabHomesByOwner.ResumeLayout(false);
            this.tabHomesByOwner.PerformLayout();
            this.tabResponse.ResumeLayout(false);
            this.tabServiceResponse.ResumeLayout(false);
            this.tabServiceResponse.PerformLayout();
            this.tabRESTRequest.ResumeLayout(false);
            this.tabRESTRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabResponse;
        private System.Windows.Forms.TabPage tabServiceResponse;
        private System.Windows.Forms.TabPage tabRESTRequest;
        private System.Windows.Forms.TabControl tabRequest;
        private System.Windows.Forms.TabPage tabDeeds;
        private System.Windows.Forms.TabPage tabProperty;
        private System.Windows.Forms.TabPage tabHomesByOwner;
        private System.Windows.Forms.TextBox txtRESTRequest;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.LinkLabel lnkWiki;
        private System.Windows.Forms.Button deeds_btnSubmit;
        private System.Windows.Forms.TabControl tabInputs;
        private System.Windows.Forms.TabPage tabDeedInput;
        private System.Windows.Forms.TabPage tabDeedColumns;
        private System.Windows.Forms.Button deeds_btnClear;
        private System.Windows.Forms.Button homesByOwner_btnClear;
        private System.Windows.Forms.Button homesByOwner_btnSubmit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox homesByOwner_ff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox homesByOwner_mak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox homesByOwner_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox deeds_mak;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox deeds_apn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deeds_fips;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox deeds_ff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox deeds_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button property_btnClear;
        private System.Windows.Forms.TextBox property_mak;
        private System.Windows.Forms.Button property_btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox property_apn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox property_fips;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox property_ff;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox property_addressKey;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox property_id;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox deeds_chkAllCols;
        private System.Windows.Forms.CheckedListBox deeds_cols;
        private System.Windows.Forms.CheckBox property_chkAllCols;
        private System.Windows.Forms.CheckedListBox property_cols;
    }
}

