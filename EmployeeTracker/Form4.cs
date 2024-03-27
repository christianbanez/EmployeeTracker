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
    public partial class Form4 : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\asantocildes\OneDrive - Infor\Desktop\dbtk.accdb""");
        int state;
        
        public Form4()
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
                displayTimeLogs.DataSource = dt;
                
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
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbtkDataSet.Schedule' table. You can move, or remove it, as needed.
            //this.scheduleTableAdapter.Fill(this.dbtkDataSet.Schedule);
            dataView();
        }

        //inserting details to the database and reflecting on the data grid view
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Schedule(timeIn, timeOut)VALUES(@timeIn, @timeOut)";
                cmd.Parameters.AddWithValue("@timeIn", dateTimeIn.Value.ToString());
                cmd.Parameters.AddWithValue("@timeOut", dateTimeOut.Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Time saved in Database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
            finally
            {

                conn.Close();
                dataView();
            }
   
        }
    }
}
