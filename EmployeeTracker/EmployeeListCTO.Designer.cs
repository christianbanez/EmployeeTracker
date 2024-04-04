namespace EmployeeTracker
{
    partial class EmployeeListCTO
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
            this.exportButton_Click = new System.Windows.Forms.Button();
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
            this.ltskDesc = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbtkDataSet = new EmployeeTracker.dbtkDataSet();
            this.employeeTableAdapter = new EmployeeTracker.dbtkDataSetTableAdapters.EmployeeTableAdapter();
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
            this.panel1.Controls.Add(this.exportButton_Click);
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
            this.panel1.Controls.Add(this.ltskDesc);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 640);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exportButton_Click
            // 
            this.exportButton_Click.Location = new System.Drawing.Point(572, 476);
            this.exportButton_Click.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exportButton_Click.Name = "exportButton_Click";
            this.exportButton_Click.Size = new System.Drawing.Size(96, 30);
            this.exportButton_Click.TabIndex = 31;
            this.exportButton_Click.Text = "Export";
            this.exportButton_Click.UseVisualStyleBackColor = true;
            this.exportButton_Click.Click += new System.EventHandler(this.exportButton_Click_Click);
            // 
            // dataGridViewCTOused
            // 
            this.dataGridViewCTOused.AllowUserToAddRows = false;
            this.dataGridViewCTOused.AllowUserToDeleteRows = false;
            this.dataGridViewCTOused.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTOused.Location = new System.Drawing.Point(348, 280);
            this.dataGridViewCTOused.Name = "dataGridViewCTOused";
            this.dataGridViewCTOused.ReadOnly = true;
            this.dataGridViewCTOused.RowHeadersWidth = 51;
            this.dataGridViewCTOused.Size = new System.Drawing.Size(319, 150);
            this.dataGridViewCTOused.TabIndex = 30;
            // 
            // txtTotalCTOBalance
            // 
            this.txtTotalCTOBalance.Enabled = false;
            this.txtTotalCTOBalance.Location = new System.Drawing.Point(409, 442);
            this.txtTotalCTOBalance.Name = "txtTotalCTOBalance";
            this.txtTotalCTOBalance.Size = new System.Drawing.Size(91, 20);
            this.txtTotalCTOBalance.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Balance:";
            // 
            // useCTObtn
            // 
            this.useCTObtn.Location = new System.Drawing.Point(459, 476);
            this.useCTObtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.useCTObtn.Name = "useCTObtn";
            this.useCTObtn.Size = new System.Drawing.Size(96, 30);
            this.useCTObtn.TabIndex = 27;
            this.useCTObtn.Text = "Use CTO";
            this.useCTObtn.UseVisualStyleBackColor = true;
            this.useCTObtn.Click += new System.EventHandler(this.useCTObtn_Click);
            // 
            // txtTotalCTORendered
            // 
            this.txtTotalCTORendered.Enabled = false;
            this.txtTotalCTORendered.Location = new System.Drawing.Point(85, 442);
            this.txtTotalCTORendered.Name = "txtTotalCTORendered";
            this.txtTotalCTORendered.Size = new System.Drawing.Size(183, 20);
            this.txtTotalCTORendered.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rendered";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "CTO:";
            // 
            // dataGridViewCTOearned
            // 
            this.dataGridViewCTOearned.AllowUserToAddRows = false;
            this.dataGridViewCTOearned.AllowUserToDeleteRows = false;
            this.dataGridViewCTOearned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTOearned.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCTOearned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTOearned.Location = new System.Drawing.Point(9, 280);
            this.dataGridViewCTOearned.Name = "dataGridViewCTOearned";
            this.dataGridViewCTOearned.ReadOnly = true;
            this.dataGridViewCTOearned.RowHeadersVisible = false;
            this.dataGridViewCTOearned.RowHeadersWidth = 51;
            this.dataGridViewCTOearned.Size = new System.Drawing.Size(320, 150);
            this.dataGridViewCTOearned.TabIndex = 23;
            // 
            // lblSelectedID
            // 
            this.lblSelectedID.Location = new System.Drawing.Point(147, 42);
            this.lblSelectedID.Name = "lblSelectedID";
            this.lblSelectedID.Size = new System.Drawing.Size(183, 20);
            this.lblSelectedID.TabIndex = 22;
            // 
            // lblSelectedName
            // 
            this.lblSelectedName.Location = new System.Drawing.Point(147, 10);
            this.lblSelectedName.Name = "lblSelectedName";
            this.lblSelectedName.Size = new System.Drawing.Size(509, 20);
            this.lblSelectedName.TabIndex = 21;
            // 
            // selectedName
            // 
            this.selectedName.AutoSize = true;
            this.selectedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedName.Location = new System.Drawing.Point(5, 10);
            this.selectedName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedName.Name = "selectedName";
            this.selectedName.Size = new System.Drawing.Size(137, 20);
            this.selectedName.TabIndex = 20;
            this.selectedName.Text = "Employee Name : ";
            // 
            // dataGridViewSchedules
            // 
            this.dataGridViewSchedules.AllowUserToAddRows = false;
            this.dataGridViewSchedules.AllowUserToDeleteRows = false;
            this.dataGridViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedules.Location = new System.Drawing.Point(9, 103);
            this.dataGridViewSchedules.Name = "dataGridViewSchedules";
            this.dataGridViewSchedules.ReadOnly = true;
            this.dataGridViewSchedules.RowHeadersWidth = 51;
            this.dataGridViewSchedules.Size = new System.Drawing.Size(658, 150);
            this.dataGridViewSchedules.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Employee ID: ";
            // 
            // ltskDesc
            // 
            this.ltskDesc.AutoSize = true;
            this.ltskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltskDesc.Location = new System.Drawing.Point(5, 80);
            this.ltskDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ltskDesc.Name = "ltskDesc";
            this.ltskDesc.Size = new System.Drawing.Size(90, 20);
            this.ltskDesc.TabIndex = 8;
            this.ltskDesc.Text = "Time Logs :";
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
            // EmployeeListCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 525);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "EmployeeListCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTO Logs";
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
        private dbtkDataSet dbtkDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private dbtkDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
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
        private System.Windows.Forms.Button exportButton_Click;
    }
}