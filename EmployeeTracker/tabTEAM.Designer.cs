namespace EmployeeTracker
{
    partial class tabTEAM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayData = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.dbtkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet1 = new EmployeeTracker.dbtkDataSet1();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSet1TableAdapters.EmployeeTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accDateEndedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.displayData);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 541);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // displayData
            // 
            this.displayData.AllowUserToAddRows = false;
            this.displayData.AllowUserToDeleteRows = false;
            this.displayData.AllowUserToResizeColumns = false;
            this.displayData.AllowUserToResizeRows = false;
            this.displayData.AutoGenerateColumns = false;
            this.displayData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.displayData.ColumnHeadersHeight = 34;
            this.displayData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.fNameDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.contactNumDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.accDateCreatedDataGridViewTextBoxColumn,
            this.accDateEndedDataGridViewTextBoxColumn});
            this.displayData.DataSource = this.employeeBindingSource;
            this.displayData.Location = new System.Drawing.Point(16, 67);
            this.displayData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayData.Name = "displayData";
            this.displayData.ReadOnly = true;
            this.displayData.RowHeadersWidth = 62;
            this.displayData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.displayData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.displayData.Size = new System.Drawing.Size(647, 453);
            this.displayData.TabIndex = 11;
            this.displayData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayData_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(385, 22);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 25);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(262, 22);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(517, 25);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(146, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.Text = "Search...";
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(139, 22);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 25);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 22);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dbtkDataSet
            // 
            this.dbtkDataSet.DataSetName = "dbtkDataSet";
            this.dbtkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbtkDataSetBindingSource
            // 
            this.dbtkDataSetBindingSource.DataSource = this.dbtkDataSet;
            this.dbtkDataSetBindingSource.Position = 0;
            // 
            // dbtkDataSet1
            // 
            this.dbtkDataSet1.DataSetName = "dbtkDataSet1";
            this.dbtkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dbtkDataSet1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 111;
            // 
            // fNameDataGridViewTextBoxColumn
            // 
            this.fNameDataGridViewTextBoxColumn.DataPropertyName = "fName";
            this.fNameDataGridViewTextBoxColumn.HeaderText = "fName";
            this.fNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fNameDataGridViewTextBoxColumn.Name = "fNameDataGridViewTextBoxColumn";
            this.fNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // lNameDataGridViewTextBoxColumn
            // 
            this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
            this.lNameDataGridViewTextBoxColumn.HeaderText = "lName";
            this.lNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
            this.lNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNameDataGridViewTextBoxColumn.Width = 76;
            // 
            // contactNumDataGridViewTextBoxColumn
            // 
            this.contactNumDataGridViewTextBoxColumn.DataPropertyName = "contactNum";
            this.contactNumDataGridViewTextBoxColumn.HeaderText = "contactNum";
            this.contactNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactNumDataGridViewTextBoxColumn.Name = "contactNumDataGridViewTextBoxColumn";
            this.contactNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactNumDataGridViewTextBoxColumn.Width = 107;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 60;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 69;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.Width = 48;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            this.roleDataGridViewTextBoxColumn.Width = 59;
            // 
            // accDateCreatedDataGridViewTextBoxColumn
            // 
            this.accDateCreatedDataGridViewTextBoxColumn.DataPropertyName = "accDateCreated";
            this.accDateCreatedDataGridViewTextBoxColumn.HeaderText = "accDateCreated";
            this.accDateCreatedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accDateCreatedDataGridViewTextBoxColumn.Name = "accDateCreatedDataGridViewTextBoxColumn";
            this.accDateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.accDateCreatedDataGridViewTextBoxColumn.Width = 135;
            // 
            // accDateEndedDataGridViewTextBoxColumn
            // 
            this.accDateEndedDataGridViewTextBoxColumn.DataPropertyName = "accDateEnded";
            this.accDateEndedDataGridViewTextBoxColumn.HeaderText = "accDateEnded";
            this.accDateEndedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accDateEndedDataGridViewTextBoxColumn.Name = "accDateEndedDataGridViewTextBoxColumn";
            this.accDateEndedDataGridViewTextBoxColumn.ReadOnly = true;
            this.accDateEndedDataGridViewTextBoxColumn.Width = 127;
            // 
            // tabTEAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "tabTEAM";
            this.Size = new System.Drawing.Size(692, 557);
            this.Load += new System.EventHandler(this.tabTEAM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView displayData;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accDateEndedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbtkDataSet1 dbtkDataSet1;
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource dbtkDataSetBindingSource;
        private dbtkDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}
