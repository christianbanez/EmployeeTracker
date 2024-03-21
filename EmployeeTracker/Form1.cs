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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jsantiago3\Downloads\dbtk.accdb");
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
        private void Form1_Load(object sender, EventArgs e)
        {
            dataView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
                cmd.CommandText = "INSERT INTO Employee(EmployeeID,Name,contactNum,age,email,status)VALUES('" + txtEmployeeID.Text + "','" + txtName.Text + "','" + txtContact.Text + "','" + txtAge.Text + "','" + txtEmail.Text + "', '" + state + "' )";
                cmd.Parameters.AddWithValue("txtEmployeeID.Text", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("txtName.Text", txtName.Text);
                cmd.Parameters.AddWithValue("txtContact.Text", txtContact.Text);
                cmd.Parameters.AddWithValue("txtAge.Text", txtAge.Text);
                cmd.Parameters.AddWithValue("txt.Email.Text", txtEmail.Text);
                cmd.Parameters.AddWithValue("state", state);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved in Database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void displayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Use class-level variable
                if (chkActive.Checked)
                {
                    state = -1;
                }

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Employee SET Name = @name, contactNum = @contact, age = @age, email = @email, status = @status WHERE EmployeeID = @employeeID";

                // Parameters
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@status", state);
                cmd.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated in Database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                    txtName.Text = displayData.Rows[rowIndex].Cells["Name"].Value.ToString();
                    txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
                    txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
                    txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();

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
    }
}
