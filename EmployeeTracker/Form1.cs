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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\cbanez\OneDrive - Infor\Desktop\dbtk.accdb""");
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
                dataView();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult leave;
            leave = MessageBox.Show("Confirm if you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (leave == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
