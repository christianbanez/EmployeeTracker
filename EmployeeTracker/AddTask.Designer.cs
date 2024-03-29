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
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbxColor = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lStartD = new System.Windows.Forms.Label();
            this.lProj = new System.Windows.Forms.Label();
            this.lAssign = new System.Windows.Forms.Label();
            this.ltskDesc = new System.Windows.Forms.Label();
            this.lbtskTitle = new System.Windows.Forms.Label();
            this.cmbxProj = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbxAssign = new System.Windows.Forms.ComboBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.EmployeeTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerEndDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbxColor);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lStartD);
            this.panel1.Controls.Add(this.lProj);
            this.panel1.Controls.Add(this.lAssign);
            this.panel1.Controls.Add(this.ltskDesc);
            this.panel1.Controls.Add(this.lbtskTitle);
            this.panel1.Controls.Add(this.cmbxProj);
            this.panel1.Controls.Add(this.dateTimePickerStartDate);
            this.panel1.Controls.Add(this.cmbxAssign);
            this.panel1.Controls.Add(this.txtTaskDesc);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 432);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "ddd, MMM/dd/yyyy, hh:mm tt";
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(274, 105);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(238, 26);
            this.dateTimePickerEndDate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Color:";
            // 
            // cmbxColor
            // 
            this.cmbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxColor.FormattingEnabled = true;
            this.cmbxColor.Location = new System.Drawing.Point(428, 53);
            this.cmbxColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxColor.Name = "cmbxColor";
            this.cmbxColor.Size = new System.Drawing.Size(105, 28);
            this.cmbxColor.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 382);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(320, 382);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lStartD
            // 
            this.lStartD.AutoSize = true;
            this.lStartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartD.Location = new System.Drawing.Point(9, 83);
            this.lStartD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lStartD.Name = "lStartD";
            this.lStartD.Size = new System.Drawing.Size(87, 20);
            this.lStartD.TabIndex = 8;
            this.lStartD.Text = "Start Date:";
            // 
            // lProj
            // 
            this.lProj.AutoSize = true;
            this.lProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProj.Location = new System.Drawing.Point(290, 312);
            this.lProj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProj.Name = "lProj";
            this.lProj.Size = new System.Drawing.Size(62, 20);
            this.lProj.TabIndex = 9;
            this.lProj.Text = "Project:";
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssign.Location = new System.Drawing.Point(9, 312);
            this.lAssign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(101, 20);
            this.lAssign.TabIndex = 7;
            this.lAssign.Text = "Assigned To:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(9, 136);
            this.ltskDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ltskDesc.Name = "ltskDesc";
            this.ltskDesc.Size = new System.Drawing.Size(131, 20);
            this.ltskDesc.TabIndex = 8;
            this.ltskDesc.Text = "Task Description:";
            // 
            // lbtskTitle
            // 
            this.lbtskTitle.AutoSize = true;
            this.lbtskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtskTitle.Location = new System.Drawing.Point(9, 30);
            this.lbtskTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtskTitle.Name = "lbtskTitle";
            this.lbtskTitle.Size = new System.Drawing.Size(80, 20);
            this.lbtskTitle.TabIndex = 6;
            this.lbtskTitle.Text = "Task Title:";
            // 
            // cmbxProj
            // 
            this.cmbxProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxProj.FormattingEnabled = true;
            this.cmbxProj.Location = new System.Drawing.Point(294, 335);
            this.cmbxProj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxProj.Name = "cmbxProj";
            this.cmbxProj.Size = new System.Drawing.Size(221, 28);
            this.cmbxProj.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "ddd, MMM/dd/yyyy, hh:mm tt";
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(13, 105);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(238, 26);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // cmbxAssign
            // 
            this.cmbxAssign.DataSource = this.employeeBindingSource;
            this.cmbxAssign.DisplayMember = "fName";
            this.cmbxAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAssign.FormattingEnabled = true;
            this.cmbxAssign.Location = new System.Drawing.Point(13, 335);
            this.cmbxAssign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxAssign.Name = "cmbxAssign";
            this.cmbxAssign.Size = new System.Drawing.Size(238, 28);
            this.cmbxAssign.TabIndex = 3;
            this.cmbxAssign.ValueMember = "EmployeeID";
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
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(13, 159);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(528, 148);
            this.txtTaskDesc.TabIndex = 1;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "System.Data.DataViewManagerListItemTypeDescriptor";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 452);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddTask";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.ComboBox cmbxAssign;
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbtkDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox cmbxProj;
        private System.Windows.Forms.Label lbtskTitle;
        private System.Windows.Forms.Label ltskDesc;
        private System.Windows.Forms.Label lAssign;
        private System.Windows.Forms.Label lProj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lStartD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbxColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}