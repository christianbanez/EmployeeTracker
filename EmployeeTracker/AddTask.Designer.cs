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
            this.dataGridViewCTOused = new System.Windows.Forms.DataGridView();
            this.txtTotalCTOBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.useCTObtn = new System.Windows.Forms.Button();
            this.txtTotalCTORendered = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCTOearned = new System.Windows.Forms.DataGridView();
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTOused)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTOearned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridViewCTOused);
            this.panel1.Controls.Add(this.txtTotalCTOBalance);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.useCTObtn);
            this.panel1.Controls.Add(this.txtTotalCTORendered);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridViewCTOearned);
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
            this.panel1.Location = new System.Drawing.Point(15, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 985);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewCTOused
            // 
            this.dataGridViewCTOused.AllowUserToAddRows = false;
            this.dataGridViewCTOused.AllowUserToDeleteRows = false;
            this.dataGridViewCTOused.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTOused.Location = new System.Drawing.Point(505, 632);
            this.dataGridViewCTOused.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCTOused.Name = "dataGridViewCTOused";
            this.dataGridViewCTOused.ReadOnly = true;
            this.dataGridViewCTOused.RowHeadersWidth = 51;
            this.dataGridViewCTOused.Size = new System.Drawing.Size(478, 231);
            this.dataGridViewCTOused.TabIndex = 30;
            // 
            // txtTotalCTOBalance
            // 
            this.txtTotalCTOBalance.Enabled = false;
            this.txtTotalCTOBalance.Location = new System.Drawing.Point(613, 882);
            this.txtTotalCTOBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalCTOBalance.Name = "txtTotalCTOBalance";
            this.txtTotalCTOBalance.Size = new System.Drawing.Size(134, 26);
            this.txtTotalCTOBalance.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(503, 879);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 28;
            this.label5.Text = "Balance:";
            // 
            // useCTObtn
            // 
            this.useCTObtn.Location = new System.Drawing.Point(365, 924);
            this.useCTObtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.useCTObtn.Name = "useCTObtn";
            this.useCTObtn.Size = new System.Drawing.Size(144, 46);
            this.useCTObtn.TabIndex = 27;
            this.useCTObtn.Text = "Use CTO";
            this.useCTObtn.UseVisualStyleBackColor = true;
            this.useCTObtn.Click += new System.EventHandler(this.useCTObtn_Click);
            // 
            // txtTotalCTORendered
            // 
            this.txtTotalCTORendered.Enabled = false;
            this.txtTotalCTORendered.Location = new System.Drawing.Point(145, 881);
            this.txtTotalCTORendered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalCTORendered.Name = "txtTotalCTORendered";
            this.txtTotalCTORendered.Size = new System.Drawing.Size(169, 26);
            this.txtTotalCTORendered.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 878);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rendered:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 598);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "CTO:";
            // 
            // dataGridViewCTOearned
            // 
            this.dataGridViewCTOearned.AllowUserToAddRows = false;
            this.dataGridViewCTOearned.AllowUserToDeleteRows = false;
            this.dataGridViewCTOearned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTOearned.Location = new System.Drawing.Point(14, 632);
            this.dataGridViewCTOearned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCTOearned.Name = "dataGridViewCTOearned";
            this.dataGridViewCTOearned.ReadOnly = true;
            this.dataGridViewCTOearned.RowHeadersWidth = 51;
            this.dataGridViewCTOearned.Size = new System.Drawing.Size(478, 231);
            this.dataGridViewCTOearned.TabIndex = 23;
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.Location = new System.Drawing.Point(220, 65);
            this.lblSelectedID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(272, 26);
            this.lblSelectedID.TabIndex = 22;
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.Location = new System.Drawing.Point(220, 15);
            this.lblSelectedName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(761, 26);
            this.lblSelectedName.TabIndex = 21;
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedName.Location = new System.Drawing.Point(8, 15);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(211, 29);
            this.selectedName.TabIndex = 20;
            this.selectedName.Text = "Employee Name : ";
            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.AllowUserToAddRows = false;
            this.dataGridViewSchedules.AllowUserToDeleteRows = false;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Location = new System.Drawing.Point(14, 360);
            this.dataGridViewSchedules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.ReadOnly = true;
            this.dataGridViewSchedules.RowHeadersWidth = 51;
            this.dataGridViewSchedules.Size = new System.Drawing.Size(987, 231);
            this.dataGridViewSchedules.TabIndex = 19;
            this.dataGridViewSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employee ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerTimeOut
            // 
            this.dateTimePickerTimeOut.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateTimePickerTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeOut.Location = new System.Drawing.Point(518, 258);
            this.dateTimePickerTimeOut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePickerTimeOut.Name = "dateTimePickerTimeOut";
            this.dateTimePickerTimeOut.Size = new System.Drawing.Size(482, 35);
            this.dateTimePickerTimeOut.TabIndex = 14;
            this.dateTimePickerTimeOut.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 924);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 46);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(37, 924);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 46);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lStartD
            // 
            this.lStartD.AutoSize = true;
            this.lStartD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStartD.Location = new System.Drawing.Point(8, 220);
            this.lStartD.Name = "lStartD";
            this.lStartD.Size = new System.Drawing.Size(124, 29);
            this.lStartD.TabIndex = 8;
            this.lStartD.Text = "Start Date:";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(8, 325);
            this.ltskDesc.Name = "ltskDesc";
            this.ltskDesc.Size = new System.Drawing.Size(140, 29);
            this.ltskDesc.TabIndex = 8;
            this.ltskDesc.Text = "Time Logs :";
            // 
            // lbtskTitle
            // 
            this.lbtskTitle.AutoSize = true;
            this.lbtskTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtskTitle.Location = new System.Drawing.Point(1, 109);
            this.lbtskTitle.Name = "lbtskTitle";
            this.lbtskTitle.Size = new System.Drawing.Size(126, 29);
            this.lbtskTitle.TabIndex = 6;
            this.lbtskTitle.Text = "Task Title:";
            // 
            // dateTimePickerTimeIn
            // 
            this.dateTimePickerTimeIn.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePickerTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTimeIn.Location = new System.Drawing.Point(8, 255);
            this.dateTimePickerTimeIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePickerTimeIn.Name = "dateTimePickerTimeIn";
            this.dateTimePickerTimeIn.Size = new System.Drawing.Size(484, 35);
            this.dateTimePickerTimeIn.TabIndex = 4;
            // 
            // cmbxAssign
            // 
            this.cmbxAssign.DataSource = this.employeeBindingSource;
            this.cmbxAssign.DisplayMember = "fName";
            this.cmbxAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxAssign.FormattingEnabled = true;
            this.cmbxAssign.Location = new System.Drawing.Point(8, 145);
            this.cmbxAssign.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbxAssign.Name = "cmbxAssign";
            this.cmbxAssign.Size = new System.Drawing.Size(975, 37);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 924);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 1019);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AddTask";
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTOused)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTOearned)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCTOearned;
        private System.Windows.Forms.TextBox txtTotalCTORendered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button useCTObtn;
        private System.Windows.Forms.TextBox txtTotalCTOBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewCTOused;
        private System.Windows.Forms.Button button1;
    }
}