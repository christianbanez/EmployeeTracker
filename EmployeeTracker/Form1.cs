using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class frmDashboard : Form
    {
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
