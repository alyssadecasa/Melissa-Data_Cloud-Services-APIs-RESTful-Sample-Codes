﻿namespace StreetRoute_NET_REST
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
            this.tabInput = new System.Windows.Forms.TabPage();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.inputStartLatitude = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabResponse = new System.Windows.Forms.TabControl();
            this.tabServiceResponse = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tabRESTRequest = new System.Windows.Forms.TabPage();
            this.txtRESTRequest = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            this.inputEndLongitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputStartLongitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEndLatitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputUnits = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabInput.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(125, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 619);
            this.panel1.TabIndex = 1;
            // 
            // tabRequest
            // 
            this.tabRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabRequest.Controls.Add(this.tabInput);
            this.tabRequest.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabRequest.Location = new System.Drawing.Point(28, 26);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.SelectedIndex = 0;
            this.tabRequest.Size = new System.Drawing.Size(298, 568);
            this.tabRequest.TabIndex = 16;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabInput.Controls.Add(this.inputUnits);
            this.tabInput.Controls.Add(this.label6);
            this.tabInput.Controls.Add(this.inputEndLatitude);
            this.tabInput.Controls.Add(this.label5);
            this.tabInput.Controls.Add(this.inputStartLongitude);
            this.tabInput.Controls.Add(this.label4);
            this.tabInput.Controls.Add(this.inputEndLongitude);
            this.tabInput.Controls.Add(this.label3);
            this.tabInput.Controls.Add(this.txtLicense);
            this.tabInput.Controls.Add(this.inputStartLatitude);
            this.tabInput.Controls.Add(this.label25);
            this.tabInput.Controls.Add(this.btnClear);
            this.tabInput.Controls.Add(this.btnSubmit);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(290, 542);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            // 
            // txtLicense
            // 
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLicense.Location = new System.Drawing.Point(18, 31);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(250, 22);
            this.txtLicense.TabIndex = 0;
            this.txtLicense.Text = "Enter your license key here";
            // 
            // inputStartLatitude
            // 
            this.inputStartLatitude.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.inputStartLatitude.Location = new System.Drawing.Point(18, 98);
            this.inputStartLatitude.Name = "inputStartLatitude";
            this.inputStartLatitude.Size = new System.Drawing.Size(250, 22);
            this.inputStartLatitude.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(15, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 15);
            this.label25.TabIndex = 54;
            this.label25.Text = "License String";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(98, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(172, 410);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Latitude";
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
            this.tabResponse.Size = new System.Drawing.Size(709, 572);
            this.tabResponse.TabIndex = 1;
            // 
            // tabServiceResponse
            // 
            this.tabServiceResponse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabServiceResponse.Controls.Add(this.txtResponse);
            this.tabServiceResponse.Location = new System.Drawing.Point(4, 22);
            this.tabServiceResponse.Name = "tabServiceResponse";
            this.tabServiceResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceResponse.Size = new System.Drawing.Size(701, 546);
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
            this.txtResponse.Size = new System.Drawing.Size(709, 550);
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
            this.tabRESTRequest.Size = new System.Drawing.Size(701, 546);
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
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Street Route Sample";
            // 
            // lnkWiki
            // 
            this.lnkWiki.AutoSize = true;
            this.lnkWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWiki.LinkColor = System.Drawing.Color.SkyBlue;
            this.lnkWiki.Location = new System.Drawing.Point(448, 65);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(126, 15);
            this.lnkWiki.TabIndex = 7;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "Wiki Reference Guide";
            this.lnkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWiki_LinkClicked);
            // 
            // inputEndLongitude
            // 
            this.inputEndLongitude.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.inputEndLongitude.Location = new System.Drawing.Point(18, 287);
            this.inputEndLongitude.Name = "inputEndLongitude";
            this.inputEndLongitude.Size = new System.Drawing.Size(250, 22);
            this.inputEndLongitude.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(15, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "End Longitude";
            // 
            // inputStartLongitude
            // 
            this.inputStartLongitude.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.inputStartLongitude.Location = new System.Drawing.Point(18, 161);
            this.inputStartLongitude.Name = "inputStartLongitude";
            this.inputStartLongitude.Size = new System.Drawing.Size(250, 22);
            this.inputStartLongitude.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Start Longitude";
            // 
            // inputEndLatitude
            // 
            this.inputEndLatitude.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.inputEndLatitude.Location = new System.Drawing.Point(18, 224);
            this.inputEndLatitude.Name = "inputEndLatitude";
            this.inputEndLatitude.Size = new System.Drawing.Size(250, 22);
            this.inputEndLatitude.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(15, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "End Latitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(15, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 61;
            this.label6.Text = "Units";
            // 
            // inputUnits
            // 
            this.inputUnits.FormattingEnabled = true;
            this.inputUnits.Items.AddRange(new object[] {
            "Miles",
            "Kilometers"});
            this.inputUnits.Location = new System.Drawing.Point(18, 350);
            this.inputUnits.Name = "inputUnits";
            this.inputUnits.Size = new System.Drawing.Size(250, 21);
            this.inputUnits.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1290, 773);
            this.Controls.Add(this.lnkWiki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Street Route Sample Code";
            this.panel1.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
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
        private System.Windows.Forms.TextBox txtRESTRequest;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.LinkLabel lnkWiki;
        private System.Windows.Forms.TabControl tabRequest;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox inputStartLatitude;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputEndLatitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputStartLongitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputEndLongitude;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox inputUnits;
        private System.Windows.Forms.Label label6;
    }
}

