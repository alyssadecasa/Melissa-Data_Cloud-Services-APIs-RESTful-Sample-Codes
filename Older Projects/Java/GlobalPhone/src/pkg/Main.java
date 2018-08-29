
/**
 * GlobalPhone JSON REST Java Sample Code Project
 * Main.java
 * 
 * Program description: java sample code for Melissa Data's Global Phone Web Service.
 * This program uses the command line to interact with the User, and the User must modify
 * the code itself in order to test specific phone numbers. The two tests available are the
 * REST GET call and the REST POST call.
 * 
 * @author Alyssa House
 */

package pkg;

import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URISyntaxException;
import java.net.URL;
import java.util.Properties;
import java.util.Scanner;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.entity.ContentType;
import org.apache.http.entity.StringEntity;
import org.apache.http.impl.client.CloseableHttpClient;
import org.apache.http.impl.client.HttpClientBuilder;
import org.apache.http.util.EntityUtils;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

public class Main {

	public static Properties properties;
	
	public static void main (String[] args) {
		Scanner scanner = new Scanner(System.in);
		String userChoice = "";
		
		// Initialize properties
		properties = new Properties();
		try {
			properties.load(new FileInputStream("config.properties"));
		} catch (IOException e) {
			System.out.println("ERROR IOException in main() : "
					+ "Unable to load config.properties.");
			e.printStackTrace();
			System.exit(0);
		}
		
		System.out.println("Welcome to the Melissa Data Global Phone Web Service. Verify phone numbers\n"
				+ "from over 230 countries and territories, append useful geographic information, and\n"
				+ "perform, premium real-time checks to distinguish live numbers and phone types.\n");
		System.out.println("If you have not already done so, please set the properties in WriteToPropertiesFile.java.\n"
				+ "Then, type in the call you would like to make: get or post.");

		userChoice = scanner.nextLine();
		
		if (userChoice.equalsIgnoreCase("get")) {
			System.out.println("Testing REST GET Request.");
			sendREST_GETRequest();
			System.out.println("Test successful. Results are located in the REST-GETResponse.json file.");
		} else if (userChoice.equalsIgnoreCase("post")) {
			System.out.println("Testing REST POST Request.");
			sendREST_POSTRequest();
			System.out.println("Test successful. Results are located in the REST-POSTResponse.json file");
		} else {
			System.out.println("Error : Incorrect input. Please type in \"get\" to test the REST GET call or\n"
					+ "type in \"post\" to test the REST POST call. Goodbye.");
			System.exit(0);
		}
		scanner.close();
	}
	
	/**
	 * Sends a REST GET request to the Global Phone Web Service
	 */
	public static void sendREST_GETRequest() {
		String httpAddress = "//globalphone.melissadata.net/V4/WEB/GlobalPhone/doGlobalPhone";
		String restGetRequest = "";
		
		// build REST GET Request
		restGetRequest = buildREST_GETRequest();
		
		// Attempt to create URI
		URI uri = null;
		try {
			uri = new URI("https", httpAddress + restGetRequest, null);
		} catch (URISyntaxException e) {
			System.out.println("ERROR URISyntaxException in sendREST_GETRequest() : "
					+ "Unable to create valid URI.");
			e.printStackTrace();
			System.exit(0);
		}

		// Create URL from URI
		URL url = null;
		try {
			url = new URL(uri.toURL().toString());
		} catch (MalformedURLException e) {
			System.out.println("ERROR MalformedURLException in sendREST_GETRequest() : "
					+ "Unable to create valid URL.");
			e.printStackTrace();
			System.exit(0);
		}

		// Loop until either request is sent and response received or tries exceed 5
		boolean requestRetrieved = false;
		int retry = 0;
		HttpURLConnection urlConn = null;
		BufferedReader in = null;
		FileWriter restGetFile = null;
		
		do {
			try {
				// Open a connection
				urlConn = (HttpURLConnection) (url.openConnection());
				urlConn.connect();

				// Read the JSON response and write it into a file
				in = new BufferedReader(new InputStreamReader(urlConn.getInputStream()));

				String inputLine = "";
				String jsonString = "";
				restGetFile = new FileWriter("REST-GETResponse.json");

				while ((inputLine = in.readLine()) != null) {
					jsonString = jsonString.concat(inputLine + "\n");
				}
				restGetFile.write(jsonString);
				restGetFile.flush();	
				requestRetrieved = true;
			} catch (IOException e) {
				//do nothing
			} finally {
				try {
					if (restGetFile != null) {
						restGetFile.close();
					}
					
					if (in != null) {
						in.close();
					}
				} catch (IOException e) {
					// do nothing
				}
				urlConn.disconnect();
			}
		} while (!requestRetrieved && retry < 5);
		
		if (retry >= 5) {
			System.out.println("ERROR IOException in sendREST_GETRequest() : "
					+ "Could not send GET request within five tries."); 
			System.exit(0);
		}
	}

	/**
	 * Helper method for sendREST_GETRequest(). Builds the REST line.
	 * @return REST line
	 */
	public static String buildREST_GETRequest() {
		String rest = "";

		// Verify minimum requirements have been met to send GET request
		if (properties.get("CustomerID").equals("") || properties.getProperty("Phone").equals("")) {
			System.out.println("ERROR Minimum requirements for GET Request not met.\n\t"
					+ "Please input GET Request fields in WriteToPropertiesFile.java.");
			System.exit(0);
		}

		rest = "?t=" + properties.getProperty("TransmissionReference") 
		+ "&id="	 + properties.getProperty("CustomerID")  
		+ "&opt="	 + properties.getProperty("Options")  
		+ "&phone="	 + properties.getProperty("Phone")  
		+ "&ctry=" 	 + properties.getProperty("Country") 
		+ "&ctryOrg="+ properties.getProperty("CountryOfOrigin");

		return rest;
	}
	
	/**
	 * Sends a REST POST request to the Global Phone Web Service
	 */
	public static void sendREST_POSTRequest() {
		CloseableHttpClient httpClient = HttpClientBuilder.create().build();
		HttpPost post = new HttpPost("http://globalphone.melissadata.net/V4/WEB/GlobalPhone/doGlobalPhone");
		
		// Build POST request
		String request = buildREST_POSTRequest();
		StringEntity entity = new StringEntity(request, ContentType.APPLICATION_JSON);
		post.addHeader("Content-Type", "application/json");
		post.setEntity(entity);
		
		// Execute POST Request
		HttpResponse response = null;
		try {
			response = httpClient.execute(post);
			
			if (response.getStatusLine().getStatusCode() != 200) {
				System.out.println("ERROR in sendREST_POSTRequest() : "
						+ "Returned response code is not 200 (Success) : " + response.getStatusLine().getStatusCode());
			}
			
			// Build REST POST JSON response file
			buildREST_POSTResponseFile(response);
			
		} catch (IOException e) {
			System.out.println("ERROR IOException in sendREST_POSTRequest() :"
					+ " Unable to execute post method.");
			 e.printStackTrace();
			 System.exit(0);
		} finally {
			post.releaseConnection();
		}
	}

	/**
	 * Helper method for sendREST_POSTRequest(). Builds the JSON Batch Request.
	 * @return string formatted JSON Batch Request
	 */
	public static String buildREST_POSTRequest() {
		JSONObject request = new JSONObject();
		String jsonString = "";

		try {
			request.put("TransmissionReference", properties.getProperty("TransmissionReference"));
			request.put("CustomerID", properties.getProperty("CustomerID"));
			request.put("Options", properties.getProperty("Options"));
			JSONArray records = new JSONArray(properties.getProperty("Records"));
			request.put("Records", records);
			if (request.get("CustomerID").equals("") || request.get("Records").equals("")) {
			System.out.println("ERROR Minimum requirements for POST Request not met.\n\t" 
					+ "Please input POST Request fields under in WriteToPropertiesFile.java and\n\t"
					+ "input POST records under \"User : Input records here for POST Request\" in the\n\t"
					+ "buildRecordsJSONArray() method."); 
					System.exit(0);
			}
		} catch (JSONException e) {
			System.out.println("ERROR JSONException in buildREST_POSTRequest() : "
					+ "Unable to build POST Request.");
			e.printStackTrace();
			System.exit(0);
		}
		jsonString =  request.toString();
		return jsonString;
	}
	
	/**
	 * Helper method for sendREST_POSTRequest(). Builds the JSON output file for
	 * the POST response
	 * @param response
	 */
	public static void buildREST_POSTResponseFile(HttpResponse response) {
		HttpEntity entity = response.getEntity();
		String responseString = "";
		
		//Convert POST response into string format
		try {
			responseString = EntityUtils.toString(entity, "UTF-8");
		} catch (org.apache.http.ParseException | IOException e) {
			System.out.println("ERROR org.apache.http.ParseException in buildREST_POSTResponseFile() : "
					+ "Unable to convert POST response into string format.");
			e.printStackTrace();
			System.exit(0);
		} 
				
		FileWriter restPostFile = null;
		try {
			restPostFile = new FileWriter("REST-POSTResponse.json");
			restPostFile.write(responseString);
			restPostFile.flush();
			restPostFile.close();
		} catch (IOException e) {
			System.out.println("ERROR IOException in buildREST_POSTResponseFile() : "
					+ "Unable to write to REST-POSTResponse.json.");
		}
	}
	
}
