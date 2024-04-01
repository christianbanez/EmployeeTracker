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
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 467);
            this.panel1.TabIndex = 0;
            // 
            // pnlAssign
            // 
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
            this.pnlAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAssign.Name = "pnlAssign";
            this.pnlAssign.Size = new System.Drawing.Size(579, 467);
            this.pnlAssign.TabIndex = 12;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTime.Location = new System.Drawing.Point(17, 315);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(125, 29);
            this.chkTime.TabIndex = 27;
            this.chkTime.Text = "Add Time:";
            this.chkTime.UseVisualStyleBackColor = true;
            this.chkTime.CheckedChanged += new System.EventHandler(this.chkTime_CheckedChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label4);
            this.pnlDate.Controls.Add(this.dateTimePicker3);
            this.pnlDate.Controls.Add(this.dateTimePicker4);
            this.pnlDate.Location = new System.Drawing.Point(183, 240);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(375, 38);
            this.pnlDate.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "-";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(202, 5);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker3.TabIndex = 22;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker4.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Scheduled Date:";
            // 
            // cmbxEmp
            // 
            this.cmbxEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEmp.FormattingEnabled = true;
            this.cmbxEmp.Location = new System.Drawing.Point(221, 118);
            this.cmbxEmp.Name = "cmbxEmp";
            this.cmbxEmp.Size = new System.Drawing.Size(337, 28);
            this.cmbxEmp.TabIndex = 14;
            // 
            // cmbxTask
            // 
            this.cmbxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTask.FormattingEnabled = true;
            this.cmbxTask.Location = new System.Drawing.Point(221, 60);
            this.cmbxTask.Name = "cmbxTask";
            this.cmbxTask.Size = new System.Drawing.Size(337, 28);
            this.cmbxTask.TabIndex = 13;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(430, 418);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(128, 37);
            this.btnCancel2.TabIndex = 11;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(288, 418);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(128, 37);
            this.btnAssign.TabIndex = 10;
            this.btnAssign.Text = "Add to Calendar";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project:";
            // 
            // lbAssEmp
            // 
            this.lbAssEmp.AutoSize = true;
            this.lbAssEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssEmp.Location = new System.Drawing.Point(12, 121);
            this.lbAssEmp.Name = "lbAssEmp";
            this.lbAssEmp.Size = new System.Drawing.Size(192, 25);
            this.lbAssEmp.TabIndex = 8;
            this.lbAssEmp.Text = "Assigned Employee:";
            // 
            // lbAssTask
            // 
            this.lbAssTask.AutoSize = true;
            this.lbAssTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssTask.Location = new System.Drawing.Point(12, 63);
            this.lbAssTask.Name = "lbAssTask";
            this.lbAssTask.Size = new System.Drawing.Size(149, 25);
            this.lbAssTask.TabIndex = 6;
            this.lbAssTask.Text = "Assigned Task:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(221, 179);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.label3);
            this.pnlTime.Controls.Add(this.dateTimePicker1);
            this.pnlTime.Controls.Add(this.dateTimePicker2);
            this.pnlTime.Location = new System.Drawing.Point(180, 307);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(378, 38);
            this.pnlTime.TabIndex = 26;
            this.pnlTime.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "h:mm tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "h:mm tt";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 30);
            this.dateTimePicker2.TabIndex = 21;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(430, 418);
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
            this.btnAdd.Location = new System.Drawing.Point(288, 418);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lProj
            // 
            this.lProj.AutoSize = true;
            this.lProj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProj.Location = new System.Drawing.Point(12, 333);
            this.lProj.Name = "lProj";
            this.lProj.Size = new System.Drawing.Size(78, 25);
            this.lProj.TabIndex = 9;
            this.lProj.Text = "Project:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(12, 108);
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
            this.cmbxProj.Location = new System.Drawing.Point(17, 361);
            this.cmbxProj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxProj.Name = "cmbxProj";
            this.cmbxProj.Size = new System.Drawing.Size(293, 33);
            this.cmbxProj.TabIndex = 5;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDesc.Location = new System.Drawing.Point(17, 137);
            this.txtTaskDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaskDesc.Multiline = true;
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(541, 181);
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
            this.ClientSize = new System.Drawing.Size(604, 492);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(622, 539);
            this.MinimumSize = new System.Drawing.Size(622, 539);
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
        private System.Windows.Forms.ComboBox cmbxProj;
        private System.Windows.Forms.Label lbtskTitle;
        private System.Windows.Forms.Label ltskDesc;
        private System.Windows.Forms.Label lProj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Panel pnlAssign;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAssEmp;
        private System.Windows.Forms.Label lbAssTask;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbxEmp;
        private System.Windows.Forms.ComboBox cmbxTask;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        public System.Windows.Forms.CheckBox chkTime;
    }
}