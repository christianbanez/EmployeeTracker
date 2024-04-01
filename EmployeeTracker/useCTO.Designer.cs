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
            this.SuspendLayout();
            // 
            // datetimepickerUseDate
            // 
            this.datetimepickerUseDate.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.datetimepickerUseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimepickerUseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerUseDate.Location = new System.Drawing.Point(39, 170);
            this.datetimepickerUseDate.Name = "datetimepickerUseDate";
            this.datetimepickerUseDate.Size = new System.Drawing.Size(306, 35);
            this.datetimepickerUseDate.TabIndex = 0;
            // 
            // useCTOtxt
            // 
            this.useCTOtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCTOtxt.Location = new System.Drawing.Point(351, 172);
            this.useCTOtxt.Name = "useCTOtxt";
            this.useCTOtxt.Size = new System.Drawing.Size(156, 35);
            this.useCTOtxt.TabIndex = 1;
            // 
            // useCTOsave
            // 
            this.useCTOsave.Location = new System.Drawing.Point(525, 169);
            this.useCTOsave.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.useCTOsave.Name = "useCTOsave";
            this.useCTOsave.Size = new System.Drawing.Size(144, 46);
            this.useCTOsave.TabIndex = 28;
            this.useCTOsave.Text = "Save";
            this.useCTOsave.UseVisualStyleBackColor = true;
            this.useCTOsave.Click += new System.EventHandler(this.useCTOsave_Click);
            // 
            // UseCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.useCTOsave);
            this.Controls.Add(this.useCTOtxt);
            this.Controls.Add(this.datetimepickerUseDate);
            this.Name = "UseCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "useCTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimepickerUseDate;
        private System.Windows.Forms.TextBox useCTOtxt;
        private System.Windows.Forms.Button useCTOsave;
    }
}