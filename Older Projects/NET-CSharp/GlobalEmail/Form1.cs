using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace GEmail_CSharpApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Generates a windows application for clients to try sending
        /// requests and recieving responses from the Global Email API
        /// </summary>

        String serviceURI = "/v3/WEB/GlobalEmail/doGlobalEmail";
        String serviceURL = "https://globalemail.melissadata.net";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Copies the input stream into memory and closes the original
        /// stream
        /// </summary>
        /// <param name="inputStream">the stream to be written into memory</param>
        /// <returns>memory-stored stream</returns>
        private static Stream CopyAndClose(Stream inputStream)
        {
            const int readSize = 256;
            byte[] buffer = new byte[readSize];
            MemoryStream ms = new MemoryStream();

            int count = inputStream.Read(buffer, 0, readSize);
            while (count > 0)
            {
                ms.Write(buffer, 0, count);
                count = inputStream.Read(buffer, 0, readSize);
            }
            ms.Position = 0;
            inputStream.Close();
            return ms;
        }

        /// <summary>
        /// Clears the output
        /// </summary>
        private void ClearOutput()
        {
            out_version.Text = "";
            out_transRef.Text = "";
            out_transResults.Text = "";
            out_recID.Text = "";
            out_results.Text = "";
            out_emailAddress.Text = "";
            out_mailboxName.Text = "";
            out_domainName.Text = "";
            out_topLevelDomainName.Text = "";
            out_topLevelDomainName.Text = "";
            out_dateChecked.Text = "";
            out_rawOutput.Text = "";
        }

        /// <summary>
        /// Event handler in the case that the JSON submit button is clicked.
        /// Sends a JSON request to the Global Email API, recieves the response,
        /// and formats the response onto the application
        /// </summary>
        /// <param name="sender">button that was clicked</param>
        /// <param name="e">event args</param>
        private void Btn_submitJSON_Click(object sender, EventArgs e)
        {
            out_rawOutput.Text = string.Empty;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            ClearOutput();
            btn_submitJSON.Enabled = false;
            btn_submitREST.Enabled = false;

            String finalURL = serviceURL + serviceURI;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(finalURL));
            request.Method = "POST";
            request.Accept = "application/json";
            request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
            request.AutomaticDecompression = DecompressionMethods.GZip;
            Byte[] data = UTF8Encoding.UTF8.GetBytes(jsonRequest.Text);
            Stream reqStream;

            try
            {
                reqStream = request.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                if (!reqStream.Equals(null))
                    reqStream.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream outStream = CopyAndClose(response.GetResponseStream());
            StreamReader reader = new StreamReader(outStream);
            String rawData = reader.ReadToEnd();
            outStream.Position = 0;

            System.Runtime.Serialization.Json.DataContractJsonSerializer jsonSerializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(GEmailResponse));
            GEmailResponse outputData = (GEmailResponse)jsonSerializer.ReadObject(outStream);
            watch.Stop();
            try
            {
                //Return output elements to their corresponding text boxes
                out_version.Text += outputData.Version + " (";
                out_version.Text += finalURL + ")";
                out_transRef.Text = outputData.TransmissionReference;
                out_transResults.Text = outputData.TransmissionResults;
                out_recID.Text = outputData.Records[0].RecordID;
                out_results.Text = outputData.Records[0].Results;
                out_emailAddress.Text = outputData.Records[0].EmailAddress;
                out_mailboxName.Text = outputData.Records[0].MailboxName;
                out_domainName.Text = outputData.Records[0].DomainName;
                out_topLevelDomain.Text = outputData.Records[0].TopLevelDomain;
                out_topLevelDomainName.Text = outputData.Records[0].TopLevelDomainName;
                out_dateChecked.Text = outputData.Records[0].DateChecked;

                TimeSpan ts = watch.Elapsed;
                out_transResults.Text = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10) + " second(s) elapsed";
                rawData = rawData.Replace("{", "{" + Environment.NewLine + "\t");
                rawData = rawData.Replace("}", Environment.NewLine + "}");
                rawData = rawData.Replace("\",", "\"," + Environment.NewLine + "\t");
                out_rawOutput.Text = rawData;
            }
            catch (Exception ex)
            {
                if (outputData.TransmissionResults == "GE04")
                    MessageBox.Show("CustomerID is empty.\n Please enter a valid Customer ID or contact a Melissa Data sales rep for more info.");
                else if (outputData.TransmissionResults == "GE05")
                    MessageBox.Show("CustomerID is invalid.\n Please enter a valid Customer ID or contact a Melissa Data sales rep for more info.");
                else if (outputData.TransmissionResults == "GE06")
                    MessageBox.Show("CustomerID is disable for this service.\n Please contact your Sales Rep for more info.");
                else
                    Debug.WriteLine("Something bad happened with request: " + ex);
            }
            btn_submitJSON.Enabled = true;
            btn_submitREST.Enabled = true;
        }

        /// <summary>
        /// Event handler in the case that the REST submit button is clicked.
        /// Sends a REST request to the Global Email API, recieves the response,
        /// and formats the response onto the application
        /// </summary>
        /// <param name="sender"> button that was clicked</param>
        /// <param name="e">event arguments</param>
        private void Btn_submitREST_Click(object sender, EventArgs e)
        {
            out_rawOutput.Text = string.Empty;

            Stopwatch watch = new Stopwatch();
            btn_submitREST.Enabled = false;
            btn_submitJSON.Enabled = false;
            watch.Start();
            ClearOutput();

            //Create the request and response objects
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GenerateRESTRequest());
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream outStream = CopyAndClose(response.GetResponseStream());
            StreamReader reader = new StreamReader(outStream);
            String rawData = reader.ReadToEnd();
            outStream.Position = 0;
            System.Runtime.Serialization.Json.DataContractJsonSerializer jsonSerializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(GEmailResponse));
            GEmailResponse outputData = (GEmailResponse)jsonSerializer.ReadObject(outStream);

            watch.Stop();

            //Write responses out to their specified txt boxes
            try
            {
                out_version.Text = outputData.Version;
                out_transRef.Text = outputData.TransmissionReference;
                out_transResults.Text = outputData.TransmissionResults;
                out_recID.Text = outputData.Records[0].RecordID;
                out_results.Text = outputData.Records[0].Results;
                out_emailAddress.Text = outputData.Records[0].EmailAddress;
                out_mailboxName.Text = outputData.Records[0].MailboxName;
                out_domainName.Text = outputData.Records[0].DomainName;
                out_topLevelDomain.Text = outputData.Records[0].TopLevelDomain;
                out_topLevelDomainName.Text = outputData.Records[0].TopLevelDomainName;
                out_dateChecked.Text = outputData.Records[0].DateChecked;

                //Output raw data
                rawData = rawData.Replace("{", "{" + Environment.NewLine + "\t");
                rawData = rawData.Replace("}", Environment.NewLine + "}");
                rawData = rawData.Replace("\",", "\"," + Environment.NewLine + "\t");
                out_rawOutput.Text = rawData;

                //Timer
                TimeSpan ts = watch.Elapsed;
                out_transResults.Text = String.Format("{0:00}.{1:00}", ts.Seconds, ts.Milliseconds / 10) + " second(s) elapsed";

            }
            catch (Exception ex)
            {
                if (outputData.TransmissionResults == "GE04")
                    MessageBox.Show("CustomerID is empty.\n Please enter a valid Customer ID or contact a Melissa Data sales rep for more info.");
                else if (outputData.TransmissionResults == "GE05")
                    MessageBox.Show("CustomerID is invalid.\n Please enter a valid Customer ID or contact a Melissa Data sales rep for more info.");
                else if (outputData.TransmissionResults == "GE06")
                    MessageBox.Show("CustomerID is disable for this service.\n Please contact your Sales Rep for more info.");
                else
                    Debug.WriteLine("An error has occured in rest request: " + ex);
            }
            btn_submitREST.Enabled = true;
            btn_submitJSON.Enabled = true;

        }

        /// <summary>
        /// Generates Global Email API request in REST format
        /// </summary>
        /// <returns>string-formatted REST request</returns>
        private string GenerateRESTRequest()
        {
            //Generate the REST request using elements from the form
            String restRequest = serviceURL + serviceURI;

            restRequest += "?t=" + in_transRef.Text
                + "&id=" + in_CustomerID.Text
                + "&opt=";

            //Add verifyMailbox, domainCorrection, and timeToWait options if set
            if (opt_verifyMailbox.Text == "Premium")
            {
                restRequest += "VerifyMailbox:Premium,";
            }
            else
            {
                restRequest += "VerifyMailbox:Express,";
            }

            if (opt_domainCorrection.Text == "On")
            {
                restRequest += "DomainCorrection:true,";
            }

            if (opt_TimeToWait.TextLength > 0)
            {
                restRequest += "TimeToWait:" + opt_TimeToWait.Text + ",";
            }

            restRequest = restRequest.TrimEnd(',');

            String[] emails = in_emailAddress.Text.Split(',');

            restRequest += "&email=" + emails[0];
            restRequest += "&format=JSON";

            return restRequest;
        }

        /// <summary>
        /// Generates Global Email API request in JSON format
        /// </summary>
        /// <returns>string-formatted JSON request</returns>
        private string GenerateJSONRequest()
        {
            String jsonRequest = "";
            jsonRequest += "{\"CustomerID\":\"" + in_CustomerID.Text + "\",";
            jsonRequest += "\"TransmissionReference\":\"" + in_transRef.Text + "\",";
            jsonRequest += "\"Options\":\"VerifyMailbox:";
            if (opt_verifyMailbox.Text.Contains("Express (Default)") || !opt_verifyMailbox.Text.Contains("Premium"))
            {
                jsonRequest += "Express" + ",";
            }
            else
            {
                jsonRequest += "Premium" + ",";

            }
            if (opt_domainCorrection.Text.Contains("On"))
            {
                jsonRequest += "DomainCorrection:true,";
            }
            if (opt_TimeToWait.Text.Length > 0)
            {
                jsonRequest += "TimeToWait:" + opt_TimeToWait.Text;
            }
            jsonRequest = jsonRequest.TrimEnd(',');
            jsonRequest += "\",";
            jsonRequest += "\"Records\":[{";
            String[] emails = in_emailAddress.Text.Split(',');
            int i = 0;
            foreach (String item in emails)
            {
                i++;
                if (i <= 100 && !item.Equals(""))
                {
                    if (i > 1)
                    {
                        jsonRequest += "{";
                    }
                    jsonRequest += "\"RecordID\":\"" + i + "\",";
                    jsonRequest += "\"Email\":\"" + item + "\",";
                }
            }
            jsonRequest = jsonRequest.TrimEnd(',');
            jsonRequest += "}]}";
            return jsonRequest;
        }

        /// <summary>
        /// Event handler in the case that any of the input fields are changed by 
        /// the user. The REST and JSON request textboxes are updated with the new
        /// information from the input fields
        /// </summary>
        /// <param name="sender">input field with changed text</param>
        /// <param name="e">event arguments</param>
        private void UpdateRequests(object sender, EventArgs e)
        {
            //When a change is made to any of the input boxes, re-generate the REST request
            restRequest.Text = GenerateRESTRequest();
            jsonRequest.Text = GenerateJSONRequest();
        }
    }
}
