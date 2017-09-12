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
    //Allows user to view information from the parts added table
    public partial class All_Parts_Added : Form
    {
        public All_Parts_Added()
        {
            InitializeComponent();
        }

        private void partsAddedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsAddedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inventoryTestDataSet);

        }

        private void All_Parts_Added_Load(object sender, EventArgs e)
        {
            //Trys to fill in information from database, if it fails, the exception will be caught and information will be displayed.
            try
            {
                // TODO: This line of code loads data into the 'inventoryTestDataSet.PartsAdded' table. You can move, or remove it, as needed.
                this.partsAddedTableAdapter.Fill(this.inventoryTestDataSet.PartsAdded);
            }

            //catch statement to catch error and display information
            catch (SqlException ex)
            {
                MessageBox.Show("Error Loading Database Information. Please check connection to database! Error Number: " + ex.Number +
                    ". Error Message: " + ex.Message, ex.GetType().ToString());
            }

        }
    }
}
