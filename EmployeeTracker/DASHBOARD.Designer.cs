﻿namespace EmployeeTracker
{
    partial class frmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelTabs = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnTeam = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnOverV = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeList = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 32);
            this.panel2.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1146, 4);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 24);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.panelTabs);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(11, 11);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1242, 659);
            this.panel5.TabIndex = 5;
            // 
            // panelTabs
            // 
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabs.Location = new System.Drawing.Point(247, 64);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(758, 595);
            this.panelTabs.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCalendar);
            this.panel6.Controls.Add(this.btnTeam);
            this.panel6.Controls.Add(this.btnToday);
            this.panel6.Controls.Add(this.btnOverV);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(247, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(758, 32);
            this.panel6.TabIndex = 13;
            // 
            // btnCalendar
            // 
            this.btnCalendar.AutoSize = true;
            this.btnCalendar.Location = new System.Drawing.Point(141, 3);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(65, 24);
            this.btnCalendar.TabIndex = 6;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.AutoSize = true;
            this.btnTeam.Location = new System.Drawing.Point(209, 3);
            this.btnTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(61, 24);
            this.btnTeam.TabIndex = 3;
            this.btnTeam.Text = "Team";
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.Location = new System.Drawing.Point(72, 3);
            this.btnToday.Margin = new System.Windows.Forms.Padding(2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(64, 24);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnOverV
            // 
            this.btnOverV.AutoSize = true;
            this.btnOverV.Location = new System.Drawing.Point(3, 3);
            this.btnOverV.Margin = new System.Windows.Forms.Padding(2);
            this.btnOverV.Name = "btnOverV";
            this.btnOverV.Size = new System.Drawing.Size(66, 24);
            this.btnOverV.TabIndex = 0;
            this.btnOverV.Text = "Overview";
            this.btnOverV.UseVisualStyleBackColor = true;
            this.btnOverV.Click += new System.EventHandler(this.btnOverV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 627);
            this.panel3.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(1, 0);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.EmployeeList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1005, 32);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 627);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.AllowUserToResizeColumns = false;
            this.EmployeeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeList.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeList.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeList.Location = new System.Drawing.Point(10, 32);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeeList.RowHeadersVisible = false;
            this.EmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeList.Size = new System.Drawing.Size(228, 554);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellClick);
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracker";
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnTeam;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnOverV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.DataGridView EmployeeList;
        private System.Windows.Forms.Label label1;
    }
}