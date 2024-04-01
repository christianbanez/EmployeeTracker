namespace EmployeeTracker
{
    partial class AddTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelectedID = new System.Windows.Forms.TextBox();
            this.lblSelectedName = new System.Windows.Forms.TextBox();
            this.selectedName = new System.Windows.Forms.Label();
            this.dataGridViewSchedules = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTimeOut = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lStartD = new System.Windows.Forms.Label();
            this.ltskDesc = new System.Windows.Forms.Label();
            this.lbtskTitle = new System.Windows.Forms.Label();
            this.dateTimePickerTimeIn = new System.Windows.Forms.DateTimePicker();
            this.cmbxAssign = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSelectedID);
            this.panel1.Controls.Add(this.lblSelectedName);
            this.panel1.Controls.Add(this.selectedName);
            this.panel1.Controls.Add(this.dataGridViewSchedules);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerTimeOut);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lStartD);
            this.panel1.Controls.Add(this.ltskDesc);
            this.panel1.Controls.Add(this.lbtskTitle);
            this.panel1.Controls.Add(this.dateTimePickerTimeIn);
            this.panel1.Controls.Add(this.cmbxAssign);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 788);
            this.panel1.TabIndex = 0;
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.Location = new System.Drawing.Point(196, 52);
            this.lblSelectedID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(677, 22);
            this.lblSelectedID.TabIndex = 22;
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.Location = new System.Drawing.Point(196, 12);
            this.lblSelectedName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(677, 22);
            this.lblSelectedName.TabIndex = 21;
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedName.Location = new System.Drawing.Point(7, 12);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(172, 25);
            this.selectedName.TabIndex = 20;
            this.selectedName.Text = "Employee Name : ";
            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.AllowUserToAddRows = false;
            this.dataGridViewSchedules.AllowUserToDeleteRows = false;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Location = new System.Drawing.Point(12, 288);
            this.dataGridViewSchedules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.ReadOnly = true;
            this.dataGridViewSchedules.RowHeadersWidth = 51;
            this.dataGridViewSchedules.Size = new System.Drawing.Size(877, 185);
            this.dataGridViewSchedules.TabIndex = 19;
            this.dataGridViewSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employee ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerTimeOut
            // 
            this.dateTimePickerTimeOut.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeOut.Location = new System.Drawing.Point(460, 206);
            this.dateTimePickerTimeOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerTimeOut.Name = "dateTimePickerTimeOut";
            this.dateTimePickerTimeOut.Size = new System.Drawing.Size(429, 30);
            this.dateTimePickerTimeOut.TabIndex = 14;
            this.dateTimePickerTimeOut.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(747, 732);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 37);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(585, 732);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lStartD
            // 
            this.lStartD.AutoSize = true;
            this.lStartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartD.Location = new System.Drawing.Point(7, 176);
            this.lStartD.Name = "lStartD";
            this.lStartD.Size = new System.Drawing.Size(105, 25);
            this.lStartD.TabIndex = 8;
            this.lStartD.Text = "Start Date:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(7, 260);
            this.ltskDesc.Name = "ltskDesc";
            this.ltskDesc.Size = new System.Drawing.Size(115, 25);
            this.ltskDesc.TabIndex = 8;
            this.ltskDesc.Text = "Time Logs :";
            // 
            // lbtskTitle
            // 
            this.lbtskTitle.AutoSize = true;
            this.lbtskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtskTitle.Location = new System.Drawing.Point(1, 87);
            this.lbtskTitle.Name = "lbtskTitle";
            this.lbtskTitle.Size = new System.Drawing.Size(104, 25);
            this.lbtskTitle.TabIndex = 6;
            this.lbtskTitle.Text = "Task Title:";
            // 
            // dateTimePickerTimeIn
            // 
            this.dateTimePickerTimeIn.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeIn.Location = new System.Drawing.Point(7, 204);
            this.dateTimePickerTimeIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerTimeIn.Name = "dateTimePickerTimeIn";
            this.dateTimePickerTimeIn.Size = new System.Drawing.Size(431, 30);
            this.dateTimePickerTimeIn.TabIndex = 4;
            // 
            // cmbxAssign
            // 
            this.cmbxAssign.DataSource = this.employeeBindingSource;
            this.cmbxAssign.DisplayMember = "fName";
            this.cmbxAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAssign.FormattingEnabled = true;
            this.cmbxAssign.Location = new System.Drawing.Point(7, 116);
            this.cmbxAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxAssign.Name = "cmbxAssign";
            this.cmbxAssign.Size = new System.Drawing.Size(867, 33);
            this.cmbxAssign.TabIndex = 3;
            this.cmbxAssign.SelectedIndexChanged += new System.EventHandler(this.cmbxAssign_SelectedIndexChanged);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dbtkDataSet;
            // 
            // dbtkDataSet
            // 
            this.dbtkDataSet.DataSetName = "dbtkDataSet";
            this.dbtkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 815);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddTask";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbxAssign;
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbtkDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeIn;
        private System.Windows.Forms.Label lbtskTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lStartD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ltskDesc;
        private System.Windows.Forms.DataGridView dataGridViewSchedules;
        private System.Windows.Forms.TextBox lblSelectedName;
        private System.Windows.Forms.Label selectedName;
        private System.Windows.Forms.TextBox lblSelectedID;
    }
}