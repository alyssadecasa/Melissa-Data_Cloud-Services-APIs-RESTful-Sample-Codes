using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace PersonatorSearch_NET_REST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String RESTRequest = "";
            String Columns = "";
            String Options = "";

            // *************************************************************************************
            // Set the License String in the Request
            // *************************************************************************************
            RESTRequest += @"id=" + Uri.EscapeDataString(txtLicense.Text);

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
            // Set the Options in the Request
            // *************************************************************************************

            // Set the search type option
            if (optSearchType.SelectedIndex != 0)
                Options += "SearchType:" + optSearchType.Text + ",";

            // Set the search condition option
            if (optSearchCondition.SelectedIndex != 0)
                Options += "SearchCondition:" + optSearchCondition.Text + ",";

            // Set the records per page returned option
            if (!string.IsNullOrEmpty(optRecordsPerPage.Text) && !optRecordsPerPage.Text.Equals("5"))
                Options += "RecordsPerPage:" + optRecordsPerPage.Text + ",";

            // Set age range option
            if (!string.IsNullOrEmpty(optAgeRange.Text))
            {
                Options += "AgeRange:" + optAgeRange.Text + ",";
            }

            // Set the page returned option
            if (optReturnAllPages.Checked)
            {
                Options += "ReturnAllPages:true,";
            }
            else
            {
                if (!string.IsNullOrEmpty(optPageReturned.Text))
                {
                    Options += "Page:" + optPageReturned.Text + ",";
                }
            }

            // Set Options
            if (!string.IsNullOrEmpty(Options))
            {
                Options = Options.Substring(0, Options.Length - 1);
                RESTRequest += @"&opt=" + Options;
            }


            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&first=" + Uri.EscapeDataString(txtFirstIn.Text);
            RESTRequest += @"&last=" + Uri.EscapeDataString(txtLastIn.Text);
            RESTRequest += @"&full=" + Uri.EscapeDataString(txtFullIn.Text);

            RESTRequest += @"&a1=" + Uri.EscapeDataString(txtAddress1In.Text);
            RESTRequest += @"&city=" + Uri.EscapeDataString(txtCityIn.Text);
            RESTRequest += @"&state=" + Uri.EscapeDataString(txtStateIn.Text);
            RESTRequest += @"&postal=" + Uri.EscapeDataString(txtPostalIn.Text);

            RESTRequest += @"&phone=" + Uri.EscapeDataString(txtPhoneIn.Text);
            RESTRequest += @"&email=" + Uri.EscapeDataString(txtEmailIn.Text);
            RESTRequest += @"&mak=" + Uri.EscapeDataString(txtMAKIn.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://personatorsearch.melissadata.net/WEB" + @"/doPersonatorSearch?" + RESTRequest;

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
            txtFirstIn.Text = string.Empty;
            txtLastIn.Text = string.Empty;
            txtFullIn.Text = string.Empty;

            // Address input fields
            txtAddress1In.Text = string.Empty;
            txtCityIn.Text = string.Empty;
            txtStateIn.Text = string.Empty;
            txtPostalIn.Text = string.Empty;

            // Other input fields
            txtPhoneIn.Text = string.Empty;
            txtMAKIn.Text = string.Empty;
            txtEmailIn.Text = string.Empty;

            // Reset options to defaults
            optReturnAllPages.Checked = false;
            optRecordsPerPage.Text = string.Empty;
            optPageReturned.Text = string.Empty;
            optSearchType.SelectedIndex = 0;
            optSearchCondition.SelectedIndex = 0;
            optAgeRange.Text = string.Empty;

            // Reset columns to defaults
            for (int i = 0; i < cols.Items.Count; i++)
            {
                cols.SetItemChecked(i, false);
            }
            chkAllCols.Checked = false;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Personator_Search");
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
    }
}
