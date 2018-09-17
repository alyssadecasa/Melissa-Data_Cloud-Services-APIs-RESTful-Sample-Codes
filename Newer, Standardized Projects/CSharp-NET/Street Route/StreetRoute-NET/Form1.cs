using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace StreetRoute_NET_REST
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

            // *************************************************************************************
            // Set the License String in the Request
            // *************************************************************************************
            RESTRequest += @"id=" + Uri.EscapeDataString(txtLicense.Text);

            // *************************************************************************************
            // Set the Input Parameters
            // *************************************************************************************
            RESTRequest += @"&startLatitude=" + Uri.EscapeDataString(inputStartLatitude.Text);
            RESTRequest += @"&startLongitude=" + Uri.EscapeDataString(inputStartLongitude.Text);
            RESTRequest += @"&endLatitude=" + Uri.EscapeDataString(inputEndLatitude.Text);
            RESTRequest += @"&endLongitude=" + Uri.EscapeDataString(inputEndLongitude.Text);
            if (inputUnits.Text.Equals("Miles"))
            {
                RESTRequest += @"&Units=" + Uri.EscapeDataString(inputUnits.Text);
            } else if (inputUnits.Text.Equals("Kilometers"))
            {
                RESTRequest += @"&Units=" + Uri.EscapeDataString(inputUnits.Text);
            }

            // Set JSON Response Protocol
            RESTRequest += @"&format=json";

            // Build the final REST String Query
            RESTRequest = @"https://streetroute.melissadata.net/v1/WEB/StreetRoute" + @"/getDistance?" + RESTRequest;

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
        // Clear all
        // *************************************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            // inputs
            inputStartLatitude.Text = string.Empty;
            inputStartLongitude.Text = string.Empty;
            inputEndLatitude.Text = string.Empty;
            inputEndLongitude.Text = string.Empty;

            // request and response
            txtRESTRequest.Text = string.Empty;
            txtResponse.Text = string.Empty;
        }

        // *************************************************************************************
        // Wiki Link
        // *************************************************************************************
        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://wiki.melissadata.com/index.php?title=Street_Route");
        }
    }
}
