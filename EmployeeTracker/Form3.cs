using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Text.RegularExpressions;

namespace EmployeeTracker
{
    public partial class Form3 : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cbanez\source\repos\EmployeeTracker\dbtk.accdb");
        string pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";
        int state;
        public Form3()
        {
            InitializeComponent();
        }
        private bool ValidateEmployeeID()
        {
            bool bStatus = true;
            if (txtEmployeeID.Text == "")
            {
                errorProvider1.SetError(txtEmployeeID, "Please enter the Employee ID");
                bStatus = false;
            }
            else
                errorProvider1.Clear();

            return bStatus;
        }

        private bool ValidatefName()
        {
            bool bStatus = true;
            if (txtfName.Text == "")
            {
                errorProvider2.SetError(txtfName, "Please enter the First Name");
                bStatus = false;
            }
            else
                errorProvider2.Clear();
            return bStatus;
        }
        private bool ValidatelName()
        {
            bool bStatus = true;
            if (txtlName.Text == "")
            {
                errorProvider3.SetError(txtlName, "Please enter the Last Name");
                bStatus = false;
            }
            else
                errorProvider3.Clear();
            return bStatus;
        }
        private bool Validatecontact()
        {
            bool bStatus = true;
            if (txtContact.Text == "")
            {
                errorProvider4.SetError(txtContact, "Please enter the Contact Number");
                bStatus = false;
            }
            else
                errorProvider4.Clear();
            return bStatus;
        }
        private bool ValidateAge()
        {
            bool bStatus = true;
            if (txtAge.Text == "")
            {
                errorProvider5.SetError(txtAge, "Please enter the Age");
                bStatus = false;
            }
            else
                errorProvider5.Clear();
            return bStatus;
        }
        private bool ValidateEmail()
        {
            bool bStatus = true;
            if (txtEmail.Text == "")
            {
                errorProvider6.SetError(txtEmail, "Please enter the Email");
                bStatus = false;
            }
            else if (Regex.IsMatch(txtEmail.Text, pattern) == false)
            {
                errorProvider6.SetError(txtEmail, "Please enter the correct format");
                bStatus = false;
            }
            else
            {
                errorProvider6.Clear();
            }

            return bStatus;
        }
        private bool ValidateRole()
        {
            bool bStatus = true;
            if (txtrole.Text == "")
            {
                errorProvider7.SetError(txtrole, "Please enter the Role");
                bStatus = false;
            }
            else
            {
                errorProvider7.Clear();
            }

            return bStatus;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool bValidateEmployeeID = ValidateEmployeeID();
            bool bValidfName = ValidatefName();
            bool bValidlName = ValidatelName();
            bool bValidatecontact = Validatecontact();
            bool bValidAge = ValidateAge();
            bool bValidEmail = ValidateEmail();
            bool bValidRole = ValidateRole();
            //Checkbox
            if (chkActive.Checked == true)
            {
                state = -1;
            }
            else if (chkActive.Checked == false)
            {
                state = 0;
            }
            if (bValidateEmployeeID && bValidfName && bValidlName && bValidatecontact && bValidAge && bValidEmail && bValidRole)
            {

                try
                {
                    // Use class-level variable
                    int state = chkActive.Checked ? 1 : 0;

                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Employee SET fName = @fName, lName = @lName, contactNum = @contact, age = @age, email = @email, role = @role, status = @status WHERE EmployeeID = @employeeID";

                    // Parameters
                    cmd.Parameters.AddWithValue("@fName", txtfName.Text);
                    cmd.Parameters.AddWithValue("@lName", txtlName.Text);
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@role", txtrole.Text);
                    cmd.Parameters.AddWithValue("@status", state);
                    cmd.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);


                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated in Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataUpdated?.Invoke();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Employee ID not found or no changes made", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error in updating the form! Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmployeeID();
        }

        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtfName_Validating(object sender, CancelEventArgs e)
        {
            ValidatefName();
        }

        private void txtlName_Validating(object sender, CancelEventArgs e)
        {
            ValidatelName();
        }

        private void txtContact_Validating(object sender, CancelEventArgs e)
        {
            Validatecontact();
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAge_Validating(object sender, CancelEventArgs e)
        {
            ValidateAge();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmail();
        }

        private void txtrole_Validating(object sender, CancelEventArgs e)
        {
            ValidateRole();
        }
    }

    
}

    

