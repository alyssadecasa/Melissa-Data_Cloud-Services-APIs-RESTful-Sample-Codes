using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace BusinessCoderUK_NET_REST
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

            // *************************************************************************************
            // Set the License String in the Request
            // *************************************************************************************
            RESTRequest += @"id=" + Uri.EscapeDataString(txtLicense.Text);

            // *************************************************************************************
            // Set the Columns in the Request
            // *************************************************************************************
            foreach (object itemChecked in colsGroup.CheckedItems)
            {
                Columns += itemChecked.ToString() + ",";
            }
            
            // Set Options
            if (Columns.Contains(","))
            {
                Columns = Columns.Substring(0, Columns.Length - 1);
                RESTRequest += @"&cols=" + Columns;
            }

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&comp=" + Uri.EscapeDataString(txtCompanyIn.Text);
            RESTRequest += @"&a1=" + Uri.EscapeDataString(txtA1In.Text);
            RESTRequest += @"&a2=" + Uri.EscapeDataString(txtA2In.Text);
            RESTRequest += @"&a3=" + Uri.EscapeDataString(txtA3In.Text);
            RESTRequest += @"&a4=" + Uri.EscapeDataString(txtA4In.Text);
            RESTRequest += @"&ddloc=" + Uri.EscapeDataString(txtDdlocIn.Text);
            RESTRequest += @"&dloc=" + Uri.EscapeDataString(txtDlocIn.Text);
            RESTRequest += @"&loc=" + Uri.EscapeDataString(txtLocIn.Text);
            RESTRequest += @"&sarea=" + Uri.EscapeDataString(txtSareaIn.Text);
            RESTRequest += @"&area=" + Uri.EscapeDataString(txtAreaIn.Text);
            RESTRequest += @"&subnat=" + Uri.EscapeDataString(txtSubnatIn.Text);
            RESTRequest += @"&postal=" + Uri.EscapeDataString(txtPostalCodeIn.Text);
            RESTRequest += @"&ctry=" + Uri.EscapeDataString(txtCountryIn.Text);
            RESTRequest += @"&mak=" + Uri.EscapeDataString(txtMAKIn.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query TODO
            RESTRequest = @"https://globalbusinesscoder.melissadata.net/WEB/BusinessCoder" + @"/doBusinessCoderGB?" + RESTRequest;

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
            txtA1In.Text = "";
            txtA2In.Text = "";
            txtA3In.Text = "";
            txtA4In.Text = "";
            txtDdlocIn.Text = "";
            txtDlocIn.Text = "";
            txtLocIn.Text = "";
            txtSareaIn.Text = "";
            txtAreaIn.Text = "";
            txtPostalCodeIn.Text = "";
            txtCountryIn.Text = "";
            txtSubnatIn.Text = "";

            // Company input fields
            txtCompanyIn.Text = "";
            txtMAKIn.Text = "";

            // Reset columns to defaults
            chkAllGroupCols.Checked = false;
            for (int i = 0; i < colsGroup.Items.Count; i++)
            {
                colsGroup.SetItemChecked(i, false);
            }

            // Clear outputs
            txtResponse.Text = string.Empty;
            txtRESTRequest.Text = string.Empty;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Business_Coder_UK");
        }

        // *************************************************************************************
        // Check all Column Boxes
        // *************************************************************************************
        private void chkAllGroupCols_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < colsGroup.Items.Count; i++)
            {
                colsGroup.SetItemChecked(i, chkAllGroupCols.Checked);
            }
        }
    }
}
