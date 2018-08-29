namespace GEmail_CSharpApp
{
    partial class Form1
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
            this.reqElementsBox = new System.Windows.Forms.GroupBox();
            this.in_transRef = new System.Windows.Forms.TextBox();
            this.static_transRef = new System.Windows.Forms.Label();
            this.static_custID = new System.Windows.Forms.Label();
            this.in_CustomerID = new System.Windows.Forms.TextBox();
            this.reqOptsBox = new System.Windows.Forms.GroupBox();
            this.opt_verifyMailbox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label220 = new System.Windows.Forms.Label();
            this.opt_domainCorrection = new System.Windows.Forms.ComboBox();
            this.label214 = new System.Windows.Forms.Label();
            this.opt_TimeToWait = new System.Windows.Forms.TextBox();
            this.inputElementsBox = new System.Windows.Forms.GroupBox();
            this.in_emailAddress = new System.Windows.Forms.TextBox();
            this.in_static_emailAddress = new System.Windows.Forms.Label();
            this.restRequest = new System.Windows.Forms.TextBox();
            this.btn_submitREST = new System.Windows.Forms.Button();
            this.jsonRequest = new System.Windows.Forms.TextBox();
            this.btn_submitJSON = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.out_static_rawOutput = new System.Windows.Forms.Label();
            this.out_rawOutput = new System.Windows.Forms.TextBox();
            this.out_transResults = new System.Windows.Forms.Label();
            this.out_transRef = new System.Windows.Forms.Label();
            this.out_version = new System.Windows.Forms.Label();
            this.out_static_transResults = new System.Windows.Forms.Label();
            this.out_static_transRef = new System.Windows.Forms.Label();
            this.out_static_version = new System.Windows.Forms.Label();
            this.out_dateChecked = new System.Windows.Forms.TextBox();
            this.out_topLevelDomainName = new System.Windows.Forms.TextBox();
            this.out_topLevelDomain = new System.Windows.Forms.TextBox();
            this.out_domainName = new System.Windows.Forms.TextBox();
            this.out_mailboxName = new System.Windows.Forms.TextBox();
            this.static_dateChecked = new System.Windows.Forms.Label();
            this.static_topLevelDomainName = new System.Windows.Forms.Label();
            this.static_TopLevelDomain = new System.Windows.Forms.Label();
            this.static_DomainName = new System.Windows.Forms.Label();
            this.static_MailboxName = new System.Windows.Forms.Label();
            this.out_emailAddress = new System.Windows.Forms.TextBox();
            this.out_results = new System.Windows.Forms.TextBox();
            this.out_recID = new System.Windows.Forms.TextBox();
            this.static_emailAddress = new System.Windows.Forms.Label();
            this.static_results = new System.Windows.Forms.Label();
            this.static_recID = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.reqElementsBox.SuspendLayout();
            this.reqOptsBox.SuspendLayout();
            this.inputElementsBox.SuspendLayout();
            this.outputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // reqElementsBox
            // 
            this.reqElementsBox.BackColor = System.Drawing.Color.AliceBlue;
            this.reqElementsBox.Controls.Add(this.in_transRef);
            this.reqElementsBox.Controls.Add(this.static_transRef);
            this.reqElementsBox.Controls.Add(this.static_custID);
            this.reqElementsBox.Controls.Add(this.in_CustomerID);
            this.reqElementsBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqElementsBox.Location = new System.Drawing.Point(17, 59);
            this.reqElementsBox.Name = "reqElementsBox";
            this.reqElementsBox.Size = new System.Drawing.Size(362, 114);
            this.reqElementsBox.TabIndex = 96;
            this.reqElementsBox.TabStop = false;
            this.reqElementsBox.Text = "Request Elements";
            // 
            // in_transRef
            // 
            this.in_transRef.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_transRef.Location = new System.Drawing.Point(178, 57);
            this.in_transRef.Margin = new System.Windows.Forms.Padding(4);
            this.in_transRef.Name = "in_transRef";
            this.in_transRef.Size = new System.Drawing.Size(170, 22);
            this.in_transRef.TabIndex = 88;
            this.in_transRef.TextChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // static_transRef
            // 
            this.static_transRef.AutoSize = true;
            this.static_transRef.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_transRef.Location = new System.Drawing.Point(16, 58);
            this.static_transRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_transRef.Name = "static_transRef";
            this.static_transRef.Size = new System.Drawing.Size(155, 18);
            this.static_transRef.TabIndex = 87;
            this.static_transRef.Text = "Transmission Reference";
            // 
            // static_custID
            // 
            this.static_custID.AutoSize = true;
            this.static_custID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_custID.Location = new System.Drawing.Point(90, 24);
            this.static_custID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_custID.Name = "static_custID";
            this.static_custID.Size = new System.Drawing.Size(81, 18);
            this.static_custID.TabIndex = 86;
            this.static_custID.Text = "CustomerID";
            // 
            // in_CustomerID
            // 
            this.in_CustomerID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_CustomerID.Location = new System.Drawing.Point(178, 23);
            this.in_CustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.in_CustomerID.Name = "in_CustomerID";
            this.in_CustomerID.Size = new System.Drawing.Size(170, 22);
            this.in_CustomerID.TabIndex = 85;
            this.in_CustomerID.TextChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // reqOptsBox
            // 
            this.reqOptsBox.BackColor = System.Drawing.Color.AliceBlue;
            this.reqOptsBox.Controls.Add(this.opt_verifyMailbox);
            this.reqOptsBox.Controls.Add(this.label5);
            this.reqOptsBox.Controls.Add(this.label220);
            this.reqOptsBox.Controls.Add(this.opt_domainCorrection);
            this.reqOptsBox.Controls.Add(this.label214);
            this.reqOptsBox.Controls.Add(this.opt_TimeToWait);
            this.reqOptsBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqOptsBox.Location = new System.Drawing.Point(400, 59);
            this.reqOptsBox.Margin = new System.Windows.Forms.Padding(4);
            this.reqOptsBox.Name = "reqOptsBox";
            this.reqOptsBox.Padding = new System.Windows.Forms.Padding(4);
            this.reqOptsBox.Size = new System.Drawing.Size(305, 114);
            this.reqOptsBox.TabIndex = 97;
            this.reqOptsBox.TabStop = false;
            this.reqOptsBox.Text = "Request Options";
            // 
            // opt_verifyMailbox
            // 
            this.opt_verifyMailbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_verifyMailbox.FormattingEnabled = true;
            this.opt_verifyMailbox.Items.AddRange(new object[] {
            "Express (Default)",
            "Premium"});
            this.opt_verifyMailbox.Location = new System.Drawing.Point(148, 20);
            this.opt_verifyMailbox.Margin = new System.Windows.Forms.Padding(4);
            this.opt_verifyMailbox.Name = "opt_verifyMailbox";
            this.opt_verifyMailbox.Size = new System.Drawing.Size(122, 23);
            this.opt_verifyMailbox.TabIndex = 40;
            this.opt_verifyMailbox.Text = "Express (Default)";
            this.opt_verifyMailbox.SelectedIndexChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Verify Mailbox";
            // 
            // label220
            // 
            this.label220.AutoSize = true;
            this.label220.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label220.Location = new System.Drawing.Point(18, 47);
            this.label220.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label220.Name = "label220";
            this.label220.Size = new System.Drawing.Size(123, 18);
            this.label220.TabIndex = 19;
            this.label220.Text = "Domain Correction";
            // 
            // opt_domainCorrection
            // 
            this.opt_domainCorrection.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_domainCorrection.FormattingEnabled = true;
            this.opt_domainCorrection.Items.AddRange(new object[] {
            "Off (Default)",
            "On"});
            this.opt_domainCorrection.Location = new System.Drawing.Point(148, 46);
            this.opt_domainCorrection.Margin = new System.Windows.Forms.Padding(4);
            this.opt_domainCorrection.Name = "opt_domainCorrection";
            this.opt_domainCorrection.Size = new System.Drawing.Size(122, 23);
            this.opt_domainCorrection.TabIndex = 40;
            this.opt_domainCorrection.Text = "Off (Default)";
            this.opt_domainCorrection.SelectedIndexChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // label214
            // 
            this.label214.AutoSize = true;
            this.label214.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label214.Location = new System.Drawing.Point(60, 75);
            this.label214.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label214.Name = "label214";
            this.label214.Size = new System.Drawing.Size(81, 18);
            this.label214.TabIndex = 19;
            this.label214.Text = "TimeToWait";
            // 
            // opt_TimeToWait
            // 
            this.opt_TimeToWait.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_TimeToWait.Location = new System.Drawing.Point(148, 74);
            this.opt_TimeToWait.Name = "opt_TimeToWait";
            this.opt_TimeToWait.Size = new System.Drawing.Size(122, 23);
            this.opt_TimeToWait.TabIndex = 43;
            this.opt_TimeToWait.TextChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // inputElementsBox
            // 
            this.inputElementsBox.BackColor = System.Drawing.Color.AliceBlue;
            this.inputElementsBox.Controls.Add(this.in_emailAddress);
            this.inputElementsBox.Controls.Add(this.in_static_emailAddress);
            this.inputElementsBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputElementsBox.Location = new System.Drawing.Point(17, 192);
            this.inputElementsBox.Name = "inputElementsBox";
            this.inputElementsBox.Size = new System.Drawing.Size(688, 68);
            this.inputElementsBox.TabIndex = 98;
            this.inputElementsBox.TabStop = false;
            this.inputElementsBox.Text = "Input Elements";
            // 
            // in_emailAddress
            // 
            this.in_emailAddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_emailAddress.Location = new System.Drawing.Point(157, 30);
            this.in_emailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.in_emailAddress.Name = "in_emailAddress";
            this.in_emailAddress.Size = new System.Drawing.Size(496, 22);
            this.in_emailAddress.TabIndex = 23;
            this.in_emailAddress.Text = "testemail@domain.com";
            this.in_emailAddress.TextChanged += new System.EventHandler(this.UpdateRequests);
            // 
            // in_static_emailAddress
            // 
            this.in_static_emailAddress.AutoSize = true;
            this.in_static_emailAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_static_emailAddress.Location = new System.Drawing.Point(47, 33);
            this.in_static_emailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.in_static_emailAddress.Name = "in_static_emailAddress";
            this.in_static_emailAddress.Size = new System.Drawing.Size(95, 18);
            this.in_static_emailAddress.TabIndex = 16;
            this.in_static_emailAddress.Text = "Email Address";
            // 
            // restRequest
            // 
            this.restRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.restRequest.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRequest.Location = new System.Drawing.Point(723, 60);
            this.restRequest.Margin = new System.Windows.Forms.Padding(4);
            this.restRequest.Multiline = true;
            this.restRequest.Name = "restRequest";
            this.restRequest.ReadOnly = true;
            this.restRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.restRequest.Size = new System.Drawing.Size(601, 96);
            this.restRequest.TabIndex = 126;
            // 
            // btn_submitREST
            // 
            this.btn_submitREST.Location = new System.Drawing.Point(1332, 79);
            this.btn_submitREST.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submitREST.Name = "btn_submitREST";
            this.btn_submitREST.Size = new System.Drawing.Size(75, 55);
            this.btn_submitREST.TabIndex = 124;
            this.btn_submitREST.Text = "REST";
            this.btn_submitREST.UseVisualStyleBackColor = true;
            this.btn_submitREST.Click += new System.EventHandler(this.Btn_submitREST_Click);
            // 
            // jsonRequest
            // 
            this.jsonRequest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jsonRequest.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jsonRequest.Location = new System.Drawing.Point(723, 180);
            this.jsonRequest.Margin = new System.Windows.Forms.Padding(4);
            this.jsonRequest.Multiline = true;
            this.jsonRequest.Name = "jsonRequest";
            this.jsonRequest.ReadOnly = true;
            this.jsonRequest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonRequest.Size = new System.Drawing.Size(601, 90);
            this.jsonRequest.TabIndex = 127;
            // 
            // btn_submitJSON
            // 
            this.btn_submitJSON.Location = new System.Drawing.Point(1332, 192);
            this.btn_submitJSON.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submitJSON.Name = "btn_submitJSON";
            this.btn_submitJSON.Size = new System.Drawing.Size(75, 55);
            this.btn_submitJSON.TabIndex = 125;
            this.btn_submitJSON.Text = "JSON";
            this.btn_submitJSON.UseVisualStyleBackColor = true;
            this.btn_submitJSON.Click += new System.EventHandler(this.Btn_submitJSON_Click);
            // 
            // outputBox
            // 
            this.outputBox.Controls.Add(this.out_static_rawOutput);
            this.outputBox.Controls.Add(this.out_rawOutput);
            this.outputBox.Controls.Add(this.out_transResults);
            this.outputBox.Controls.Add(this.out_transRef);
            this.outputBox.Controls.Add(this.out_version);
            this.outputBox.Controls.Add(this.out_static_transResults);
            this.outputBox.Controls.Add(this.out_static_transRef);
            this.outputBox.Controls.Add(this.out_static_version);
            this.outputBox.Controls.Add(this.out_dateChecked);
            this.outputBox.Controls.Add(this.out_topLevelDomainName);
            this.outputBox.Controls.Add(this.out_topLevelDomain);
            this.outputBox.Controls.Add(this.out_domainName);
            this.outputBox.Controls.Add(this.out_mailboxName);
            this.outputBox.Controls.Add(this.static_dateChecked);
            this.outputBox.Controls.Add(this.static_topLevelDomainName);
            this.outputBox.Controls.Add(this.static_TopLevelDomain);
            this.outputBox.Controls.Add(this.static_DomainName);
            this.outputBox.Controls.Add(this.static_MailboxName);
            this.outputBox.Controls.Add(this.out_emailAddress);
            this.outputBox.Controls.Add(this.out_results);
            this.outputBox.Controls.Add(this.out_recID);
            this.outputBox.Controls.Add(this.static_emailAddress);
            this.outputBox.Controls.Add(this.static_results);
            this.outputBox.Controls.Add(this.static_recID);
            this.outputBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.Location = new System.Drawing.Point(22, 272);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1384, 439);
            this.outputBox.TabIndex = 128;
            this.outputBox.TabStop = false;
            this.outputBox.Text = "Ouput";
            // 
            // out_static_rawOutput
            // 
            this.out_static_rawOutput.AutoSize = true;
            this.out_static_rawOutput.Location = new System.Drawing.Point(698, 88);
            this.out_static_rawOutput.Name = "out_static_rawOutput";
            this.out_static_rawOutput.Size = new System.Drawing.Size(85, 18);
            this.out_static_rawOutput.TabIndex = 176;
            this.out_static_rawOutput.Text = "Raw Output:";
            // 
            // out_rawOutput
            // 
            this.out_rawOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_rawOutput.Location = new System.Drawing.Point(701, 109);
            this.out_rawOutput.Multiline = true;
            this.out_rawOutput.Name = "out_rawOutput";
            this.out_rawOutput.ReadOnly = true;
            this.out_rawOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.out_rawOutput.Size = new System.Drawing.Size(601, 296);
            this.out_rawOutput.TabIndex = 175;
            // 
            // out_transResults
            // 
            this.out_transResults.AutoSize = true;
            this.out_transResults.Location = new System.Drawing.Point(447, 36);
            this.out_transResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_transResults.Name = "out_transResults";
            this.out_transResults.Size = new System.Drawing.Size(18, 18);
            this.out_transResults.TabIndex = 174;
            this.out_transResults.Text = "--";
            // 
            // out_transRef
            // 
            this.out_transRef.AutoSize = true;
            this.out_transRef.Location = new System.Drawing.Point(226, 36);
            this.out_transRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_transRef.Name = "out_transRef";
            this.out_transRef.Size = new System.Drawing.Size(18, 18);
            this.out_transRef.TabIndex = 173;
            this.out_transRef.Text = "--";
            // 
            // out_version
            // 
            this.out_version.AutoSize = true;
            this.out_version.Location = new System.Drawing.Point(783, 36);
            this.out_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_version.Name = "out_version";
            this.out_version.Size = new System.Drawing.Size(18, 18);
            this.out_version.TabIndex = 172;
            this.out_version.Text = "--";
            // 
            // out_static_transResults
            // 
            this.out_static_transResults.AutoSize = true;
            this.out_static_transResults.Location = new System.Drawing.Point(293, 36);
            this.out_static_transResults.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_static_transResults.Name = "out_static_transResults";
            this.out_static_transResults.Size = new System.Drawing.Size(140, 18);
            this.out_static_transResults.TabIndex = 171;
            this.out_static_transResults.Text = "TransmissionResults :";
            // 
            // out_static_transRef
            // 
            this.out_static_transRef.AutoSize = true;
            this.out_static_transRef.Location = new System.Drawing.Point(53, 36);
            this.out_static_transRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_static_transRef.Name = "out_static_transRef";
            this.out_static_transRef.Size = new System.Drawing.Size(159, 18);
            this.out_static_transRef.TabIndex = 170;
            this.out_static_transRef.Text = "TransmissionReference :";
            // 
            // out_static_version
            // 
            this.out_static_version.AutoSize = true;
            this.out_static_version.Location = new System.Drawing.Point(628, 36);
            this.out_static_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.out_static_version.Name = "out_static_version";
            this.out_static_version.Size = new System.Drawing.Size(141, 18);
            this.out_static_version.TabIndex = 169;
            this.out_static_version.Text = "Web Service Version :";
            // 
            // out_dateChecked
            // 
            this.out_dateChecked.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_dateChecked.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_dateChecked.Location = new System.Drawing.Point(199, 383);
            this.out_dateChecked.Margin = new System.Windows.Forms.Padding(4);
            this.out_dateChecked.Name = "out_dateChecked";
            this.out_dateChecked.ReadOnly = true;
            this.out_dateChecked.Size = new System.Drawing.Size(319, 22);
            this.out_dateChecked.TabIndex = 166;
            // 
            // out_topLevelDomainName
            // 
            this.out_topLevelDomainName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_topLevelDomainName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_topLevelDomainName.Location = new System.Drawing.Point(199, 343);
            this.out_topLevelDomainName.Margin = new System.Windows.Forms.Padding(4);
            this.out_topLevelDomainName.Name = "out_topLevelDomainName";
            this.out_topLevelDomainName.ReadOnly = true;
            this.out_topLevelDomainName.Size = new System.Drawing.Size(319, 22);
            this.out_topLevelDomainName.TabIndex = 165;
            // 
            // out_topLevelDomain
            // 
            this.out_topLevelDomain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_topLevelDomain.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_topLevelDomain.Location = new System.Drawing.Point(199, 303);
            this.out_topLevelDomain.Margin = new System.Windows.Forms.Padding(4);
            this.out_topLevelDomain.Name = "out_topLevelDomain";
            this.out_topLevelDomain.ReadOnly = true;
            this.out_topLevelDomain.Size = new System.Drawing.Size(319, 22);
            this.out_topLevelDomain.TabIndex = 163;
            // 
            // out_domainName
            // 
            this.out_domainName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_domainName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_domainName.Location = new System.Drawing.Point(199, 263);
            this.out_domainName.Margin = new System.Windows.Forms.Padding(4);
            this.out_domainName.Name = "out_domainName";
            this.out_domainName.ReadOnly = true;
            this.out_domainName.Size = new System.Drawing.Size(319, 22);
            this.out_domainName.TabIndex = 162;
            // 
            // out_mailboxName
            // 
            this.out_mailboxName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_mailboxName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_mailboxName.Location = new System.Drawing.Point(199, 223);
            this.out_mailboxName.Margin = new System.Windows.Forms.Padding(4);
            this.out_mailboxName.Name = "out_mailboxName";
            this.out_mailboxName.ReadOnly = true;
            this.out_mailboxName.Size = new System.Drawing.Size(319, 22);
            this.out_mailboxName.TabIndex = 161;
            // 
            // static_dateChecked
            // 
            this.static_dateChecked.AutoSize = true;
            this.static_dateChecked.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_dateChecked.Location = new System.Drawing.Point(90, 383);
            this.static_dateChecked.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_dateChecked.Name = "static_dateChecked";
            this.static_dateChecked.Size = new System.Drawing.Size(90, 18);
            this.static_dateChecked.TabIndex = 152;
            this.static_dateChecked.Text = "DateChecked";
            // 
            // static_topLevelDomainName
            // 
            this.static_topLevelDomainName.AutoSize = true;
            this.static_topLevelDomainName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_topLevelDomainName.Location = new System.Drawing.Point(37, 343);
            this.static_topLevelDomainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_topLevelDomainName.Name = "static_topLevelDomainName";
            this.static_topLevelDomainName.Size = new System.Drawing.Size(148, 18);
            this.static_topLevelDomainName.TabIndex = 151;
            this.static_topLevelDomainName.Text = "TopLevelDomainName";
            // 
            // static_TopLevelDomain
            // 
            this.static_TopLevelDomain.AutoSize = true;
            this.static_TopLevelDomain.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_TopLevelDomain.Location = new System.Drawing.Point(74, 303);
            this.static_TopLevelDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_TopLevelDomain.Name = "static_TopLevelDomain";
            this.static_TopLevelDomain.Size = new System.Drawing.Size(111, 18);
            this.static_TopLevelDomain.TabIndex = 150;
            this.static_TopLevelDomain.Text = "TopLevelDomain";
            // 
            // static_DomainName
            // 
            this.static_DomainName.AutoSize = true;
            this.static_DomainName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_DomainName.Location = new System.Drawing.Point(92, 263);
            this.static_DomainName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_DomainName.Name = "static_DomainName";
            this.static_DomainName.Size = new System.Drawing.Size(93, 18);
            this.static_DomainName.TabIndex = 149;
            this.static_DomainName.Text = "DomainName";
            // 
            // static_MailboxName
            // 
            this.static_MailboxName.AutoSize = true;
            this.static_MailboxName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_MailboxName.Location = new System.Drawing.Point(90, 223);
            this.static_MailboxName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_MailboxName.Name = "static_MailboxName";
            this.static_MailboxName.Size = new System.Drawing.Size(95, 18);
            this.static_MailboxName.TabIndex = 148;
            this.static_MailboxName.Text = "MailboxName";
            // 
            // out_emailAddress
            // 
            this.out_emailAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_emailAddress.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_emailAddress.Location = new System.Drawing.Point(199, 183);
            this.out_emailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.out_emailAddress.Name = "out_emailAddress";
            this.out_emailAddress.ReadOnly = true;
            this.out_emailAddress.Size = new System.Drawing.Size(319, 22);
            this.out_emailAddress.TabIndex = 136;
            // 
            // out_results
            // 
            this.out_results.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_results.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_results.Location = new System.Drawing.Point(199, 143);
            this.out_results.Margin = new System.Windows.Forms.Padding(4);
            this.out_results.Name = "out_results";
            this.out_results.ReadOnly = true;
            this.out_results.Size = new System.Drawing.Size(319, 22);
            this.out_results.TabIndex = 135;
            // 
            // out_recID
            // 
            this.out_recID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.out_recID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_recID.Location = new System.Drawing.Point(199, 103);
            this.out_recID.Margin = new System.Windows.Forms.Padding(4);
            this.out_recID.Name = "out_recID";
            this.out_recID.ReadOnly = true;
            this.out_recID.Size = new System.Drawing.Size(319, 22);
            this.out_recID.TabIndex = 134;
            // 
            // static_emailAddress
            // 
            this.static_emailAddress.AutoSize = true;
            this.static_emailAddress.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_emailAddress.Location = new System.Drawing.Point(93, 183);
            this.static_emailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_emailAddress.Name = "static_emailAddress";
            this.static_emailAddress.Size = new System.Drawing.Size(92, 18);
            this.static_emailAddress.TabIndex = 130;
            this.static_emailAddress.Text = "EmailAddress";
            // 
            // static_results
            // 
            this.static_results.AutoSize = true;
            this.static_results.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_results.Location = new System.Drawing.Point(132, 143);
            this.static_results.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_results.Name = "static_results";
            this.static_results.Size = new System.Drawing.Size(53, 18);
            this.static_results.TabIndex = 129;
            this.static_results.Text = "Results";
            // 
            // static_recID
            // 
            this.static_recID.AutoSize = true;
            this.static_recID.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.static_recID.Location = new System.Drawing.Point(121, 103);
            this.static_recID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.static_recID.Name = "static_recID";
            this.static_recID.Size = new System.Drawing.Size(64, 18);
            this.static_recID.TabIndex = 128;
            this.static_recID.Text = "RecordID";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(543, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(302, 26);
            this.title.TabIndex = 129;
            this.title.Text = "Melissa Data - Global Email Demo";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1431, 738);
            this.Controls.Add(this.title);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.restRequest);
            this.Controls.Add(this.btn_submitREST);
            this.Controls.Add(this.jsonRequest);
            this.Controls.Add(this.btn_submitJSON);
            this.Controls.Add(this.inputElementsBox);
            this.Controls.Add(this.reqOptsBox);
            this.Controls.Add(this.reqElementsBox);
            this.Name = "Form1";
            this.Text = "Melissa Data - Global Email Demo";
            this.reqElementsBox.ResumeLayout(false);
            this.reqElementsBox.PerformLayout();
            this.reqOptsBox.ResumeLayout(false);
            this.reqOptsBox.PerformLayout();
            this.inputElementsBox.ResumeLayout(false);
            this.inputElementsBox.PerformLayout();
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox reqElementsBox;
        private System.Windows.Forms.TextBox in_transRef;
        private System.Windows.Forms.Label static_transRef;
        private System.Windows.Forms.Label static_custID;
        private System.Windows.Forms.TextBox in_CustomerID;
        private System.Windows.Forms.GroupBox reqOptsBox;
        private System.Windows.Forms.ComboBox opt_verifyMailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label220;
        private System.Windows.Forms.ComboBox opt_domainCorrection;
        private System.Windows.Forms.Label label214;
        private System.Windows.Forms.TextBox opt_TimeToWait;
        private System.Windows.Forms.GroupBox inputElementsBox;
        private System.Windows.Forms.TextBox in_emailAddress;
        private System.Windows.Forms.Label in_static_emailAddress;
        private System.Windows.Forms.TextBox restRequest;
        private System.Windows.Forms.Button btn_submitREST;
        private System.Windows.Forms.TextBox jsonRequest;
        private System.Windows.Forms.Button btn_submitJSON;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.Label out_static_rawOutput;
        private System.Windows.Forms.TextBox out_rawOutput;
        private System.Windows.Forms.Label out_transResults;
        private System.Windows.Forms.Label out_transRef;
        private System.Windows.Forms.Label out_version;
        private System.Windows.Forms.Label out_static_transResults;
        private System.Windows.Forms.Label out_static_transRef;
        private System.Windows.Forms.Label out_static_version;
        private System.Windows.Forms.TextBox out_dateChecked;
        private System.Windows.Forms.TextBox out_topLevelDomainName;
        private System.Windows.Forms.TextBox out_topLevelDomain;
        private System.Windows.Forms.TextBox out_domainName;
        private System.Windows.Forms.TextBox out_mailboxName;
        private System.Windows.Forms.Label static_dateChecked;
        private System.Windows.Forms.Label static_topLevelDomainName;
        private System.Windows.Forms.Label static_TopLevelDomain;
        private System.Windows.Forms.Label static_DomainName;
        private System.Windows.Forms.Label static_MailboxName;
        private System.Windows.Forms.TextBox out_emailAddress;
        private System.Windows.Forms.TextBox out_results;
        private System.Windows.Forms.TextBox out_recID;
        private System.Windows.Forms.Label static_emailAddress;
        private System.Windows.Forms.Label static_results;
        private System.Windows.Forms.Label static_recID;
        private System.Windows.Forms.Label title;
    }
}

