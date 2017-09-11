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

        private void partsAddedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsAddedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryTestDataSet);

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
                }
                
                //closes the reader
                sqlReader.Close();
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Data Entered into Database");

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
    }
}
