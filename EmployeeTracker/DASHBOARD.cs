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
using System.Configuration;
using System.Data.Common;
using ClosedXML.Excel;

//using EmployeeTracker.dbConnection;

namespace EmployeeTracker
{
    public partial class frmDashboard : Form
    {
        GlobalConnection conn = new GlobalConnection();

        //OleDbConnection connection = new OleDbConnection();
        //conn.DbConnection();

        public frmDashboard()
        {
            InitializeComponent();
            tabOVERVIEW tb = new tabOVERVIEW();
            AddTabs(tb);

        }

        private void AddTabs(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelTabs.Controls.Add(userControl);
            //this.Location = new System.Drawing.Point(1000, 1000);
            panelCalPage.Hide();
            panel5.Show();
            userControl.BringToFront();
        }

        private void btnOverV_Click(object sender, EventArgs e)
        {
            tabOVERVIEW tb = new tabOVERVIEW();
            AddTabs(tb);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            tabTODAY tb = new tabTODAY();
            AddTabs(tb);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            tabCALENDAR tb = new tabCALENDAR();
            panelCalPage.Show();
            panel5.Hide();
            //tb.Show();
            //tb.Dock = DockStyle.Fill;
            //panelCalendar.Add(tb);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            tabTEAM tb = new tabTEAM();
            AddTabs(tb);
        }

        public void employeeView()
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {
                //getting values from database
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee";
                cmd.ExecuteNonQuery();
                //string fullName = EmployeeList.Columns[1].Value, EmployeeList.Columns[2].Value;

                DataTable dt = new DataTable();

                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                EmployeeList.DataSource = dt;

                this.EmployeeList.Columns[0].Visible = false;
                this.EmployeeList.Columns[1].Visible = false;
                this.EmployeeList.Columns[2].Visible = false;
                this.EmployeeList.Columns[3].Visible = false;
                this.EmployeeList.Columns[4].Visible = false;
                this.EmployeeList.Columns[5].Visible = false;
                this.EmployeeList.Columns[6].Visible = false;
                this.EmployeeList.Columns[7].Visible = false;
                this.EmployeeList.Columns[8].Visible = false;
                this.EmployeeList.Columns[9].Visible = false;
                this.EmployeeList.Columns[10].Visible = false;

                // EmployeeList.DataSource = dt.AsEnumerable().Select(obj => new {  }).ToList();

                // Create a new column for the concatenated names
                if (!dt.Columns.Contains("FullName"))
                {
                    // Add a new column for the concatenated full name
                    dt.Columns.Add("FullName", typeof(string));
                }
                foreach (DataRow row in dt.Rows)
                {
                    string firstName = row["fName"].ToString();
                    string lastName = row["lName"].ToString();

                    // Concatenate first name and last name with a space in between
                    string fullName = $"{firstName} {lastName}";

                    // Set the concatenated full name to the new column
                    row["FullName"] = fullName;
                }

                EmployeeList.DataSource = dt; // Bind the DataTable to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {  
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                EmployeeList1.DataSource = dt;
                this.EmployeeList1.Columns[0].Visible = false;
                this.EmployeeList1.Columns[1].Visible = false;
                this.EmployeeList1.Columns[2].Visible = false;
                this.EmployeeList1.Columns[3].Visible = false;
                this.EmployeeList1.Columns[4].Visible = false;
                this.EmployeeList1.Columns[5].Visible = false;
                this.EmployeeList1.Columns[6].Visible = false;
                this.EmployeeList1.Columns[7].Visible = false;
                this.EmployeeList1.Columns[8].Visible = false;
                this.EmployeeList1.Columns[9].Visible = false;
                this.EmployeeList1.Columns[10].Visible = false;
                this.EmployeeList1.Columns[11].Visible = false;
                this.EmployeeList1.Columns[12].Visible = false;
                this.EmployeeList1.Columns[13].Visible = false;
                // EmployeeList.DataSource = dt.AsEnumerable().Select(obj => new {  }).ToList();

                // Create a new column for the concatenated names
                if (!dt.Columns.Contains("FullName"))
                {
                    // Add a new column for the concatenated full name
                    dt.Columns.Add("FullName", typeof(string));
                }
                foreach (DataRow row in dt.Rows)
                {
                    string firstName = row["fName"].ToString();
                    string lastName = row["lName"].ToString();

                    // Concatenate first name and last name with a space in between
                    string fullName = $"{firstName} {lastName}";

                    // Set the concatenated full name to the new column
                    row["FullName"] = fullName;
                }

                EmployeeList1.DataSource = dt; // Bind the DataTable to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                connection.Close();
            }



        }

        private void btnCdOv_Click(object sender, EventArgs e)
        {
            tabOVERVIEW tb = new tabOVERVIEW();
            AddTabs(tb);
        }

        private void btnCdTd_Click(object sender, EventArgs e)
        {
            tabTODAY tb = new tabTODAY();
            AddTabs(tb);
        }

        private void btnCdTm_Click(object sender, EventArgs e)
        {
            tabTEAM tb = new tabTEAM();
            AddTabs(tb);
        }

        private void btnCdCd_Click(object sender, EventArgs e)
        {
            //tabCALENDAR tb = new tabCALENDAR();
            //panelCalPage.Show();
            //panel5.Hide();
            btnCalendar_Click(sender, e);
        }

        private EmployeeListCTO listCTO;

        private void EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listCTO != null && !listCTO.IsDisposed)
            {
                listCTO.Close();
            }

            listCTO = new EmployeeListCTO();
            listCTO.Show();
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EmployeeList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string selectedName = EmployeeList.CurrentRow.Cells["FullName"].Value.ToString();
                int selectedID = Convert.ToInt32(EmployeeList.CurrentRow.Cells["EmployeeID"].Value); // Assuming ID is the column name for ID

                Console.WriteLine("Selected Name: " + selectedName); // Debugging statement
                Console.WriteLine("Selected ID: " + selectedID); // Debugging statement

                EmployeeListCTO addTaskForm = new EmployeeListCTO(selectedName, selectedID);
                addTaskForm.ShowDialog();
            }
        }




        private void EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM Schedule";
                        DataTable dt = new DataTable();
                        OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                        dp.Fill(dt);

                        conn.Close();
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            workbook.Worksheets.Add(dt, "Schedule");
                            workbook.SaveAs(sfd.FileName);
                        }
                        MessageBox.Show("You have exported the data to an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}