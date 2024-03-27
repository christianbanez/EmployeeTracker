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
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cbanez\source\repos\EmployeeTracker\dbtk.accdb");
        public frmDashboard()
        {
            InitializeComponent();
            tabOVERVIEW tb = new tabOVERVIEW();
            AddTabs(tb);
        }

        private void AddTabs(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            //panel5.Controls.Clear();
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
                this.EmployeeList.Columns["EmployeeID"].Visible = false;
                this.EmployeeList.Columns["contactNum"].Visible = false;
                this.EmployeeList.Columns["email"].Visible = false;
                this.EmployeeList.Columns["age"].Visible = false;
                this.EmployeeList.Columns["status"].Visible = false;
                this.EmployeeList.Columns["role"].Visible = false;
                this.EmployeeList.Columns["accDateCreated"].Visible = false;
                this.EmployeeList.Columns["accDateEnded"].Visible = false;
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

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            employeeView();
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeList form = new EmployeeList();
            form.Show();
        }

        /* private void panel5_Paint(object sender, PaintEventArgs e)
         {
             tabOVERVIEW1.Hide();
             tabTODAY1.Hide();
             tabCALENDAR1.Hide();
             tabTEAM1.Hide();
         }

         private void btnOverV_Click(object sender, EventArgs e)
         {
             tabTODAY1.Hide();
             tabCALENDAR1.Hide();
             tabTEAM1.Hide();

             tabOVERVIEW1.Show();
             tabOVERVIEW1.BringToFront();
         }

         private void btnToday_Click(object sender, EventArgs e)
         {
             tabOVERVIEW1.Hide();
             tabCALENDAR1.Hide();
             tabTEAM1.Hide();

             tabTODAY1.Show();
             tabTODAY1.BringToFront();
         }

         private void btnTeam_Click(object sender, EventArgs e)
         {
             tabOVERVIEW1.Hide();
             tabTODAY1.Hide();
             tabCALENDAR1.Hide();

             tabTEAM1.Show();
             tabTEAM1.BringToFront();
         }

         private void btnCalendar_Click(object sender, EventArgs e)
         {
             tabOVERVIEW1.Hide();
             tabTODAY1.Hide();
             tabTEAM1.Hide();

             tabCALENDAR1.Show();
             tabCALENDAR1.BringToFront();
         }*/
    }
}
