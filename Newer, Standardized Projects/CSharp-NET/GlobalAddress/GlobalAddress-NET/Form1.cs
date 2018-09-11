using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace GlobalAddress_NET_REST
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
            String Options = "";

            // *************************************************************************************
            // Set the License String in the Request
            // *************************************************************************************
            RESTRequest += @"&id=" + Uri.EscapeDataString(txtLicense.Text);
          
            // *************************************************************************************
            // Set the Options in the Request
            // *************************************************************************************

            // Set the delivery lines option
            if (!string.IsNullOrEmpty(optDeliveryLines.Text))
                Options += "DeliveryLines:" + optDeliveryLines.Text + ",";

            // Set the line separator option
            if (!string.IsNullOrEmpty(optLineSeparator.Text))
                Options += "LineSeparator:" + optLineSeparator.Text + ",";

            // Set the output script option
            if (!string.IsNullOrEmpty(optOutputScript.Text))
                Options += "OutputScript:" + optOutputScript.Text + ",";

            // Set the output geocode option
            if (!string.IsNullOrEmpty(optOutputGeocode.Text))
                Options += "OutputGeo:" + optOutputGeocode.Text + ",";

            // Set the country of origin option
            if (!string.IsNullOrEmpty(optCountryOfOrigin.SelectedText))
                Options += "CountryOfOrigin:" + optCountryOfOrigin.Text + ",";

            // Set Options
            if (Options.Length > 0)
            {
                Options = Options.Substring(0, Options.Length - 1);
                RESTRequest += @"&opt=" + Options;
            }

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&a1=" + Uri.EscapeDataString(txtAddress1In.Text);
            RESTRequest += @"&a2=" + Uri.EscapeDataString(txtAddress2In.Text);
            RESTRequest += @"&a3=" + Uri.EscapeDataString(txtAddress3In.Text);
            RESTRequest += @"&a4=" + Uri.EscapeDataString(txtAddress4In.Text);
            RESTRequest += @"&a5=" + Uri.EscapeDataString(txtAddress5In.Text);
            RESTRequest += @"&a6=" + Uri.EscapeDataString(txtAddress6In.Text);
            RESTRequest += @"&a7=" + Uri.EscapeDataString(txtAddress7In.Text);
            RESTRequest += @"&a8=" + Uri.EscapeDataString(txtAddress8In.Text);

            RESTRequest += @"&ddeploc=" + Uri.EscapeDataString(txtDdeplocIn.Text);
            RESTRequest += @"&deploc=" + Uri.EscapeDataString(txtDeplocIn.Text);
            RESTRequest += @"&loc=" + Uri.EscapeDataString(txtLocIn.Text);
            RESTRequest += @"&subadmarea=" + Uri.EscapeDataString(txtSubadmareaIn.Text);
            RESTRequest += @"&admarea=" + Uri.EscapeDataString(txtAdmareaIn.Text);
            RESTRequest += @"&subnatarea=" + Uri.EscapeDataString(txtSubnatareaIn.Text);
            RESTRequest += @"&postal=" + Uri.EscapeDataString(txtPostalCodeIn.Text);
            RESTRequest += @"&ctry=" + Uri.EscapeDataString(txtCountryIn.Text);

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"http://address.melissadata.net/V3/WEB/GlobalAddress" + @"/doGlobalAddress?t=" + RESTRequest;

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
            txtAddress6In.Text = "";
            txtAddress7In.Text = "";
            txtAddress8In.Text = "";
            txtDdeplocIn.Text = "";
            txtDeplocIn.Text = "";
            txtLocIn.Text = "";
            txtSubadmareaIn.Text = "";
            txtAdmareaIn.Text = "";
            txtSubnatareaIn.Text = "";
            txtPostalCodeIn.Text = "";
            txtCountryIn.Text = "";

            // Reset options to defaults
            optDeliveryLines.Text = string.Empty;
            optLineSeparator.Text = string.Empty;
            optOutputScript.Text = string.Empty;
            optOutputGeocode.Text = string.Empty;
            optCountryOfOrigin.Text = string.Empty;

            // Clear the output
            txtResponse.Text = string.Empty;
            txtRESTRequest.Text = string.Empty;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Global_Address_Verification");
        }
    }
}
