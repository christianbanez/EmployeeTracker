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
    public partial class AddTask : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Christian\source\repos\EmployeeTracker\dbtk.accdb");
        public AddTask()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT EmployeeID, fName FROM Employee";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbxAssign.DataSource = dataTable;
                cmbxAssign.DisplayMember = "fName";
                cmbxAssign.ValueMember = "EmployeeID";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbxAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedItem = selectedRow["fname"].ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            DateTime taskStartDate = dateTimePickerStartDate.Value;
            DateTime taskEndDate = dateTimePickerEndDate.Value;

            // Calculate hours needed
            if (cmbxAssign.SelectedItem != null)
            {
                DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    

                    int employeeID = Convert.ToInt32(selectedRow["EmployeeID"]);

                    InsertTask(taskStartDate, taskEndDate, employeeID);
                 
                }
            }
        }

        private void InsertTask(DateTime taskStartDate, DateTime taskEndDate, int employeeID)
        {
            try
            {
                connection.Open();

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                TimeSpan timeDifference = taskEndDate - taskStartDate;
                double hoursNeeded = timeDifference.TotalHours / 10;

                cmd.CommandText = "INSERT INTO Schedule(timeIn, timeOut, EmployeeID, EmployeeID.ctoEarned) VALUES(@taskStartDate, @taskEndDate, @EmployeeID, @hoursNeeded)";
                cmd.Parameters.AddWithValue("@taskStartDate", taskStartDate);
                cmd.Parameters.AddWithValue("@taskEndDate", taskEndDate);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@hoursNeeded", hoursNeeded);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Task inserted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            connection.Close();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}