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

namespace EmployeeTracker
{
    public partial class tabTEAM : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\4. OJT\Jazmine\EmployeeTracker\dbtk.accdb");

        public tabTEAM()
        {
            InitializeComponent();
        }

        private void tabTEAM_Load(object sender, EventArgs e)
        {
            dataView();
        }

        //For updating datagridview
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
                displayData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //For updating datagridview when inserting or adding
        private void editTab_DataUpdated()
        {
            dataView(); //updates datagridview
        }

        //Add Method, opens EditPop for inserting
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditPop editTab = new EditPop();
            editTab.DataUpdated += editTab_DataUpdated;
            editTab.Show();
            editTab.btnSave.Hide();
            //editTab.BringToFront();

        }

        //Update Method, opens EditPop with data passed from datagridview for updating
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditPop editTab = new EditPop();

            //displays data to EditPop textboxes
            editTab.txtEmployeeID.Text = displayData.CurrentRow.Cells["EmployeeID"].Value.ToString();
            editTab.txtfName.Text = displayData.CurrentRow.Cells["fName"].Value.ToString();
            editTab.txtlName.Text = displayData.CurrentRow.Cells["lName"].Value.ToString();
            editTab.txtContact.Text = displayData.CurrentRow.Cells["contactNum"].Value.ToString();
            editTab.txtAge.Text = displayData.CurrentRow.Cells["age"].Value.ToString();
            editTab.txtEmail.Text = displayData.CurrentRow.Cells["email"].Value.ToString();
            editTab.txtrole.Text = displayData.CurrentRow.Cells["role"].Value.ToString();

            // Update checkbox state
            bool isActive = Convert.ToInt32(displayData.CurrentRow.Cells["status"].Value) == 1;
            editTab.chkActive.Checked = isActive;

            editTab.DataUpdated += editTab_DataUpdated;
            editTab.btnAdd.Hide();
            editTab.Show();
            //editTab.BringToFront();
        }

        //Delete Method
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
                    string employeeID;
                    conn.Open();
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Delete * from Employee where EmployeeID = @EmployeeID ";
                    employeeID = displayData.CurrentRow.Cells["EmployeeID"].Value.ToString();
                    cmd.Parameters.AddWithValue("@EmployeeID", Convert.ToInt32(employeeID));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataView();
                    //refresh();

                }
                else
                {   //if the data is not deleted
                   //MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch
            {
                MessageBox.Show("Record is not deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conn.Close();
        }

        //Search Method
        private void textSearch_TextChanged(object sender, EventArgs e)
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

        //Resets text in search textbox
        private void textSearch_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
        }


    }
}