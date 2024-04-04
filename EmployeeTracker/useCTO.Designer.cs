namespace EmployeeTracker
{
    partial class UseCTO
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
            this.datetimepickerUseDate = new System.Windows.Forms.DateTimePicker();
            this.useCTOtxt = new System.Windows.Forms.TextBox();
            this.useCTOsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datetimepickerUseDate
            // 
            this.datetimepickerUseDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.datetimepickerUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerUseDate.Location = new System.Drawing.Point(48, 170);
            this.datetimepickerUseDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datetimepickerUseDate.Name = "datetimepickerUseDate";
            this.datetimepickerUseDate.Size = new System.Drawing.Size(272, 30);
            this.datetimepickerUseDate.TabIndex = 0;
            // 
            // useCTOtxt
            // 
            this.useCTOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCTOtxt.Location = new System.Drawing.Point(344, 170);
            this.useCTOtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useCTOtxt.Name = "useCTOtxt";
            this.useCTOtxt.Size = new System.Drawing.Size(139, 30);
            this.useCTOtxt.TabIndex = 1;
            this.useCTOtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.useCTOtxt_KeyPress);
            // 
            // useCTOsave
            // 
            this.useCTOsave.Location = new System.Drawing.Point(509, 170);
            this.useCTOsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.useCTOsave.Name = "useCTOsave";
            this.useCTOsave.Size = new System.Drawing.Size(128, 37);
            this.useCTOsave.TabIndex = 28;
            this.useCTOsave.Text = "Save";
            this.useCTOsave.UseVisualStyleBackColor = true;
            this.useCTOsave.Click += new System.EventHandler(this.useCTOsave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(43, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date Use";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(339, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Point Use";
            // 
            // UseCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useCTOsave);
            this.Controls.Add(this.useCTOtxt);
            this.Controls.Add(this.datetimepickerUseDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UseCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "useCTO";
            this.Load += new System.EventHandler(this.UseCTO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimepickerUseDate;
        private System.Windows.Forms.TextBox useCTOtxt;
        private System.Windows.Forms.Button useCTOsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}