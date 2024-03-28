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
            panel5.Controls.Add(userControl);
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
            AddTabs(tb);
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
                DataTable dt = new DataTable();

                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                EmployeeList.DataSource = dt;
                EmployeeList.Columns[1].HeaderText = "First Name";
                EmployeeList.Columns[2].HeaderText = "Last Name";
                this.EmployeeList.Columns[0].Visible = false;
                this.EmployeeList.Columns[3].Visible = false;
                this.EmployeeList.Columns[4].Visible = false;
                this.EmployeeList.Columns[5].Visible = false;
                this.EmployeeList.Columns[6].Visible = false;
                this.EmployeeList.Columns[7].Visible = false;
                this.EmployeeList.Columns[8].Visible = false;
                this.EmployeeList.Columns[9].Visible = false;
                //EmployeeList.DataSource = //dt.AsEnumerable().Select(obj => new {  }).ToList();

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

        //private void frmDashboard_Load(object sender, EventArgs e)
        //{
        //    employeeView();
        //}

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            employeeView();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbtkDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dbtkDataSet.Employee);

        }
    }
}
