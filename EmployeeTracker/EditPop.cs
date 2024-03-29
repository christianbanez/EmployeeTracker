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
using System.Text.RegularExpressions;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTracker
{
    public partial class EditPop : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Christian\source\repos\EmployeeTracker\dbtk.accdb");
        int state;
        string pattern = "^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$";

        public EditPop()
        {
            InitializeComponent();
        }
        //Error trapping, validation
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


        //Sace button for updating
        private void btnSave_Click(object sender, EventArgs e)
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
                    //updating values into database
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
                MessageBox.Show("Error in filling up the form! Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Add button for inserting
        private void btnAdd_Click(object sender, EventArgs e)
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
                    //adding values into database
                    conn.Open();

                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Employee(EmployeeID,fName,lName,contactNum,age,email,status,role,accDateCreated)VALUES(@EmployeeID, @fName, @lName, @Contact, @Age, @Email, @state, @role, Now())";
                    cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text));
                    cmd.Parameters.AddWithValue("@fName", txtfName.Text);
                    cmd.Parameters.AddWithValue("@lName", txtlName.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@role", txtrole.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved in Database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataUpdated?.Invoke();
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error in filling up the form! Please try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtEmployeeID_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmployeeID.Text) == true)
            {
                errorProvider1.SetError(this.txtEmployeeID, "Please Fill the Employee ID");
            }
            else
            {
                errorProvider1.Clear();
            }

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

        private void txtEmployeeID_Validating(object sender, CancelEventArgs e)
        {
            ValidateEmployeeID();
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