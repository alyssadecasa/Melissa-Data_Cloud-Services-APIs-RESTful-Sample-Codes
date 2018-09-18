using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace SmartMover_NET_REST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string RESTRequest = "";
            string Columns = "";
            string Options = "";
            string Actions = "";

            // *************************************************************************************
            // Set the License String and PAF ID in the Request
            // *************************************************************************************
            RESTRequest += @"id=" + Uri.EscapeDataString(txtLicense.Text);
            if (!string.IsNullOrEmpty(txtPafId.Text))
                RESTRequest += @"pafid=" + Uri.EscapeDataString(txtPafId.Text);

            // *************************************************************************************
            // Set the Columns in the Request
            // *************************************************************************************
            foreach (object itemChecked in cols.CheckedItems)
            {
                Columns += itemChecked.ToString() + ",";
            }

            // Remove last comma in columns string
            if (Columns.Contains(","))
            {
                Columns = Columns.Substring(0, Columns.Length - 1);
            }

            RESTRequest += @"&cols=" + Columns;

            // *************************************************************************************
            // Set the Actions in the Request
            // *************************************************************************************
            foreach (object itemChecked in actions.CheckedItems)
            {
                Actions += itemChecked.ToString() + ",";
            }

            // Remove last comma in columns string
            if (Actions.Contains(","))
            {
                Actions = Actions.Substring(0, Actions.Length - 1);
            }

            RESTRequest += @"&actions=" + Actions;

            // *************************************************************************************
            // Set the Options in the Request
            // *************************************************************************************

            // Set the processing type option
            if (!string.IsNullOrEmpty(optProcessingType.Text))
                Options += "ProcessingType:" + optProcessingType.Text + ",";

            // Set list owner freq processing option
            if (!string.IsNullOrEmpty(optListOwnerFreqProcessing.Text))
                Options += "ListOwnerFreqProcessing:" + optListOwnerFreqProcessing.Text + ",";
            
            // Set number of months requested option
            if (!string.IsNullOrEmpty(optNumberOfMonthsRequested.Text))
                Options += "NumberofMonthsRequested:" + optNumberOfMonthsRequested.Text + ",";

            // Set Options
            if (!string.IsNullOrEmpty(Options))
            {
                Options = Options.Substring(0, Options.Length - 1);
            }
            RESTRequest += @"&opt=" + Options;


            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&first=" + Uri.EscapeDataString(txtFirst.Text);
            RESTRequest += @"&middle=" + Uri.EscapeDataString(txtMiddle.Text);
            RESTRequest += @"&last=" + Uri.EscapeDataString(txtLast.Text);
            RESTRequest += @"&namepre=" + Uri.EscapeDataString(txtPrefix.Text);
            RESTRequest += @"&namesfx=" + Uri.EscapeDataString(txtSuffix.Text);
            RESTRequest += @"&full=" + Uri.EscapeDataString(txtFull.Text);

            RESTRequest += @"&a1=" + Uri.EscapeDataString(txtAddress1.Text);
            RESTRequest += @"&a2=" + Uri.EscapeDataString(txtAddress2.Text);
            RESTRequest += @"&city=" + Uri.EscapeDataString(txtAddress2.Text);
            RESTRequest += @"&state=" + Uri.EscapeDataString(txtCity.Text);
            RESTRequest += @"&postal=" + Uri.EscapeDataString(txtState.Text);
            RESTRequest += @"&ctry=" + Uri.EscapeDataString(txtCountry.Text);
            RESTRequest += @"&plus4=" + Uri.EscapeDataString(txtPlus4.Text);
            RESTRequest += @"&u=" + Uri.EscapeDataString(txtUrbanization.Text);
            RESTRequest += @"&ste=" + Uri.EscapeDataString(txtSuite.Text);
            RESTRequest += @"&pmb=" + Uri.EscapeDataString(txtPrivateMailbox.Text);

            RESTRequest += @"&comp=" + Uri.EscapeDataString(txtCompany.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://smartmover.melissadata.net/v3/WEB/SmartMover" + @"/doSmartMover?" + RESTRequest;

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
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Name input fields
            txtFull.Text = string.Empty;
            txtFirst.Text = string.Empty;
            txtMiddle.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtPrefix.Text = string.Empty;
            txtSuffix.Text = string.Empty;

            // Address input fields
            txtAddress1.Text = string.Empty;
            txtAddress2.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtState.Text = string.Empty;
            txtPostal.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPlus4.Text = string.Empty;
            txtUrbanization.Text = string.Empty;
            txtSuite.Text = string.Empty;
            txtPrivateMailbox.Text = string.Empty;

            // Other input fields
            txtCompany.Text = string.Empty;

            // Reset options to defaults
            optProcessingType.Text = string.Empty;
            optNumberOfMonthsRequested.Text = string.Empty;
            optListOwnerFreqProcessing.Text = string.Empty;

            // Reset columns to defaults
            for (int i = 0; i < cols.Items.Count; i++)
            {
                cols.SetItemChecked(i, false);
            }
            chkAllCols.Checked = false;

            // Reset actions
            for (int i = 0; i < actions.Items.Count; i++)
            {
                actions.SetItemChecked(i, false);
            }
            chkAllActions.Checked = false;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=SmartMover_V3");
        }

        // *************************************************************************************
        // Check all Column Boxes
        // *************************************************************************************
        private void chkAllCols_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cols.Items.Count; i++)
            {
                cols.SetItemChecked(i, chkAllCols.Checked);
            }
        }

        // *************************************************************************************
        // Check all Action Boxes
        // *************************************************************************************
        private void chkAllActions_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < actions.Items.Count; i++)
            {
                actions.SetItemChecked(i, chkAllActions.Checked);
            }
        }
    }
}
