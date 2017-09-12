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
            using (SqlConnection inv = new SqlConnection("Data Source=ALEX-PC; Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False"))
            {
                //Opens connection to server/database
                inv.Open();
                //sets and sql command and then sets a reader to read data from the command
                //ideas and help from: https://stackoverflow.com/questions/12900062/c-sharp-fill-combo-box-from-sql-datatable
                SqlCommand getEmployeesTable = new SqlCommand("SELECT * FROM Employees;", inv);
                SqlDataReader sqlReader = getEmployeesTable.ExecuteReader();
                //calls reader to read then specifies to add items to combo box with params of "EmployeeName"
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
            SqlConnection inv = new SqlConnection("Data Source=ALEX-PC; Initial Catalog=InventoryTest;Integrated Security=True;Pooling=False");
                {
                    //Opens connection to server/database
                    inv.Open();

                    try
                    {
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

                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid data format entered! Please enter in valid data!", "Format Exception");
                    }
                }

            }

            //If the user does not want to enter in the information, the textboxes are cleared and the focus goes back to the part number
            else
            {
                partNumberTextBox.Clear();
                quantityTextBox.Clear();
                partNumberTextBox.Focus();
            }

        }

        private void openAllPartsAddedBtn_Click(object sender, EventArgs e)
        {
            //opens a new form that will show all Parts added to the database
            All_Parts_Added openAllPartsAddedForm = new All_Parts_Added();
            openAllPartsAddedForm.Show();
        }

        private void updateEntryBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateEntryNUD_ValueChanged(object sender, EventArgs e)
        {
            //Sets a variable to get the value from the Entry Number Up Down
            //Method will run everytime the Value is changed
            int updateEntry = Convert.ToInt32(updateEntryNUD.Value);

            //Fills in Information via a Query into textboxes from the EntryID
            this.partsAddedTableAdapter.FillByEntryID(this.inventoryTestDataSet.PartsAdded, updateEntry);
        }
    }
}
