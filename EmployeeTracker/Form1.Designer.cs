﻿using System;
using System.Windows.Forms;

namespace EmployeeTracker
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayData = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.displayData);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 525);
            this.panel1.TabIndex = 0;
            // 
            // displayData
            // 
            this.displayData.AllowUserToAddRows = false;
            this.displayData.AllowUserToDeleteRows = false;
            this.displayData.ColumnHeadersHeight = 34;
            this.displayData.Location = new System.Drawing.Point(28, 72);
            this.displayData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.displayData.Name = "displayData";
            this.displayData.ReadOnly = true;
            this.displayData.RowHeadersWidth = 62;
            this.displayData.Size = new System.Drawing.Size(720, 406);
            this.displayData.TabIndex = 11;
            this.displayData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayData_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(609, 43);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 25);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1092, 478);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 25);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1057, 423);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 25);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(934, 423);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 262);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 25);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(38, 45);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(565, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextChanged += new System.EventHandler(this.textsearch_textchanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(811, 423);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtrole);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtlName);
            this.panel2.Controls.Add(this.chkActive);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtEmployeeID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtAge);
            this.panel2.Controls.Add(this.txtContact);
            this.panel2.Controls.Add(this.txtfName);
            this.panel2.Location = new System.Drawing.Point(767, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 306);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_paint);
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(156, 209);
            this.txtrole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(224, 22);
            this.txtrole.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "First Name";
            // 
            // txtlName
            // 
            this.txtlName.Location = new System.Drawing.Point(156, 79);
            this.txtlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(224, 22);
            this.txtlName.TabIndex = 22;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(156, 255);
            this.chkActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(66, 20);
            this.chkActive.TabIndex = 21;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(156, 18);
            this.txtEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(224, 22);
            this.txtEmployeeID.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Last Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(156, 142);
            this.txtAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(224, 22);
            this.txtAge.TabIndex = 12;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(156, 110);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact.MaxLength = 11;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(224, 22);
            this.txtContact.TabIndex = 11;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontact_keypress);
            // 
            // txtfName
            // 
            this.txtfName.Location = new System.Drawing.Point(156, 51);
            this.txtfName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(224, 22);
            this.txtfName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 549);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.DataGridView displayData;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Label label8;
        private Button btnAdd;
    }
}