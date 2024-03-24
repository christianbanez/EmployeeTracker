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

namespace EmployeeTracker
{
    public partial class Form2 : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\Downloads\dbtk.accdb");
        int state;
        public Form2()
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


        private void btnAdd_Click(object sender, EventArgs e)
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
                //adding values into database
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Employee(EmployeeID,fName,lName,contactNum,age,email,status,role)VALUES(@EmployeeID, @fName, @lName, @Contact, @Age, @Email, @state, @role)";
                cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text));
                cmd.Parameters.AddWithValue("@fName", txtlName.Text);
                cmd.Parameters.AddWithValue("@lName", txtfName.Text);
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
