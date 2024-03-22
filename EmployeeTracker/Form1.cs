using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace EmployeeTracker
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cbanez\Downloads\dbtk.accdb");
        int state;
        public Form1()
        {
            InitializeComponent();
        }

        void dataView()
        {
            try
            {
                //adding values into database
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                displayData.DataSource=dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        void refresh()
        {
            txtEmployeeID.Text = "";
            txtfName.Text = "";
            txtlName.Text = "";
            txtContact.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
            txtrole.Text = "";
            chkActive.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //checking the contact number length

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

                        conn.Close();
                        dataView();
                        refresh();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnView_Click(object sender, EventArgs e)
        {
            dataView();
            refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mesDel = "Are you sure you want to delete?";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesDel, title, buttons, MessageBoxIcon.Question);

            try
            {
                if (result == DialogResult.Yes)
                {   //to delete the data
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete * from Employee where EmployeeID = @EmployeeID ";
                    cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataView();
                    refresh();

                }
                else
                {   //if the data is not deleted
                    MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void displayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the selected row index
                int rowIndex = e.RowIndex;

                // Ensure a valid row is selected
                if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
                {
                    // Update text fields
                    txtEmployeeID.Text = displayData.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();
                    txtfName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
                    txtlName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
                    txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
                    txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
                    txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();
                    txtrole.Text = displayData.Rows[rowIndex].Cells["role"].Value.ToString();

                    // Update checkbox state
                    bool isActive = Convert.ToInt32(displayData.Rows[rowIndex].Cells["status"].Value) == 1;
                    chkActive.Checked = isActive;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult leave;
            leave = MessageBox.Show("Confirm if you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (leave == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.TextLength == 11)
            {
                txtContact.ForeColor = Color.Black;
            }
            else
            {
                txtContact.ForeColor = Color.Red;
            }
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) 
            {
                e.Handled = true;
                MessageBox.Show("Error, Contact Number should only contain numbers");
            }
        }
    }
}
