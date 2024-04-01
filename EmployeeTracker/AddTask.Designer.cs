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
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Controls.Add(this.txtTaskName);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 532);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "ddd, MMM/dd/yyyy, hh:mm tt";
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(365, 129);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(316, 30);
            this.dateTimePickerEndDate.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(567, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Color:";
            // 
            // cmbxColor
            // 
            this.cmbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxColor.FormattingEnabled = true;
            this.cmbxColor.Location = new System.Drawing.Point(571, 65);
            this.cmbxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxColor.Name = "cmbxColor";
            this.cmbxColor.Size = new System.Drawing.Size(139, 33);
            this.cmbxColor.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(588, 470);
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
            this.btnAdd.Location = new System.Drawing.Point(427, 470);
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
            this.lStartD.Location = new System.Drawing.Point(12, 102);
            this.lStartD.Name = "lStartD";
            this.lStartD.Size = new System.Drawing.Size(105, 25);
            this.lStartD.TabIndex = 8;
            this.lStartD.Text = "Start Date:";
            // 
            // lProj
            // 
            this.lProj.AutoSize = true;
            this.lProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProj.Location = new System.Drawing.Point(387, 384);
            this.lProj.Name = "lProj";
            this.lProj.Size = new System.Drawing.Size(78, 25);
            this.lProj.TabIndex = 9;
            this.lProj.Text = "Project:";
            // 
            // lAssign
            // 
            this.lAssign.AutoSize = true;
            this.lAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAssign.Location = new System.Drawing.Point(12, 384);
            this.lAssign.Name = "lAssign";
            this.lAssign.Size = new System.Drawing.Size(129, 25);
            this.lAssign.TabIndex = 7;
            this.lAssign.Text = "Assigned To:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(12, 167);
            this.ltskDesc.Name = "ltskDesc";
            this.ltskDesc.Size = new System.Drawing.Size(164, 25);
            this.ltskDesc.TabIndex = 8;
            this.ltskDesc.Text = "Task Description:";
            // 
            // lbtskTitle
            // 
            this.lbtskTitle.AutoSize = true;
            this.lbtskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtskTitle.Location = new System.Drawing.Point(12, 37);
            this.lbtskTitle.Name = "lbtskTitle";
            this.lbtskTitle.Size = new System.Drawing.Size(104, 25);
            this.lbtskTitle.TabIndex = 6;
            this.lbtskTitle.Text = "Task Title:";
            // 
            // cmbxProj
            // 
            this.cmbxProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxProj.FormattingEnabled = true;
            this.cmbxProj.Location = new System.Drawing.Point(392, 412);
            this.cmbxProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxProj.Name = "cmbxProj";
            this.cmbxProj.Size = new System.Drawing.Size(293, 33);
            this.cmbxProj.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "ddd, MMM/dd/yyyy, hh:mm tt";
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(17, 129);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(316, 30);
            this.dateTimePickerStartDate.TabIndex = 4;
            // 
            // cmbxAssign
            // 
            this.cmbxAssign.DataSource = this.employeeBindingSource;
            this.cmbxAssign.DisplayMember = "fName";
            this.cmbxAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAssign.FormattingEnabled = true;
            this.cmbxAssign.Location = new System.Drawing.Point(17, 412);
            this.cmbxAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxAssign.Name = "cmbxAssign";
            this.cmbxAssign.Size = new System.Drawing.Size(316, 33);
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
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(17, 196);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(703, 181);
            this.txtTaskDesc.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(17, 65);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(541, 30);
            this.txtTaskName.TabIndex = 0;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 556);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.TextBox txtTaskName;
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
    }
}