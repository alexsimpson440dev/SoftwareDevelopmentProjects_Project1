namespace CBPInventoryMaint
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label partNumberLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label employeeNameLabel;
            this.addItemBtn = new System.Windows.Forms.Button();
            this.partsAddedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTestDataSet = new CBPInventoryMaint.InventoryTestDataSet();
            this.partsAddedTableAdapter = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.PartsAddedTableAdapter();
            this.tableAdapterManager = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.EmployeesTableAdapter();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameComboBox = new System.Windows.Forms.ComboBox();
            partNumberLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            employeeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsAddedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(164, 140);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // partsAddedBindingSource
            // 
            this.partsAddedBindingSource.DataMember = "PartsAdded";
            this.partsAddedBindingSource.DataSource = this.inventoryTestDataSet;
            // 
            // inventoryTestDataSet
            // 
            this.inventoryTestDataSet.DataSetName = "InventoryTestDataSet";
            this.inventoryTestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsAddedTableAdapter
            // 
            this.partsAddedTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChromeBookPartsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.PartsAddedTableAdapter = this.partsAddedTableAdapter;
            this.tableAdapterManager.UpdateOrder = CBPInventoryMaint.InventoryTestDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.inventoryTestDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Location = new System.Drawing.Point(25, 35);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new System.Drawing.Size(69, 13);
            partNumberLabel.TabIndex = 6;
            partNumberLabel.Text = "Part Number:";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "PartNumber", true));
            this.partNumberTextBox.Location = new System.Drawing.Point(118, 32);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.partNumberTextBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(25, 61);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(118, 58);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 9;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(25, 87);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(87, 13);
            employeeNameLabel.TabIndex = 10;
            employeeNameLabel.Text = "Employee Name:";
            // 
            // employeeNameComboBox
            // 
            this.employeeNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "EmployeeName", true));
            this.employeeNameComboBox.FormattingEnabled = true;
            this.employeeNameComboBox.Location = new System.Drawing.Point(118, 84);
            this.employeeNameComboBox.Name = "employeeNameComboBox";
            this.employeeNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeNameComboBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 207);
            this.Controls.Add(partNumberLabel);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(employeeNameLabel);
            this.Controls.Add(this.employeeNameComboBox);
            this.Controls.Add(this.addItemBtn);
            this.Name = "MainForm";
            this.Text = "CBP Inventory Maintenance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsAddedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InventoryTestDataSet inventoryTestDataSet;
        private System.Windows.Forms.BindingSource partsAddedBindingSource;
        private InventoryTestDataSetTableAdapters.PartsAddedTableAdapter partsAddedTableAdapter;
        private InventoryTestDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private InventoryTestDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox employeeNameComboBox;
    }
}

