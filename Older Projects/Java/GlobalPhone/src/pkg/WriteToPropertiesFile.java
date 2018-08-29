/**
 * Assign a MAK id to Verified Global Addresses Project
 * WriteToPropertiesFile.java
 * 
 * Program description: writes config.properties file which contains the properties for
 * this project. Currently the only property is table, which defines the SQL Table to be
 * used as input and updated with a mak ID
 */


package pkg;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.OutputStream;
import java.util.Properties;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;



public class WriteToPropertiesFile {

	public static void main (String[] args) {
		Properties prop = new Properties();
		OutputStream output = null;

		try {

			output = new FileOutputStream("config.properties");

			// Universal properties
			prop.setProperty("CustomerID", "F7TgWvUwV8C9T_nJEd7j8N** ");
			prop.setProperty("TransmissionReference", "");
			String options = setOptions();
			prop.setProperty("Options", options);
			
			// GET call specific properties
			prop.setProperty("Phone", "9496076719");
			prop.setProperty("Country", "");
			prop.setProperty("CountryOfOrigin", "");

			// POST call specific properties
			String records = buildRecords();
			prop.setProperty("Records", records);

			// save properties to project root folder
			prop.store(output, null);

		} catch (IOException io) {
			io.printStackTrace();
		} finally {
			if (output != null) {
				try {
					output.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}

		}
		System.out.println("config.properties written.");
	}
	
	/**
	 * Sets the options field for REST calls
	 * @return options for REST calls
	 */
	public static String setOptions() {
		String options = "";
		String callerId = ""; 			// parameters: false or true
		String defaultCallingCode = ""; // parameters: country calling code
		String timeToWait = ""; 		// parameters: time in seconds
		String verifyPhone = ""; 		// parameters: express or premium
		options = options.concat(callerId + "," + defaultCallingCode 
				+ "," + timeToWait + "," + verifyPhone);
		
		return options;
	}
	
	/**
	 * Builds POST call records as a string which contains a JSONArray of 
	 * JSONObject individual records
	 * @return records for POST call
	 */
	public static String buildRecords() {
		String returnRecordsAsString = "";
		JSONArray records = new JSONArray();
		int recordId = 1;

		// User : Input records here for POST Request

		// Example with two records:
		JSONObject record1 = new JSONObject();

		try {
			record1.put("RecordID", "" + recordId++);
			record1.put("PhoneNumber", "7148655613");
			record1.put("Country", "US");
			record1.put("CountryOfOrigin", "US");
		} catch (JSONException e) {
			System.out.println("ERROR JSONException in WriteToPropertiesFile.buildRecords() : "
					+ "Unable to add record to Records Array");
			e.printStackTrace();
			System.exit(0);
		}

		records.put(record1);

		JSONObject record2 = new JSONObject();

		try {
			record2.put("RecordID", "" + recordId++);
			record2.put("PhoneNumber", "9497090639");
			record2.put("Country", "US");
			record2.put("CountryOfOrigin", "US");
		} catch (JSONException e) {
			System.out.println("ERROR JSONException in WriteToPropertiesFile.buildRecords() : "
					+ "Unable to add record to Records Array");
			e.printStackTrace();
			System.exit(0);
		}

		records.put(record2);

		returnRecordsAsString = records.toString();
		return returnRecordsAsString;
	}
}
