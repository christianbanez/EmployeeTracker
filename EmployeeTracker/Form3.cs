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

namespace EmployeeTracker
{
    public partial class Form3 : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tdizon\Downloads\dbtk.accdb");
        int state;
        public Form3()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string eMailchecker)
        {
            bool result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMailchecker);

                result = (eMailchecker.LastIndexOf(".") > eMailchecker.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            };

            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtContact.TextLength == 11)
            {
                //checking email 
                if (IsValidEmail(txtEmail.Text))
                {

                    //Checkbox
                    if (chkActive.Checked == true)
                    {
                        state = -1;
                    }
                    else if (chkActive.Checked == false)
                    {
                        state = 0;
                    }

                    try
                    {
                        // Use class-level variable
                        int state = chkActive.Checked ? 1 : 0;

                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Employee SET fName = @fName, lName = @lName, contactNum = @contact, age = @age, email = @email, status = @status WHERE EmployeeID = @employeeID";

                        // Parameters
                        cmd.Parameters.AddWithValue("@fName", txtfName.Text);
                        cmd.Parameters.AddWithValue("@lName", txtlName.Text);
                        cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                        cmd.Parameters.AddWithValue("@age", txtAge.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);
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
                    MessageBox.Show("Please input the correct email format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please input the correct number format", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }

    
}

    

