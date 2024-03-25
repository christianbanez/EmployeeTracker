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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EmployeeTracker
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cbanez\source\repos\EmployeeTracker\dbtk.accdb");
        DataTable dt;
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

        //to refresh the data view
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
            Form2 form = new Form2();
            form.DataUpdated += Form2_DataUpdated;
            form.Show();
        }
        private void Form2_DataUpdated()
        {
            // Refresh or reload your DataGridView
            dataView(); // Assuming dataView() is the method that reloads the DataGridView
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

        private void DisplayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    // Get the selected row index
            //    int rowIndex = e.RowIndex;

            //    // Ensure a valid row is selected
            //    if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
            //    {
            //        // Update text fields
            //        txtEmployeeID.Text = displayData.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();
            //        txtlName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
            //        txtfName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
            //        txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
            //        txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
            //        txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();
            //        txtrole.Text = displayData.Rows[rowIndex].Cells["role"].Value.ToString();

            //        // Update checkbox state
            //        bool isActive = Convert.ToInt32(displayData.Rows[rowIndex].Cells["status"].Value) == 1;
            //        chkActive.Checked = isActive;
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Use class-level variable
                int state = chkActive.Checked ? 1 : 0; 

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Employee SET fName = @fName, lName = @lName, contactNum = @contact, age = @age, email = @email, status = @status, role = @role WHERE EmployeeID = @employeeID";

                // Parameters
                cmd.Parameters.AddWithValue("@fName", txtlName.Text);
                cmd.Parameters.AddWithValue("@lName", txtfName.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@status", state);
                cmd.Parameters.AddWithValue("@role", txtrole.Text);
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

                dataView();
                refresh();
                



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
                    txtlName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
                    txtfName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
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


        private void textsearch_textchanged(object sender, EventArgs e)
        {
            BindingSource dv = new BindingSource();
            dv.DataSource = displayData.DataSource;
            //dataview dv = dt.defaultview;
            dv.Filter = "fname like  '%" + textSearch.Text + "%' or lname like '%" + textSearch.Text + "%' ";
            displayData.DataSource = dv;
            //bindingsource bs = new bindingsource();
            //bs.datasource = displaydata.datasource;
            //bs.filter = "select * from employee where fname '%" + textsearch.text + "%'";
            //displaydata.datasource = bs;
            //dataview dv = dt.defaultview;
            //dv.rowfilter = "select * from employee where fname like  '%" + textsearch.text + "%' or lname like'%" + textsearch.text + "%'";
        }

        private void panel2_paint(object sender, PaintEventArgs e)
        {

        }
        private void txtcontact_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("error, contact number should only contain numbers");
            }
        }

    }
}
