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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\asantocildes\OneDrive - Infor\Desktop\dbtk.accdb""");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mesDel = "Are you sure you want to delete?";
            string title = "Delete Record";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesDel, title, buttons, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete * from Employee where EmployeeID ='" + txtEmployeeID.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void displayData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtEmployeeID.Text = displayData.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = displayData.SelectedRows[0].Cells[0].Value.ToString();
                txtContact.Text = displayData.SelectedRows[0].Cells[0].Value.ToString();
                txtAge.Text = displayData.SelectedRows[0].Cells[0].Value.ToString();
                txtEmail.Text = displayData.SelectedRows[0].Cells[0].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            

        }
    }
}
