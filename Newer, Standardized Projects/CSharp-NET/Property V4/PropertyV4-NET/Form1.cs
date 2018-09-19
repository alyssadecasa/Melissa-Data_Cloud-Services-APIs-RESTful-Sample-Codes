using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace PropertyV4_NET_REST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deeds_btnSubmit_Click(object sender, EventArgs e)
        {
            String RESTRequest = "";
            String Columns = "";

            RESTRequest += @"id=" + Uri.EscapeDataString(deeds_id.Text);

            // *************************************************************************************
            // Set the Columns in the Request
            // *************************************************************************************
            foreach (object itemChecked in deeds_cols.CheckedItems)
            {
                Columns += itemChecked.ToString() + ",";
            }

            // Remove last comma
            if (!string.IsNullOrEmpty(Columns))
            {
                Columns = Columns.Substring(0, Columns.Length - 1);
            }
            RESTRequest += @"&cols=" + Columns;

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&fips=" + Uri.EscapeDataString(deeds_fips.Text);
            RESTRequest += @"&apn=" + Uri.EscapeDataString(deeds_apn.Text);
            RESTRequest += @"&mak=" + Uri.EscapeDataString(deeds_mak.Text);
            RESTRequest += @"&ff=" + Uri.EscapeDataString(deeds_ff.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://property.melissadata.net/v4/WEB" + @"/LookupDeeds/?" + RESTRequest;

            // Submit request and output REST Query
            sendRequest(RESTRequest);
        }

        private void property_btnSubmit_Click(object sender, EventArgs e)
        {
            String RESTRequest = "";
            String Columns = "";

            RESTRequest += @"id=" + Uri.EscapeDataString(property_id.Text);

            // *************************************************************************************
            // Set the Columns in the Request
            // *************************************************************************************
            foreach (object itemChecked in property_cols.CheckedItems)
            {
                Columns += itemChecked.ToString() + ",";
            }

            // Remove last comma
            if (!string.IsNullOrEmpty(Columns))
            {
                Columns = Columns.Substring(0, Columns.Length - 1);
            }
            RESTRequest += @"&cols=" + Columns;

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&fips=" + Uri.EscapeDataString(property_fips.Text);
            RESTRequest += @"&addresskey=" + Uri.EscapeDataString(property_addressKey.Text);
            RESTRequest += @"&apn=" + Uri.EscapeDataString(property_apn.Text);
            RESTRequest += @"&mak=" + Uri.EscapeDataString(property_mak.Text);
            RESTRequest += @"&ff=" + Uri.EscapeDataString(property_ff.Text);

            // Include descriptions
            RESTRequest += @"&opt=Desc:On";

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://property.melissadata.net/v4/WEB" + @"/LookupProperty/?" + RESTRequest;

            // Submit request and output REST Query
            sendRequest(RESTRequest);
        }

        private void homesByOwner_btnSubmit_Click(object sender, EventArgs e)
        {
            String RESTRequest = "";

            RESTRequest += @"id=" + Uri.EscapeDataString(homesByOwner_id.Text);

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&mak=" + Uri.EscapeDataString(homesByOwner_mak.Text);
            RESTRequest += @"&ff=" + Uri.EscapeDataString(homesByOwner_ff.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://property.melissadata.net/v4/WEB" + @"/LookupHomesByOwner/?" + RESTRequest;

            // Submit request and output REST Query
            sendRequest(RESTRequest);
        }

        

        private void sendRequest(string RESTRequest) { 

            // Output the REST Query
            txtRESTRequest.Text = RESTRequest;

            // *************************************************************************************
            // Submit to the Web Service. 
            // Make sure to set a retry block in case of any timeouts
            // *************************************************************************************
            Boolean Success = false;
            Int16 RetryCounter = 0;
            Stream ResponseReaderFile = null;
            do
            {
                try
                {
                    HttpWebRequest WebRequestObject = (HttpWebRequest)HttpWebRequest.Create(RESTRequest);
                    WebResponse Response = WebRequestObject.GetResponse();
                    ResponseReaderFile = Response.GetResponseStream();
                    Success = true;
                }
                catch (Exception ex)
                {
                    RetryCounter++;
                    MessageBox.Show("Exception: " + ex.Message);
                    return;
                }
            } while ((Success != true) && (RetryCounter < 5));

            // *************************************************************************************
            // Output Formatted JSON String
            // *************************************************************************************
            StreamReader Reader = new StreamReader(ResponseReaderFile, Encoding.UTF8);
            String ResponseString = Reader.ReadToEnd();

            txtResponse.Text = JValue.Parse(ResponseString).ToString(Newtonsoft.Json.Formatting.Indented);
        }

        // *************************************************************************************
        // Clear the Input Strings
        // *************************************************************************************
        private void deeds_btnClear_Click(object sender, EventArgs e)
        {
            deeds_id.Text = string.Empty;
            deeds_fips.Text = string.Empty;
            deeds_apn.Text = string.Empty;
            deeds_mak.Text = string.Empty;
            deeds_ff.Text = string.Empty;
            deeds_chkAllCols.Checked = false;
            for (int i = 0; i < deeds_cols.Items.Count; i++)
            {
                deeds_cols.SetItemChecked(i, false);
            }
            txtResponse.Text = string.Empty;
            txtRESTRequest.Text = string.Empty;
        }

        private void property_btnClear_Click(object sender, EventArgs e)
        {
            property_id.Text = string.Empty;
            property_addressKey.Text = string.Empty;
            property_fips.Text = string.Empty;
            property_apn.Text = string.Empty;
            property_mak.Text = string.Empty;
            property_ff.Text = string.Empty;
            property_chkAllCols.Checked = false;
            for (int i = 0; i < property_cols.Items.Count; i++)
            {
                property_cols.SetItemChecked(i, false);
            }
            txtResponse.Text = string.Empty;
            txtRESTRequest.Text = string.Empty;
        }

        private void homesByOwner_btnClear_Click(object sender, EventArgs e)
        {
            homesByOwner_id.Text = string.Empty;
            homesByOwner_mak.Text = string.Empty;
            homesByOwner_ff.Text = string.Empty;
            txtResponse.Text = string.Empty;
            txtRESTRequest.Text = string.Empty;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Property_V4");
        }

        // *************************************************************************************
        // Check all Column Boxes
        // *************************************************************************************
        private void deeds_chkAllCols_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < deeds_cols.Items.Count; i++)
            {
                deeds_cols.SetItemChecked(i, deeds_chkAllCols.Checked);
            }
        }

        private void property_chkAllCols_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < property_cols.Items.Count; i++)
            {
                property_cols.SetItemChecked(i, property_chkAllCols.Checked);
            }
        }
    }
}
