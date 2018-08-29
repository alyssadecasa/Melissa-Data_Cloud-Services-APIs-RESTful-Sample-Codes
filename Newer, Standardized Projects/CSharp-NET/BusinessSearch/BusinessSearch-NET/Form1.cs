using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace GlobalBusinessSearch_NET_REST
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
            RESTRequest += @"&id=" + Uri.EscapeDataString(txtLicense.Text);

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
                Options += "SearchType:" + optSearchType.SelectedText + ";";

            // Set the search condition option
            if (optSearchCondition.SelectedIndex != 0)
                Options += "SearchCondition:" + optSearchCondition.SelectedText + ";";

            // Set the sort by option
            if (!string.IsNullOrEmpty(optSortBy.SelectedText))
                Options += "SortBy:" + optSortBy.SelectedText + ";";

            // Set the max phone numbers returned option
            if (!string.IsNullOrEmpty(optMaxPhone.SelectedText) && !optMaxPhone.SelectedText.Equals("3"))
                Options += "MaxPhone:" + optMaxPhone.SelectedText + ";";

            // Set the records per page returned option
            if (!string.IsNullOrEmpty(optRecordsPerPage.SelectedText) && !optRecordsPerPage.SelectedText.Equals("5"))
                Options += "RecordsPerPage:" + optRecordsPerPage.SelectedText + ";";

            // Set the page returned option
            if (optReturnAllPages.Checked)
            {
                Options += "ReturnAllPages:true;";
            }
            else
            {
                if (!string.IsNullOrEmpty(optPageReturned.SelectedText))
                {
                    Options += "Page:" + optPageReturned.SelectedText + ";";
                }
            }

            // Set Options
            RESTRequest += @"&opt=" + Options;

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&comp=" + Uri.EscapeDataString(txtCompanyIn.Text);
            RESTRequest += @"&a1=" + Uri.EscapeDataString(txtAddress1In.Text);
            RESTRequest += @"&a2=" + Uri.EscapeDataString(txtAddress2In.Text);
            RESTRequest += @"&a3=" + Uri.EscapeDataString(txtAddress3In.Text);
            RESTRequest += @"&a4=" + Uri.EscapeDataString(txtAddress4In.Text);
            RESTRequest += @"&a5=" + Uri.EscapeDataString(txtAddress5In.Text);

            RESTRequest += @"&loc=" + Uri.EscapeDataString(txtLocalityIn.Text);
            RESTRequest += @"&area=" + Uri.EscapeDataString(txtAdministrativeAreaIn.Text);
            RESTRequest += @"&postal=" + Uri.EscapeDataString(txtPostalCodeIn.Text);
            RESTRequest += @"&ctry=" + Uri.EscapeDataString(txtCountryIn.Text);

            RESTRequest += @"&phone=" + Uri.EscapeDataString(txtPhoneIn.Text);
            RESTRequest += @"&stock=" + Uri.EscapeDataString(txtStockTickerIn.Text);
            RESTRequest += @"&mak=" + Uri.EscapeDataString(txtMAKIn.Text);
            RESTRequest += @"&mek=" + Uri.EscapeDataString(txtMEKIn.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://globalbusinesssearch.melissadata.net/WEB/" + @"/doBusinessSearch?t=" + RESTRequest;

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
            // Address input fields
            txtAddress1In.Text = "";
            txtAddress2In.Text = "";
            txtAddress3In.Text = "";
            txtAddress4In.Text = "";
            txtAddress5In.Text = "";
            txtLocalityIn.Text = "";
            txtAdministrativeAreaIn.Text = "";
            txtPostalCodeIn.Text = "";
            txtCountryIn.Text = "";

            // Company input fields
            txtCompanyIn.Text = "";
            txtStockTickerIn.Text = "";
            txtMAKIn.Text = "";
            txtMEKIn.Text = "";
            txtWebAddressIn.Text = "";
            txtPhoneIn.Text = "";

            // Reset options to defaults
            optReturnAllPages.Checked = false;
            optMaxPhone.Text = string.Empty;    //todo: appends instead of setting
            optRecordsPerPage.Text = string.Empty;
            optPageReturned.Text = string.Empty;
            optSearchType.SelectedIndex = 0;
            optSearchCondition.SelectedIndex = 0;
            optSortBy.Text = string.Empty;

            // Reset columns to defaults
            for (int i = 0; i < cols.Items.Count; i++)
            {
                cols.SetItemChecked(i, false);
            }
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Global_Business_Search");
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
