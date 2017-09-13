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
            System.Windows.Forms.Label entryIDLabel;
            System.Windows.Forms.Label partNumberLabel1;
            System.Windows.Forms.Label quantityLabel1;
            System.Windows.Forms.Label employeeNameLabel1;
            this.addItemBtn = new System.Windows.Forms.Button();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.partsAddedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTestDataSet = new CBPInventoryMaint.InventoryTestDataSet();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openAllPartsAddedBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.entryIDTextBox = new System.Windows.Forms.TextBox();
            this.updatePartNumberTextBox = new System.Windows.Forms.TextBox();
            this.updateQuantityTextBox = new System.Windows.Forms.TextBox();
            this.partsAddedTableAdapter = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.PartsAddedTableAdapter();
            this.tableAdapterManager = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.TableAdapterManager();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new CBPInventoryMaint.InventoryTestDataSetTableAdapters.EmployeesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.updateEntryBtn = new System.Windows.Forms.Button();
            this.updateEmployeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.updateEntryNUD = new System.Windows.Forms.NumericUpDown();
            this.exitBtn = new System.Windows.Forms.Button();
            partNumberLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            employeeNameLabel = new System.Windows.Forms.Label();
            entryIDLabel = new System.Windows.Forms.Label();
            partNumberLabel1 = new System.Windows.Forms.Label();
            quantityLabel1 = new System.Windows.Forms.Label();
            employeeNameLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsAddedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEntryNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // partNumberLabel
            // 
            partNumberLabel.AutoSize = true;
            partNumberLabel.Location = new System.Drawing.Point(45, 66);
            partNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNumberLabel.Name = "partNumberLabel";
            partNumberLabel.Size = new System.Drawing.Size(102, 20);
            partNumberLabel.TabIndex = 6;
            partNumberLabel.Text = "Part Number:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(45, 106);
            quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(72, 20);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(45, 146);
            employeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(129, 20);
            employeeNameLabel.TabIndex = 10;
            employeeNameLabel.Text = "Employee Name:";
            // 
            // entryIDLabel
            // 
            entryIDLabel.AutoSize = true;
            entryIDLabel.Location = new System.Drawing.Point(45, 392);
            entryIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            entryIDLabel.Name = "entryIDLabel";
            entryIDLabel.Size = new System.Drawing.Size(71, 20);
            entryIDLabel.TabIndex = 14;
            entryIDLabel.Text = "Entry ID:";
            // 
            // partNumberLabel1
            // 
            partNumberLabel1.AutoSize = true;
            partNumberLabel1.Location = new System.Drawing.Point(45, 432);
            partNumberLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            partNumberLabel1.Name = "partNumberLabel1";
            partNumberLabel1.Size = new System.Drawing.Size(102, 20);
            partNumberLabel1.TabIndex = 18;
            partNumberLabel1.Text = "Part Number:";
            // 
            // quantityLabel1
            // 
            quantityLabel1.AutoSize = true;
            quantityLabel1.Location = new System.Drawing.Point(45, 472);
            quantityLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            quantityLabel1.Name = "quantityLabel1";
            quantityLabel1.Size = new System.Drawing.Size(72, 20);
            quantityLabel1.TabIndex = 20;
            quantityLabel1.Text = "Quantity:";
            // 
            // employeeNameLabel1
            // 
            employeeNameLabel1.AutoSize = true;
            employeeNameLabel1.Location = new System.Drawing.Point(45, 512);
            employeeNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            employeeNameLabel1.Name = "employeeNameLabel1";
            employeeNameLabel1.Size = new System.Drawing.Size(129, 20);
            employeeNameLabel1.TabIndex = 24;
            employeeNameLabel1.Text = "Employee Name:";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(254, 197);
            this.addItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(112, 35);
            this.addItemBtn.TabIndex = 4;
            this.addItemBtn.Text = "&Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(184, 62);
            this.partNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.Size = new System.Drawing.Size(180, 26);
            this.partNumberTextBox.TabIndex = 1;
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
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(184, 102);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(180, 26);
            this.quantityTextBox.TabIndex = 2;
            // 
            // employeeNameComboBox
            // 
            this.employeeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeNameComboBox.FormattingEnabled = true;
            this.employeeNameComboBox.ItemHeight = 20;
            this.employeeNameComboBox.Location = new System.Drawing.Point(184, 142);
            this.employeeNameComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.employeeNameComboBox.MaxDropDownItems = 4;
            this.employeeNameComboBox.MaxLength = 1;
            this.employeeNameComboBox.Name = "employeeNameComboBox";
            this.employeeNameComboBox.Size = new System.Drawing.Size(180, 28);
            this.employeeNameComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Part Number:";
            // 
            // openAllPartsAddedBtn
            // 
            this.openAllPartsAddedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAllPartsAddedBtn.Location = new System.Drawing.Point(411, 54);
            this.openAllPartsAddedBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openAllPartsAddedBtn.Name = "openAllPartsAddedBtn";
            this.openAllPartsAddedBtn.Size = new System.Drawing.Size(144, 123);
            this.openAllPartsAddedBtn.TabIndex = 5;
            this.openAllPartsAddedBtn.Text = "&View Parts Added";
            this.openAllPartsAddedBtn.UseVisualStyleBackColor = true;
            this.openAllPartsAddedBtn.Click += new System.EventHandler(this.openAllPartsAddedBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Update Parts Added Via EntryID:";
            // 
            // entryIDTextBox
            // 
            this.entryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "EntryID", true));
            this.entryIDTextBox.Location = new System.Drawing.Point(184, 388);
            this.entryIDTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryIDTextBox.Name = "entryIDTextBox";
            this.entryIDTextBox.ReadOnly = true;
            this.entryIDTextBox.Size = new System.Drawing.Size(180, 26);
            this.entryIDTextBox.TabIndex = 15;
            this.entryIDTextBox.TabStop = false;
            // 
            // updatePartNumberTextBox
            // 
            this.updatePartNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "PartNumber", true));
            this.updatePartNumberTextBox.Location = new System.Drawing.Point(184, 428);
            this.updatePartNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatePartNumberTextBox.Name = "updatePartNumberTextBox";
            this.updatePartNumberTextBox.Size = new System.Drawing.Size(180, 26);
            this.updatePartNumberTextBox.TabIndex = 7;
            // 
            // updateQuantityTextBox
            // 
            this.updateQuantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "Quantity", true));
            this.updateQuantityTextBox.Location = new System.Drawing.Point(184, 468);
            this.updateQuantityTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateQuantityTextBox.Name = "updateQuantityTextBox";
            this.updateQuantityTextBox.Size = new System.Drawing.Size(180, 26);
            this.updateQuantityTextBox.TabIndex = 8;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 331);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "EntryID of Entry to Edit:";
            // 
            // updateEntryBtn
            // 
            this.updateEntryBtn.Location = new System.Drawing.Point(222, 574);
            this.updateEntryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateEntryBtn.Name = "updateEntryBtn";
            this.updateEntryBtn.Size = new System.Drawing.Size(144, 35);
            this.updateEntryBtn.TabIndex = 10;
            this.updateEntryBtn.Text = "&Update Entry";
            this.updateEntryBtn.UseVisualStyleBackColor = true;
            this.updateEntryBtn.Click += new System.EventHandler(this.updateEntryBtn_Click);
            // 
            // updateEmployeeNameComboBox
            // 
            this.updateEmployeeNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partsAddedBindingSource, "EmployeeName", true));
            this.updateEmployeeNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsAddedBindingSource, "PartNumber", true));
            this.updateEmployeeNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateEmployeeNameComboBox.FormattingEnabled = true;
            this.updateEmployeeNameComboBox.Location = new System.Drawing.Point(184, 512);
            this.updateEmployeeNameComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateEmployeeNameComboBox.Name = "updateEmployeeNameComboBox";
            this.updateEmployeeNameComboBox.Size = new System.Drawing.Size(180, 28);
            this.updateEmployeeNameComboBox.TabIndex = 9;
            // 
            // updateEntryNUD
            // 
            this.updateEntryNUD.Location = new System.Drawing.Point(228, 328);
            this.updateEntryNUD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateEntryNUD.Name = "updateEntryNUD";
            this.updateEntryNUD.Size = new System.Drawing.Size(62, 26);
            this.updateEntryNUD.TabIndex = 6;
            this.updateEntryNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updateEntryNUD.ValueChanged += new System.EventHandler(this.updateEntryNUD_ValueChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(576, 633);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 29);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 686);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.updateEntryNUD);
            this.Controls.Add(this.updateEmployeeNameComboBox);
            this.Controls.Add(this.updateEntryBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(entryIDLabel);
            this.Controls.Add(this.entryIDTextBox);
            this.Controls.Add(partNumberLabel1);
            this.Controls.Add(this.updatePartNumberTextBox);
            this.Controls.Add(quantityLabel1);
            this.Controls.Add(this.updateQuantityTextBox);
            this.Controls.Add(employeeNameLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openAllPartsAddedBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(partNumberLabel);
            this.Controls.Add(this.partNumberTextBox);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(employeeNameLabel);
            this.Controls.Add(this.employeeNameComboBox);
            this.Controls.Add(this.addItemBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "CBP Inventory Maintenance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsAddedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryTestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEntryNUD)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openAllPartsAddedBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entryIDTextBox;
        private System.Windows.Forms.TextBox updatePartNumberTextBox;
        private System.Windows.Forms.TextBox updateQuantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateEntryBtn;
        private System.Windows.Forms.ComboBox updateEmployeeNameComboBox;
        private System.Windows.Forms.NumericUpDown updateEntryNUD;
        private System.Windows.Forms.Button exitBtn;
    }
}

