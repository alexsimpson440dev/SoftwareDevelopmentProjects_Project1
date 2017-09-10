using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.partsAddedTableAdapter.Fill(this.inventoryTestDataSet.PartsAdded);
        }
    }
}
