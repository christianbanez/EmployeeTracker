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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tdizon\Downloads\dbtk.accdb");

        public tabTEAM()
        {
            InitializeComponent();
        }

        //private void AddTabs(UserControl userControl)
        //{
        //    userControl.Dock = DockStyle.Fill;
        //    //panel5.Controls.Clear();
        //    tabTEAM.Controls.Add(userControl);
        //    userControl.BringToFront();
        //}
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPopup addTab = new AddPopup();
            //addTab.DataUpdated += addTab_DataUpdated;
            addTab.Show();
            addTab.BringToFront();
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    Form3 form3 = new Form3();

        //    //displays data to form3
        //    form3.txtEmployeeID.Text = displayData.CurrentRow.Cells["EmployeeID"].Value.ToString();
        //    form3.txtfName.Text = displayData.CurrentRow.Cells["fName"].Value.ToString();
        //    form3.txtlName.Text = displayData.CurrentRow.Cells["lName"].Value.ToString();
        //    form3.txtContact.Text = displayData.CurrentRow.Cells["contactNum"].Value.ToString();
        //    form3.txtAge.Text = displayData.CurrentRow.Cells["age"].Value.ToString();
        //    form3.txtEmail.Text = displayData.CurrentRow.Cells["email"].Value.ToString();
        //    form3.txtrole.Text = displayData.CurrentRow.Cells["role"].Value.ToString();

        //    // Update checkbox state
        //    bool isActive = Convert.ToInt32(displayData.CurrentRow.Cells["status"].Value) == 1;
        //    form3.chkActive.Checked = isActive;

        //    form3.DataUpdated += Form3_DataUpdated;
        //    form3.Show();
        //}

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
                    //dataView();
                    //refresh();

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

        private void displayData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabTEAM_Load(object sender, EventArgs e)
        {
            dataView();
        }
    }
}


/*public partial class Form1 : Form
{
    OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cbanez\source\repos\EmployeeTracker\dbtk.accdb");
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
            displayData.DataSource = dt;

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
    //void refresh()
    //{
    //    txtEmployeeID.Text = "";
    //    txtfName.Text = "";
    //    txtlName.Text = "";
    //    txtContact.Text = "";
    //    txtAge.Text = "";
    //    txtEmail.Text = "";
    //    txtrole.Text = "";
    //    chkActive.Checked = false;
    //}
    private void Form1_Load(object sender, EventArgs e)
    {
        dataView();
    }

    //opens modal form 2 for inserting data
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

    //private void btnView_Click(object sender, EventArgs e)
    //{
    //    dataView();
    //    //refresh();
    //}

    //Delete function
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

    //private void DisplayData_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //    try
    //    {
    //        // Get the selected row index
    //        int rowIndex = e.RowIndex;

    //        // Ensure a valid row is selected
    //        if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
    //        {
    //            // Update text fields
    //            txtEmployeeID.Text = displayData.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();
    //            txtfName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
    //            txtlName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
    //            txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
    //            txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
    //            txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();
    //            txtrole.Text = displayData.Rows[rowIndex].Cells["role"].Value.ToString();

    //            // Update checkbox state
    //            bool isActive = Convert.ToInt32(displayData.Rows[rowIndex].Cells["status"].Value) == 1;
    //            chkActive.Checked = isActive;

    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }

    //}

    //Exit method
    private void btnExit_Click(object sender, EventArgs e)
    {
        DialogResult leave;
        leave = MessageBox.Show("Confirm if you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (leave == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    //private void label1_Click(object sender, EventArgs e)
    //{

    //}

    //opens modal form 3 for updating data
    private void btnUpdate_Click(object sender, EventArgs e)
    {

        Form3 form3 = new Form3();

        //displays data to form3
        form3.txtEmployeeID.Text = displayData.CurrentRow.Cells["EmployeeID"].Value.ToString();
        form3.txtfName.Text = displayData.CurrentRow.Cells["fName"].Value.ToString();
        form3.txtlName.Text = displayData.CurrentRow.Cells["lName"].Value.ToString();
        form3.txtContact.Text = displayData.CurrentRow.Cells["contactNum"].Value.ToString();
        form3.txtAge.Text = displayData.CurrentRow.Cells["age"].Value.ToString();
        form3.txtEmail.Text = displayData.CurrentRow.Cells["email"].Value.ToString();
        form3.txtrole.Text = displayData.CurrentRow.Cells["role"].Value.ToString();

        // Update checkbox state
        bool isActive = Convert.ToInt32(displayData.CurrentRow.Cells["status"].Value) == 1;
        form3.chkActive.Checked = isActive;

        form3.DataUpdated += Form3_DataUpdated;
        form3.Show();
    }

    private void Form3_DataUpdated()
    {
        // Refresh or reload your DataGridView
        dataView(); // Assuming dataView() is the method that reloads the DataGridView
    }

    //private void displayData_CellClick(object sender, DataGridViewCellEventArgs e)
    //{
    //    try
    //    {
    //        // Get the selected row index
    //        int rowIndex = e.RowIndex;

    //        if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
    //        {
    //            txtEmployeeID.Text = displayData.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();
    //            txtfName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
    //            txtlName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
    //            txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
    //            txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
    //            txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();
    //            txtrole.Text = displayData.Rows[rowIndex].Cells["role"].Value.ToString();


    //            // Update checkbox state
    //            bool isActive = Convert.ToInt32(displayData.Rows[rowIndex].Cells["status"].Value) == 1;
    //            chkActive.Checked = isActive;
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}
    //private void txtContact_TextChanged(object sender, EventArgs e)
    //{
    //    if (txtContact.TextLength == 11)
    //    {
    //        txtContact.ForeColor = Color.Black;
    //    }
    //    else
    //    {
    //        txtContact.ForeColor = Color.Red;
    //    }


    //}

    //resets search bar when clicked
    private void textSearch_Click(object sender, EventArgs e)
    {
        textSearch.Text = "";
    }

    //Search method
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

    //Contact number requirement matching
    private void txtcontact_keypress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
            MessageBox.Show("error, contact number should only contain numbers");
        }
*/