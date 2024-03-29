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
    public partial class frmDashboard : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\source\repos\EmployeeTracker\dbtk.accdb");
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
            panelCalendar.SendToBack();
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
            panelCalendar.BringToFront();
            //tb.Show();
            //tb.Dock = DockStyle.Fill;
            //panelCalendar.Add(tb);
        }

        private void btnTeam_Click(object sender, EventArgs e)
        {
            tabTEAM tb = new tabTEAM();
            AddTabs(tb);
        }

        void employeeView()
        {
            try
            {
                //adding values into database
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee";
                cmd.ExecuteNonQuery();
                //string fullName = EmployeeList.Columns[1].Value, EmployeeList.Columns[2].Value;

                DataTable dt = new DataTable ();

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
                this.EmployeeList.Columns[11].Visible = false;
                this.EmployeeList.Columns[12].Visible = false;
                this.EmployeeList.Columns[13].Visible = false;
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
                conn.Close();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            employeeView();
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
            tabCALENDAR tb = new tabCALENDAR();
            panelCalendar.Show();
        }
    }
}
