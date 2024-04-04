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



namespace EmployeeTracker
{
    public partial class tabOVERVIEW : UserControl
    {
        //OleDbConnection connection = new OleDbConnection();
        GlobalConnection conn = new GlobalConnection();
       

        public tabOVERVIEW()
        {
            InitializeComponent();
        }

        //For updating datagridview
        void dataView()
        {
            
            try
            {
                OleDbConnection connection = new OleDbConnection(conn.conn);
                //adding values into database
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Schedule";

                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                displayData.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabOVERVIEW_Load(object sender, EventArgs e)
        {
            dataView();
        }
    }
}
