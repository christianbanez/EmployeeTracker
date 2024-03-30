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
    public partial class CdDay : UserControl
    {
        string _day, date, weekday;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255,155,79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        public CdDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;
            checkBox1.Hide();

            date = tabCALENDAR._month + "/" + _day + "/" + tabCALENDAR._year;
        }

        private void CdDay_Load(object sender, EventArgs e)
        {

        }
    }
}
