namespace EmployeeTracker
{
    partial class Form4
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.displayCTOhours = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.displayTimeLogs = new System.Windows.Forms.DataGridView();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.dateTimeOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimeIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.ScheduleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.displayCTOhours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayTimeLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(559, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 43);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time Logs";
            // 
            // displayCTOhours
            // 
            this.displayCTOhours.AllowUserToAddRows = false;
            this.displayCTOhours.AllowUserToDeleteRows = false;
            this.displayCTOhours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayCTOhours.Location = new System.Drawing.Point(40, 477);
            this.displayCTOhours.Name = "displayCTOhours";
            this.displayCTOhours.ReadOnly = true;
            this.displayCTOhours.RowHeadersWidth = 62;
            this.displayCTOhours.RowTemplate.Height = 28;
            this.displayCTOhours.Size = new System.Drawing.Size(707, 184);
            this.displayCTOhours.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Compensatory Time Off Count";
            // 
            // displayTimeLogs
            // 
            this.displayTimeLogs.AllowUserToAddRows = false;
            this.displayTimeLogs.AllowUserToDeleteRows = false;
            this.displayTimeLogs.AllowUserToResizeColumns = false;
            this.displayTimeLogs.AllowUserToResizeRows = false;
            this.displayTimeLogs.AutoGenerateColumns = false;
            this.displayTimeLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayTimeLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.displayTimeLogs.DataSource = this.scheduleBindingSource;
            this.displayTimeLogs.Location = new System.Drawing.Point(40, 147);
            this.displayTimeLogs.Name = "displayTimeLogs";
            this.displayTimeLogs.ReadOnly = true;
            this.displayTimeLogs.RowHeadersWidth = 62;
            this.displayTimeLogs.RowTemplate.Height = 28;
            this.displayTimeLogs.Size = new System.Drawing.Size(707, 281);
            this.displayTimeLogs.TabIndex = 13;
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "timeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "timeIn";
            this.timeInDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            this.timeInDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeInDataGridViewTextBoxColumn.Width = 200;
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "timeOut";
            this.timeOutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            this.timeOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeOutDataGridViewTextBoxColumn.Width = 200;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "Schedule";
            this.scheduleBindingSource.DataSource = this.dbtkDataSet;
            // 
            // dbtkDataSet
            // 
            this.dbtkDataSet.DataSetName = "dbtkDataSet";
            this.dbtkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimeOut
            // 
            this.dateTimeOut.CustomFormat = "MM/dd/yyyy, hh:mm tt";
            this.dateTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeOut.Location = new System.Drawing.Point(143, 62);
            this.dateTimeOut.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeOut.Name = "dateTimeOut";
            this.dateTimeOut.Size = new System.Drawing.Size(348, 26);
            this.dateTimeOut.TabIndex = 12;
            // 
            // dateTimeIn
            // 
            this.dateTimeIn.CustomFormat = "mm/dd/yyyy hh:mm tt";
            this.dateTimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeIn.Location = new System.Drawing.Point(143, 27);
            this.dateTimeIn.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimeIn.Name = "dateTimeIn";
            this.dateTimeIn.Size = new System.Drawing.Size(348, 26);
            this.dateTimeIn.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date Ended";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date Started";
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displayCTOhours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayTimeLogs);
            this.Controls.Add(this.dateTimeOut);
            this.Controls.Add(this.dateTimeIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displayCTOhours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayTimeLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbtkDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView displayCTOhours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView displayTimeLogs;
        private System.Windows.Forms.DateTimePicker dateTimeOut;
        private System.Windows.Forms.DateTimePicker dateTimeIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private dbtkDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
    }
}