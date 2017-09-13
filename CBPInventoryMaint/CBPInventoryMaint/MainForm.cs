using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CBPInventoryMaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //gets connection string for server/database
            using (SqlConnection inv = new SqlConnection("Data Source = DESKTOP-VB076EU; Initial Catalog = InventoryTest; Integrated Security = True"))
            //USE ON DESKTOP!! (SqlConnection inv = new SqlConnection("Data Source=ALEX-PC; Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False"))
            {
                //Opens connection to server/database
                inv.Open();

                //sets and sql command and then sets a reader to read data from the command
                //ideas and help from: https://stackoverflow.com/questions/12900062/c-sharp-fill-combo-box-from-sql-datatable
                SqlCommand getEmployeesTable = new SqlCommand("SELECT * FROM Employees;", inv);
                SqlDataReader sqlReader = getEmployeesTable.ExecuteReader();

                //calls reader to read then specifies to add items to combo box's with params of "EmployeeName"
                while (sqlReader.Read())
                {
                    employeeNameComboBox.Items.Add(sqlReader["EmployeeName"].ToString());
                    updateEmployeeNameComboBox.Items.Add(sqlReader["EmployeeName"].ToString());
                }            
                
                //closes the reader
                sqlReader.Close();

                //Closes Connection to database
                inv.Close();
            }
        }



        private void addItemBtn_Click(object sender, EventArgs e)
        {
            //Asks the user if they want to enter in the information. If Yes, program proceeds
            DialogResult confirm = MessageBox.Show("Are you sure you want to enter " + quantityTextBox.Text.ToString() + ": " + partNumberTextBox.Text.ToString() + "'s into the Database?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                ///gets connection string for server/database
                using (SqlConnection inv = new SqlConnection("Data Source = DESKTOP-VB076EU; Initial Catalog = InventoryTest; Integrated Security = True"))
                //use on desktop using SqlConnection inv = new SqlConnection("Data Source=ALEX-PC; Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False");
                {
                    //Opens connection to server/database
                    inv.Open();

                    try
                    {
                        //variables that get and set data from textbox's and comboboxe's
                        string employeeName = employeeNameComboBox.Text.ToString();
                        string partNumber = partNumberTextBox.Text.ToString();
                        int quantity = Convert.ToInt32(quantityTextBox.Text);

                        //sql command that selects the employeeID
                        string selectID = "SELECT EmployeeID FROM Employees WHERE EmployeeName = '" + employeeName + "'";
                        SqlCommand getEmployeeID = new SqlCommand(selectID, inv);

                        //sets the employeeID to the ID that was grabbed from getEmployeeID command
                        int employeeID = Convert.ToInt32(getEmployeeID.ExecuteScalar());

                        //closes connection
                        inv.Close();


                        //Attempt to insert part from the Google Sheet
                        SqlCommand insertPart =
                            new SqlCommand("insert into PartsAdded(EntryTime, PartNumber, Quantity, EmployeeID, EmployeeName)"
                            + "values(CURRENT_TIMESTAMP," +
                            "@PartNumber," +
                            "@Quantity," +
                            "@EmployeeID," +
                            "@EmployeeName)", inv);

                        //inserts values within sql command
                        insertPart.Parameters.AddWithValue("@PartNumber", partNumber);
                        insertPart.Parameters.AddWithValue("@Quantity", quantity);
                        insertPart.Parameters.AddWithValue("@EmployeeID", employeeID);
                        insertPart.Parameters.AddWithValue("@EmployeeName", employeeName);

                        //verifies user the parameter is working
                        Console.WriteLine("InsParams Working");

                        //opens the inv then executes nonquery then closes connection
                        inv.Open();
                        insertPart.ExecuteNonQuery();
                        inv.Close();
                        MessageBox.Show("Part has been Entered into the Database", "Part Added");

                        partNumberTextBox.Clear();
                        quantityTextBox.Clear();
                        partNumberTextBox.Focus();
                    }

                    catch (FormatException ex)
                    {
                        MessageBox.Show("Invalid data format entered! Please enter in valid data!", "Format Exception");

                        if (partNumberTextBox.Text == "")
                            MessageBox.Show("Please Select an EntryID!", ex.GetType().ToString());
                        if (quantityTextBox.Text.ToString() == "")
                            MessageBox.Show("Please Enter in a Quantity", ex.GetType().ToString());

                    }
                }

            }

            //If the user does not want to enter in the information,
            //the textboxes are cleared and the focus goes back to the part number
            else
            {
                partNumberTextBox.Clear();
                quantityTextBox.Clear();
                partNumberTextBox.Focus();
            }

        }

        //opens a new form that will show all Parts added to the database
        private void openAllPartsAddedBtn_Click(object sender, EventArgs e)
        {
            All_Parts_Added openAllPartsAddedForm = new All_Parts_Added();
            openAllPartsAddedForm.Show();
        }



        //updates entry from the EntryID Number Up Down
        private void updateEntryBtn_Click(object sender, EventArgs e)
        {
            //gets connection to database
            using (SqlConnection inv = new SqlConnection("Data Source = DESKTOP-VB076EU; Initial Catalog = InventoryTest; Integrated Security = True"))
            //USE ON DESKTOP!! using SqlConnection inv = new SqlConnection("Data Source=ALEX-PC;Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False");
            {
                //opens connection
                inv.Open();

                try
                {
                    //variables to get data from textboxes/combobox
                    string updatedPartNumber = updatePartNumberTextBox.Text.ToString();
                    int updatedQuantity = Convert.ToInt32(updateQuantityTextBox.Text);
                    string updatedEmployeeName = updateEmployeeNameComboBox.Text.ToString();
                    int entryID = Convert.ToInt32(entryIDTextBox.Text);

                    //string to assign a select statment to get the employeeid from the employees table using the new EmployeeName
                    string selectID = "SELECT EmployeeID FROM Employees WHERE EmployeeName = '" + updatedEmployeeName + "'";
                    SqlCommand getEmployeeID = new SqlCommand(selectID, inv);

                    //sets the employeeID to the ID that was grabbed from getEmployeeID command
                    int employeeID = Convert.ToInt32(getEmployeeID.ExecuteScalar());

                    //closes Connection
                    inv.Close();

                    //string that assigns an update statement
                    string updateStatement = "UPDATE PartsAdded SET PartNumber = '" + updatedPartNumber + "', " +
                    "Quantity = '" + updatedQuantity + "', " +
                    "EmployeeID = '" + employeeID + "', " +
                    "EmployeeName = '" + updatedEmployeeName + "' " +
                    "WHERE EntryID = " + entryID + ";";

                    //sends the updateStatement string to a command that will execute in the inv connection
                    SqlCommand updatePart =
                    new SqlCommand(updateStatement, inv);

                    //opens connection
                    inv.Open();

                    //executes Update Statement
                    updatePart.ExecuteNonQuery();
                    MessageBox.Show("Updated Part. EntryID: " + entryID.ToString(), "Confirmation");

                    //closes connection
                    inv.Close();
                }
                
                //catches format exceptions
                catch (FormatException ex)
                {
                    if (entryIDTextBox.Text == "")
                        MessageBox.Show("Please Select an EntryID!", ex.GetType().ToString());
                    if (updateQuantityTextBox.Text.ToString() == "")
                        MessageBox.Show("Please Enter in a Quantity", ex.GetType().ToString());
                }
            }
        }

        //Method will run everytime the Value in the EntryNUD is changed
        //Updates fields based on the EntryNUD value using a fill table adapter query
        private void updateEntryNUD_ValueChanged(object sender, EventArgs e)
        {
            //Sets a variable to get the value from the Entry Number Up Down
            int updateEntry = Convert.ToInt32(updateEntryNUD.Value);

            //Fills in Information via a Query into textboxes from the EntryID
            this.partsAddedTableAdapter.FillByEntryID(this.inventoryTestDataSet.PartsAdded, updateEntry);
        }

        //closes application on a dialog result of yes
        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?",
                "Close Application?",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                this.Close();
        }
    }
}
