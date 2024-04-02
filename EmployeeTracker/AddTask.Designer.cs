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
            this.pnlAssign = new System.Windows.Forms.Panel();
            this.btnSvCal = new System.Windows.Forms.Button();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pickDate2 = new System.Windows.Forms.DateTimePicker();
            this.pickDate1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxEmp = new System.Windows.Forms.ComboBox();
            this.cmbxTask = new System.Windows.Forms.ComboBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAssEmp = new System.Windows.Forms.Label();
            this.lbAssTask = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pickTimeOut = new System.Windows.Forms.DateTimePicker();
            this.pickTimeIn = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lProj = new System.Windows.Forms.Label();
            this.ltskDesc = new System.Windows.Forms.Label();
            this.lbtskTitle = new System.Windows.Forms.Label();
            this.cmbxProj = new System.Windows.Forms.ComboBox();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.EmployeeTableAdapter();
            this.panel1.SuspendLayout();
            this.pnlAssign.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlAssign);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lProj);
            this.panel1.Controls.Add(this.ltskDesc);
            this.panel1.Controls.Add(this.lbtskTitle);
            this.panel1.Controls.Add(this.cmbxProj);
            this.panel1.Controls.Add(this.txtTaskDesc);
            this.panel1.Controls.Add(this.txtTaskName);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 379);
            this.panel1.TabIndex = 0;
            // 
            // pnlAssign
            // 
            this.pnlAssign.Controls.Add(this.btnSvCal);
            this.pnlAssign.Controls.Add(this.chkTime);
            this.pnlAssign.Controls.Add(this.pnlDate);
            this.pnlAssign.Controls.Add(this.label2);
            this.pnlAssign.Controls.Add(this.cmbxEmp);
            this.pnlAssign.Controls.Add(this.cmbxTask);
            this.pnlAssign.Controls.Add(this.btnCancel2);
            this.pnlAssign.Controls.Add(this.btnAssign);
            this.pnlAssign.Controls.Add(this.label1);
            this.pnlAssign.Controls.Add(this.lbAssEmp);
            this.pnlAssign.Controls.Add(this.lbAssTask);
            this.pnlAssign.Controls.Add(this.comboBox1);
            this.pnlAssign.Controls.Add(this.pnlTime);
            this.pnlAssign.Location = new System.Drawing.Point(0, 0);
            this.pnlAssign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(434, 379);
            this.pnlAssign.TabIndex = 12;
            // 
            // btnSvCal
            // 
            this.btnSvCal.Location = new System.Drawing.Point(216, 340);
            this.btnSvCal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSvCal.Name = "btnSvCal";
            this.btnSvCal.Size = new System.Drawing.Size(96, 30);
            this.btnSvCal.TabIndex = 28;
            this.btnSvCal.Text = "Save";
            this.btnSvCal.UseVisualStyleBackColor = true;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime.Location = new System.Drawing.Point(13, 256);
            this.chkTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(99, 24);
            this.chkTime.TabIndex = 27;
            this.chkTime.Text = "Add Time:";
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label4);
            this.pnlDate.Controls.Add(this.pickDate2);
            this.pnlDate.Controls.Add(this.pickDate1);
            this.pnlDate.Location = new System.Drawing.Point(137, 195);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(281, 31);
            this.pnlDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "-";
            // 
            // pickDate2
            // 
            this.pickDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate2.Location = new System.Drawing.Point(152, 4);
            this.pickDate2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickDate2.Name = "pickDate2";
            this.pickDate2.Size = new System.Drawing.Size(128, 26);
            this.pickDate2.TabIndex = 22;
            // 
            // pickDate1
            // 
            this.pickDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDate1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickDate1.Location = new System.Drawing.Point(2, 4);
            this.pickDate1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickDate1.Name = "pickDate1";
            this.pickDate1.Size = new System.Drawing.Size(128, 26);
            this.pickDate1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Scheduled Date:";
            // 
            // cmbxEmp
            // 
            this.cmbxEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEmp.FormattingEnabled = true;
            this.cmbxEmp.Location = new System.Drawing.Point(166, 96);
            this.cmbxEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxEmp.Name = "cmbxEmp";
            this.cmbxEmp.Size = new System.Drawing.Size(254, 25);
            this.cmbxEmp.TabIndex = 14;
            // 
            // cmbxTask
            // 
            this.cmbxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTask.FormattingEnabled = true;
            this.cmbxTask.Location = new System.Drawing.Point(166, 49);
            this.cmbxTask.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxTask.Name = "cmbxTask";
            this.cmbxTask.Size = new System.Drawing.Size(254, 25);
            this.cmbxTask.TabIndex = 13;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(322, 340);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(96, 30);
            this.btnCancel2.TabIndex = 11;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(216, 340);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(96, 30);
            this.btnAssign.TabIndex = 10;
            this.btnAssign.Text = "Add to Calendar";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project:";
            // 
            // lbAssEmp
            // 
            this.lbAssEmp.AutoSize = true;
            this.lbAssEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssEmp.Location = new System.Drawing.Point(9, 98);
            this.lbAssEmp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAssEmp.Name = "lbAssEmp";
            this.lbAssEmp.Size = new System.Drawing.Size(153, 20);
            this.lbAssEmp.TabIndex = 8;
            this.lbAssEmp.Text = "Assigned Employee:";
            // 
            // lbAssTask
            // 
            this.lbAssTask.AutoSize = true;
            this.lbAssTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssTask.Location = new System.Drawing.Point(9, 51);
            this.lbAssTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAssTask.Name = "lbAssTask";
            this.lbAssTask.Size = new System.Drawing.Size(117, 20);
            this.lbAssTask.TabIndex = 6;
            this.lbAssTask.Text = "Assigned Task:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 145);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.label3);
            this.pnlTime.Controls.Add(this.pickTimeOut);
            this.pnlTime.Controls.Add(this.pickTimeIn);
            this.pnlTime.Location = new System.Drawing.Point(135, 249);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(284, 31);
            this.pnlTime.TabIndex = 26;
            this.pnlTime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "-";
            // 
            // pickTimeOut
            // 
            this.pickTimeOut.CustomFormat = "h:mm tt";
            this.pickTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickTimeOut.Location = new System.Drawing.Point(152, 4);
            this.pickTimeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickTimeOut.Name = "pickTimeOut";
            this.pickTimeOut.ShowUpDown = true;
            this.pickTimeOut.Size = new System.Drawing.Size(128, 26);
            this.pickTimeOut.TabIndex = 22;
            // 
            // pickTimeIn
            // 
            this.pickTimeIn.CustomFormat = "h:mm tt";
            this.pickTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickTimeIn.Location = new System.Drawing.Point(2, 4);
            this.pickTimeIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickTimeIn.Name = "pickTimeIn";
            this.pickTimeIn.ShowUpDown = true;
            this.pickTimeIn.Size = new System.Drawing.Size(128, 26);
            this.pickTimeIn.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(322, 340);
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
            this.btnAdd.Location = new System.Drawing.Point(216, 340);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lProj
            // 
            this.lProj.AutoSize = true;
            this.lProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProj.Location = new System.Drawing.Point(9, 271);
            this.lProj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProj.Name = "lProj";
            this.lProj.Size = new System.Drawing.Size(62, 20);
            this.lProj.TabIndex = 9;
            this.lProj.Text = "Project:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(9, 88);
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
            this.cmbxProj.Location = new System.Drawing.Point(13, 293);
            this.cmbxProj.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbxProj.Name = "cmbxProj";
            this.cmbxProj.Size = new System.Drawing.Size(221, 28);
            this.cmbxProj.TabIndex = 5;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(13, 111);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(407, 148);
            this.txtTaskDesc.TabIndex = 1;
            // 
            // txtTaskName
            // 
            this.txtTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.Location = new System.Drawing.Point(13, 53);
            this.txtTaskName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(407, 26);
            this.txtTaskName.TabIndex = 0;
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(454, 405);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(470, 444);
            this.MinimumSize = new System.Drawing.Size(470, 444);
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAssign.ResumeLayout(false);
            this.pnlAssign.PerformLayout();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.TextBox txtTaskName;
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbtkDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        public System.Windows.Forms.ComboBox cmbxProj;
        private System.Windows.Forms.Label lbtskTitle;
        private System.Windows.Forms.Label ltskDesc;
        private System.Windows.Forms.Label lProj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Button btnCancel2;
        public System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAssEmp;
        private System.Windows.Forms.Label lbAssTask;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox cmbxEmp;
        public System.Windows.Forms.ComboBox cmbxTask;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker pickTimeOut;
        public System.Windows.Forms.DateTimePicker pickTimeIn;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker pickDate2;
        public System.Windows.Forms.DateTimePicker pickDate1;
        public System.Windows.Forms.CheckBox chkTime;
        public System.Windows.Forms.Button btnSvCal;
    }
}