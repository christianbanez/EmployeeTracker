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
    public partial class tabOVERVIEW : UserControl
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tdizon\source\repos\EmployeeTracker\dbtk.accdb");

        public tabOVERVIEW()
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
                cmd.CommandText = "SELECT * FROM Schedule";

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
        private void addTask_DataUpdated()
        {
            dataView(); //updates datagridview
        }


        private void btnTask_Click(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask("");
            addTask.DataUpdated += addTask_DataUpdated;
            addTask.pnlAssign.Hide();
            addTask.Show();
            //addTask.btnSave.Hide();
            //editTab.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            dataView();
        }
    }
}
