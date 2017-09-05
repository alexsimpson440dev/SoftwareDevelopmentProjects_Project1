﻿using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SheetsQuickstart
{
    class Program
    {
        // ------------Google Provided Code W/ Minor Changes. Such as spreadSheetID, Range, and comment containing sheets link
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Drive };
        static string ApplicationName = "Sheets API Test";

        static void Main(string[] args)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                //credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = "14g46VAUsxqAkevmNDKdrc0c5R3L1cOfN6PsBYz_2zf0";
            String range = "A2:D";
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/14g46VAUsxqAkevmNDKdrc0c5R3L1cOfN6PsBYz_2zf0/edit
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    // Print columns A and D, which correspond to indices 0 and 3.
                    //Console.WriteLine("{0},{1},{2},{3}", row[0], row [1], row[2], row[3]);
                    //TODO: Send data to sqlServer Database "InventoryTest"
                    SqlConnection inv = new SqlConnection("Data Source=ALEX-PC;Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False");
                    {
                        SqlCommand insertPart =
                            new SqlCommand("insert into PartsAdded(EntryTime, PartNumber, Quantity, EmployeeID, EmployeeName)"
                            + "values(CURRENT_TIMESTAMP," +
                            "@PartNumber," +
                            "@Quantity," +
                            "(SELECT EmployeeID FROM Employees WHERE EmployeeName = '" + row[3] + "')," +
                            "@EmployeeName)", inv);

                        insertPart.Parameters.AddWithValue("@PartNumber", row[1]);
                        insertPart.Parameters.AddWithValue("@Quantity", row[2]);
                        //insertPart.Parameters.AddWithValue("@EmployeeID", "(select EmployeeID from Employees where EmployeeName = '" + row[3] + "')");
                        insertPart.Parameters.AddWithValue("@EmployeeName", row[3]);

                        inv.Open();
                        insertPart.ExecuteNonQuery();
                        inv.Close();


                    }
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();


        }
    }
}
