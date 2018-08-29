/**
 * GlobalEmail
 * Main.java
 * 
 * Program Description: This program creates and opens a java swing application with which Users use as an interface to input their
 * license key and an email that they would like to look up on Melissa Data's Global Email Web Service. Upon clicking
 * the submit button, this program will create a REST Request with the inputted information and return the REST Response
 * in a JSON document named JSONResponse.json and display the results on the java swing application.
 * 
 * @author Alyssa House
 */

package globalEmail;

import java.awt.BorderLayout;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.MouseListener;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;

import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.*;

public class Main {
	// Private Fields for request elements
	private static String custID = "";
	private static JTextField txtCustomerID;
	private static JComboBox<String> mailboxVal;
	private static JTextField txtEmailAddress;

	// Private Fields for response elements
	private static URL url;
	private static JTextArea txtCompleteOutput;
	private static JTextField txtResultCodes;
	private static JTextField txtTopLevelDomainName;
	private static JTextField txtTopLevelDomain;
	private static JTextField txtDomainName;
	private static JTextField txtMailboxName;
	private static JTextField txtOutEmailAddress;

	public static void main(String[] args) {
		display();
	}

	/**
	 * Displays a java swing frame with and labels textAreas specific to Melissa Data's Global Email Web Service's 
	 * REST Request fields and Response fields
	 */
	public static void display() {
		JFrame frm;
		JPanel panel;
		JPanel panel2;
		
		JLabel labelInput;
		JLabel labelOutput;
		JLabel labelCustomerID;
		JLabel labelEmailAddress;
		JLabel labelEmailAddress2;
		JLabel labelMailboxVal;
		JLabel labelMailboxName;
		JLabel labelDomainName;
		JLabel labelTopLevelDomain;
		JLabel labelTopLevelDomainName;
		JLabel labelResultCodes;
		JLabel labelCompleteOutput;
		
		JTextArea txtHeader;
		JTextArea txtMailboxVal;
		JTextArea txtMailboxVal2;
		JTextArea txtResultCodeInfo;
		
		String[] mailboxValOptions = new String[2];
		
		JButton buttonSubmit;
		MouseListener mouseListener;

		// Create Frame
		frm = new JFrame("Global Email");
		frm.setSize(800, 600);
		frm.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		// Application Header (Welcome Message)
		txtHeader = new JTextArea("Welcome to the Melissa Data Global Email Web Service. Validate and parse email addresses,"
				+ " correct common typographical errors, \nand standardize email addresses. Features"
				+ " realtime email mailbox validation which removes up to 95% of bad emails.");
		txtHeader.setEditable(false);
		txtHeader.setOpaque(false);
		txtHeader.setFont(txtHeader.getFont().deriveFont(Font.BOLD));
		panel2 = new JPanel();
		panel2.add(txtHeader);
		frm.add(panel2, BorderLayout.NORTH);

		// Application Footer (Complete Output Section)
		panel2 = new JPanel();
		panel2.setLayout(new BorderLayout());
		
		labelCompleteOutput = new JLabel("Complete Output:\n");
		labelCompleteOutput.setHorizontalAlignment(JLabel.CENTER);
		
		txtCompleteOutput = new JTextArea("\n\n\n\n\n\n\n\n");
		txtCompleteOutput.setEditable(false);
		
		panel2.add(labelCompleteOutput, BorderLayout.NORTH);
		panel2.add(txtCompleteOutput, BorderLayout.SOUTH);
		frm.add(panel2, BorderLayout.SOUTH);

		// Instantiate user input private fields
		mailboxValOptions[0] = "Express";
		mailboxValOptions[1] = "Premium";
		
		labelInput = new JLabel("Input:");
		labelInput.setHorizontalAlignment(JLabel.CENTER);
		
		labelCustomerID = new JLabel("Customer ID");
		txtCustomerID = new JTextField(20);
		txtCustomerID.setText(custID);
		
		labelEmailAddress = new JLabel("Email Address");
		txtEmailAddress = new JTextField(20);
		
		mailboxVal = new JComboBox<String>(mailboxValOptions);
		labelMailboxVal = new JLabel("Mailbox Validation Mode");
		txtMailboxVal = new JTextArea("Express: Quickly validates against database of known email addresses.");
		txtMailboxVal.setEditable(false);
		txtMailboxVal.setOpaque(false);
		txtMailboxVal2 = new JTextArea("Premium: Perform real time, live validation of email addresses.");
		txtMailboxVal2.setEditable(false);
		txtMailboxVal2.setOpaque(false);
		
		buttonSubmit = new JButton("Verify Email");
		mouseListener = new Listener();
		buttonSubmit.addMouseListener(mouseListener);

		// Create user inputs Panel (left side)
		panel2 = new JPanel();
		panel = new JPanel();
		panel.setLayout(new GridLayout(10, 2));
		panel.add(labelInput);
		panel.add(labelCustomerID);
		panel.add(txtCustomerID);
		panel.add(labelEmailAddress);
		panel.add(txtEmailAddress);
		panel.add(labelMailboxVal);
		panel.add(txtMailboxVal);
		panel.add(txtMailboxVal2);
		panel.add(mailboxVal);
		panel2.add(buttonSubmit);
		panel.add(panel2, BorderLayout.SOUTH);
		frm.add(panel, BorderLayout.WEST);

		// Instantiate program outputs private fields
		labelOutput = new JLabel("Output:");
		labelOutput.setHorizontalAlignment(JLabel.CENTER);
		
		labelEmailAddress2 = new JLabel("Email Address");
		txtOutEmailAddress = new JTextField();
		txtOutEmailAddress.setEditable(false);
		txtOutEmailAddress.setOpaque(false);
		
		labelMailboxName = new JLabel("Mailbox Name");
		txtMailboxName = new JTextField(1);
		txtMailboxName.setEditable(false);
		txtMailboxName.setOpaque(false);
		
		labelDomainName = new JLabel("Domain Name");
		txtDomainName = new JTextField();
		txtDomainName.setEditable(false);
		txtDomainName.setOpaque(false);
		
		labelTopLevelDomain = new JLabel("Top Level Domain");
		txtTopLevelDomain = new JTextField(20);
		txtTopLevelDomain.setEditable(false);
		txtTopLevelDomain.setOpaque(false);
		
		labelTopLevelDomainName = new JLabel("Top Level Domain Name");
		txtTopLevelDomainName = new JTextField();
		txtTopLevelDomainName.setEditable(false);
		txtTopLevelDomainName.setOpaque(false);
		
		labelResultCodes = new JLabel("Result Codes");
		txtResultCodes = new JTextField(20);
		txtResultCodes.setEditable(false);
		txtResultCodes.setOpaque(false);
		
		txtResultCodeInfo = new JTextArea("Result Code details can be found on our wiki.");
		txtResultCodeInfo.setOpaque(false);
		txtResultCodeInfo.setEditable(false);

		// Create program outputs Panel (right side)
		panel2 = new JPanel();
		panel = new JPanel();
		panel2.setLayout(new GridLayout(20, 2));
		panel2.add(labelOutput);
		panel2.add(labelEmailAddress2);
		panel2.add(txtOutEmailAddress);
		panel2.add(labelMailboxName);
		panel2.add(txtMailboxName);
		panel2.add(labelDomainName);
		panel2.add(txtDomainName);
		panel2.add(labelTopLevelDomain);
		panel2.add(txtTopLevelDomain);
		panel2.add(labelTopLevelDomainName);
		panel2.add(txtTopLevelDomainName);
		panel2.add(labelResultCodes);
		panel2.add(txtResultCodes);
		panel2.add(txtResultCodeInfo);
		panel.add(panel2, BorderLayout.WEST);
		frm.add(panel);

		// Display Frame
		frm.setVisible(true);
	}

	/**
	 * Creates and sends a REST Request
	 */
	public static void submit() {
		String request = null;
		
		// Create REST Request Parameters
		request = createRESTRequest();
		
		// Send REST Request
		try {
			sendRequest(request);
		} catch (IOException e) {
			e.getCause();
		}
	}

	/**
	 * Builds the REST Request parameters string for Melissa Data's Global Email Web Service
	 * @return REST Request parameters string
	 */
	public static String createRESTRequest() {
		String rest = "";
		String transmissionReference;
		String customerID;
		String options;
		String emailAddress;

		// Instantiate request elements
		transmissionReference = "TEST";
		customerID = txtCustomerID.getText();
		options = "MailboxValidationMode:" + mailboxVal.getSelectedItem();
		emailAddress = txtEmailAddress.getText();

		// Build request string
		rest = "?t=" + transmissionReference + "&" + "id=" + customerID + "&" + "opt=" + options + "&" + "email="
				+ emailAddress + "&" + "format=json";

		return rest;
	}

	/**
	 * Establishes a connection to Melissa Data's Global Email Web Service and creates JSONResponse.json, a document
	 * that holds the REST Response in JSON format
	 * @param restRequest REST Request parameters string
	 * @throws IOException
	 */
	public static void sendRequest(String restRequest) throws IOException {
		String httpAddress = "//globalemail.melissadata.net/v3/WEB/GlobalEmail/doGlobalEmail";
		URI uri = null;

		// Attempt to create URI
		try {
			uri = new URI("https", httpAddress + restRequest, null);
		} catch (URISyntaxException e) {
			System.out.println("ERROR: " + e.getCause());
		}

		// Create URL from URI
		url = new URL(uri.toURL().toString());

		// Open a connection
		HttpURLConnection urlConn = (HttpURLConnection) (url.openConnection());

		// Read the JSON response and write it into a file
		BufferedReader in = new BufferedReader(new InputStreamReader(urlConn.getInputStream()));

		String inputLine = "";
		String jsonString = "";

		while ((inputLine = in.readLine()) != null) {
			jsonString = inputLine;

			try {
				FileWriter newFile = new FileWriter("JSONResponse.json");
				newFile.write(jsonString);
				newFile.flush();
				newFile.close();
			} catch (IOException e) {
				System.out.println("ERROR: " + e.getCause());
			}
		}
		outputResults();

	}

	/**
	 * Fills in the java swing application's results panel
	 */
	public static void outputResults() {
		JSONObject jsonResponseObj = null;
		JSONArray records;
		JSONObject recordsObj = null;

		// Create JSON doc
		try {
			jsonResponseObj = (JSONObject) new JSONParser().parse(new FileReader("JSONResponse.json"));
		} catch (IOException | ParseException e) {
			System.out.println("ERROR: " + e.getCause());
		}

		// Create subset of JSON doc containing the pairs in the Records array
		records = ((JSONArray) jsonResponseObj.get("Records"));
		try {
			recordsObj = (JSONObject) records.get(0);

			// Fill in Output Text fields
			txtOutEmailAddress.setText((String) recordsObj.get("EmailAddress"));
			txtMailboxName.setText((String) recordsObj.get("MailboxName"));
			txtDomainName.setText((String) recordsObj.get("DomainName"));
			txtTopLevelDomain.setText((String) recordsObj.get("TopLevelDomain"));
			txtTopLevelDomainName.setText((String) recordsObj.get("TopLevelDomainName"));
			txtResultCodes.setText((String) recordsObj.get("Results"));
			txtCompleteOutput.setText("URL: " + url + "\n\n\n" + jsonResponseObj.toString() + "\n\n\n\n");
			txtCompleteOutput.setLineWrap(true);
		
		} catch (IndexOutOfBoundsException e) {
			System.out.println("ERROR: Invalid Customer ID.");
		}

	}
}