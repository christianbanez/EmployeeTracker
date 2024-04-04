namespace EmployeeTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panelCalPage = new System.Windows.Forms.Panel();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCdCd = new System.Windows.Forms.Button();
            this.btnCdTm = new System.Windows.Forms.Button();
            this.btnCdTd = new System.Windows.Forms.Button();
            this.btnCdOv = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.EmployeeList1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.tabCALENDAR1 = new EmployeeTracker.tabCALENDAR();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.panelCalPage.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList1)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 39);
            this.panel2.TabIndex = 10;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(1105, 5);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 30);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.panel5.Location = new System.Drawing.Point(15, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1233, 646);
            this.panel5.TabIndex = 5;
            // 
            // panelTabs
            // 
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabs.Location = new System.Drawing.Point(304, 78);
            this.panelTabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(643, 568);
            this.panelTabs.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnCalendar);
            this.panel6.Controls.Add(this.btnTeam);
            this.panel6.Controls.Add(this.btnToday);
            this.panel6.Controls.Add(this.btnOverV);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(304, 39);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(643, 39);
            this.panel6.TabIndex = 13;
            // 
            // btnCalendar
            // 
            this.btnCalendar.AutoSize = true;
            this.btnCalendar.Location = new System.Drawing.Point(198, 4);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(96, 32);
            this.btnCalendar.TabIndex = 6;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnTeam
            // 
            this.btnTeam.AutoSize = true;
            this.btnTeam.Location = new System.Drawing.Point(300, 4);
            this.btnTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeam.Name = "btnTeam";
            this.btnTeam.Size = new System.Drawing.Size(81, 32);
            this.btnTeam.TabIndex = 3;
            this.btnTeam.Text = "Team";
            this.btnTeam.UseVisualStyleBackColor = true;
            this.btnTeam.Click += new System.EventHandler(this.btnTeam_Click);
            // 
            // btnToday
            // 
            this.btnToday.AutoSize = true;
            this.btnToday.Location = new System.Drawing.Point(107, 4);
            this.btnToday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(85, 32);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnOverV
            // 
            this.btnOverV.AutoSize = true;
            this.btnOverV.Location = new System.Drawing.Point(4, 4);
            this.btnOverV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOverV.Name = "btnOverV";
            this.btnOverV.Size = new System.Drawing.Size(97, 32);
            this.btnOverV.TabIndex = 0;
            this.btnOverV.Text = "Overview";
            this.btnOverV.UseVisualStyleBackColor = true;
            this.btnOverV.Click += new System.EventHandler(this.btnOverV_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 607);
            this.panel3.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.EmployeeList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(947, 39);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 607);
            this.panel4.TabIndex = 16;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // EmployeeList
            // 
            this.EmployeeList.AllowUserToAddRows = false;
            this.EmployeeList.AllowUserToDeleteRows = false;
            this.EmployeeList.AllowUserToResizeColumns = false;
            this.EmployeeList.AllowUserToResizeRows = false;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.EmployeeList.ColumnHeadersHeight = 29;
            this.EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeList.ColumnHeadersVisible = false;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.DefaultCellStyle = dataGridViewCellStyle51;
            this.EmployeeList.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeList.Location = new System.Drawing.Point(0, 48);
            this.EmployeeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.ReadOnly = true;
            this.EmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeeList.RowHeadersVisible = false;
            this.EmployeeList.RowHeadersWidth = 51;
            this.EmployeeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.EmployeeList.Size = new System.Drawing.Size(286, 555);
            this.EmployeeList.TabIndex = 0;
            this.EmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellClick);
            // 
            // panelCalPage
            // 
            this.panelCalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalPage.Controls.Add(this.panelCalendar);
            this.panelCalPage.Controls.Add(this.panel11);
            this.panelCalPage.Controls.Add(this.panel12);
            this.panelCalPage.Location = new System.Drawing.Point(16, 14);
            this.panelCalPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCalPage.Name = "panelCalPage";
            this.panelCalPage.Size = new System.Drawing.Size(1232, 646);
            this.panelCalPage.TabIndex = 18;
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.tabCALENDAR1);
            this.panelCalendar.Controls.Add(this.panel7);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalendar.Location = new System.Drawing.Point(0, 39);
            this.panelCalendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(946, 607);
            this.panelCalendar.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnCdCd);
            this.panel7.Controls.Add(this.btnCdTm);
            this.panel7.Controls.Add(this.btnCdTd);
            this.panel7.Controls.Add(this.btnCdOv);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(946, 39);
            this.panel7.TabIndex = 14;
            // 
            // btnCdCd
            // 
            this.btnCdCd.AutoSize = true;
            this.btnCdCd.Location = new System.Drawing.Point(198, 4);
            this.btnCdCd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdCd.Name = "btnCdCd";
            this.btnCdCd.Size = new System.Drawing.Size(96, 32);
            this.btnCdCd.TabIndex = 6;
            this.btnCdCd.Text = "Calendar";
            this.btnCdCd.UseVisualStyleBackColor = true;
            this.btnCdCd.Click += new System.EventHandler(this.btnCdCd_Click);
            // 
            // btnCdTm
            // 
            this.btnCdTm.AutoSize = true;
            this.btnCdTm.Location = new System.Drawing.Point(300, 4);
            this.btnCdTm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdTm.Name = "btnCdTm";
            this.btnCdTm.Size = new System.Drawing.Size(81, 32);
            this.btnCdTm.TabIndex = 3;
            this.btnCdTm.Text = "Team";
            this.btnCdTm.UseVisualStyleBackColor = true;
            this.btnCdTm.Click += new System.EventHandler(this.btnCdTm_Click);
            // 
            // btnCdTd
            // 
            this.btnCdTd.AutoSize = true;
            this.btnCdTd.Location = new System.Drawing.Point(107, 4);
            this.btnCdTd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdTd.Name = "btnCdTd";
            this.btnCdTd.Size = new System.Drawing.Size(85, 32);
            this.btnCdTd.TabIndex = 1;
            this.btnCdTd.Text = "Today";
            this.btnCdTd.UseVisualStyleBackColor = true;
            this.btnCdTd.Click += new System.EventHandler(this.btnCdTd_Click);
            // 
            // btnCdOv
            // 
            this.btnCdOv.AutoSize = true;
            this.btnCdOv.Location = new System.Drawing.Point(4, 4);
            this.btnCdOv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCdOv.Name = "btnCdOv";
            this.btnCdOv.Size = new System.Drawing.Size(97, 32);
            this.btnCdOv.TabIndex = 0;
            this.btnCdOv.Text = "Overview";
            this.btnCdOv.UseVisualStyleBackColor = true;
            this.btnCdOv.Click += new System.EventHandler(this.btnCdOv_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.EmployeeList1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(946, 39);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(286, 607);
            this.panel11.TabIndex = 16;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // EmployeeList1
            // 
            this.EmployeeList1.AllowUserToAddRows = false;
            this.EmployeeList1.AllowUserToDeleteRows = false;
            this.EmployeeList1.AllowUserToResizeColumns = false;
            this.EmployeeList1.AllowUserToResizeRows = false;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.EmployeeList1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeList1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.EmployeeList1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeeList1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.EmployeeList1.ColumnHeadersHeight = 29;
            this.EmployeeList1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeList1.ColumnHeadersVisible = false;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList1.DefaultCellStyle = dataGridViewCellStyle55;
            this.EmployeeList1.GridColor = System.Drawing.SystemColors.Control;
            this.EmployeeList1.Location = new System.Drawing.Point(0, 48);
            this.EmployeeList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmployeeList1.Name = "EmployeeList1";
            this.EmployeeList1.ReadOnly = true;
            this.EmployeeList1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeeList1.RowHeadersVisible = false;
            this.EmployeeList1.RowHeadersWidth = 51;
            this.EmployeeList1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList1.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.EmployeeList1.Size = new System.Drawing.Size(286, 555);
            this.EmployeeList1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee List";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.button5);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1232, 39);
            this.panel12.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(1104, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(116, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Export";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabCALENDAR1
            // 
            this.tabCALENDAR1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCALENDAR1.Location = new System.Drawing.Point(0, 39);
            this.tabCALENDAR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCALENDAR1.Name = "tabCALENDAR1";
            this.tabCALENDAR1.Size = new System.Drawing.Size(946, 568);
            this.tabCALENDAR1.TabIndex = 15;
            this.EmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellClick);
            this.EmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeList_CellContentClick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelCalPage);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.panelCalPage.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList1)).EndInit();
            this.panel12.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panelCalPage;
        private System.Windows.Forms.Panel panelCalendar;
        private tabCALENDAR tabCALENDAR1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCdCd;
        private System.Windows.Forms.Button btnCdTm;
        private System.Windows.Forms.Button btnCdTd;
        private System.Windows.Forms.Button btnCdOv;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DataGridView EmployeeList1;
        private System.Windows.Forms.Label label2;
    }
}