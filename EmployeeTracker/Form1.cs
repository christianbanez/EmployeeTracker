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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\tdizon\Downloads\dbtk.accdb""");
        OleDbDataAdapter dp;
        DataTable dt;
        int state;
        public Form1()
        {
            InitializeComponent();
        }

        void DataView()
        {
            try
            {
                //adding values into database
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
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
            DataView();
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
                cmd.CommandText = "INSERT INTO Employee(EmployeeID,Name,contactNum,age,email,status)VALUES(@EmployeeID, @Name, @Contact, @Age, @Email, @state)";
                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@state", state);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record saved in Database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                conn.Close();
                DataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            DataView();
            txtEmployeeID.Text = "";
            txtName.Text = "";
            txtContact.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mesDel = "Are you sure you want to delete?";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesDel, title, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {   //to delete the data
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete * from Employee where EmployeeID = @EmployeeID";
                cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(txtEmployeeID.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataView();

                txtEmployeeID.Text = "";
                txtName.Text = "";
                txtContact.Text = "";
                txtAge.Text = "";
                txtEmail.Text = "";
            }
            else
            {   //if the data is not deleted
                MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void DisplayData_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void displayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Use class-level variable
                int state = chkActive.Checked ? 1 : 0; 

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

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated in Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee ID not found or no changes made", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the selected row index
                int rowIndex = e.RowIndex;

                if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
                {
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //search values into database
            //    conn.Open();
            //    OleDbCommand cmd = conn.CreateCommand();
            //    cmd.CommandType = CommandType.Text;

            //    cmd.CommandText = "SELECT * FROM Employee WHERE EmployeeID = '%" + textSearch.Text + "%' or Name '" + textSearch.Text + "' ";

            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
            //    dp.Fill(dt);
            //    displayData.DataSource = dt;

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Name LIKE '%" + textSearch.Text + "%'";
            displayData.DataSource = dv;
        }
    }
}
