using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class AddTask : Form
    {
        private string date;
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\4. OJT\Jazmine\EmployeeTracker\dbtk.accdb");
        public AddTask(string date)
        {
            InitializeComponent();
            this.date = date;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCmbxEmp();
            PopulateCmbxTask();
            pickDate1.Value = DateTime.Parse(date);
            pickDate2.Value = DateTime.Parse(date);
        }

        //private void PopulateComboBox()
        //{
        //    try
        //    {
        //        connection.Open();
        //        string query = "SELECT EmployeeID, fName FROM Employee";
        //        OleDbCommand command = new OleDbCommand(query, connection);
        //        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
        //        DataTable dataTable = new DataTable();
        //        adapter.Fill(dataTable);
        //        cmbxAssign.DataSource = dataTable;
        //        cmbxAssign.DisplayMember = "fName";
        //        cmbxAssign.ValueMember = "EmployeeID";
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}

        //private void cmbxAssign_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
        //    if (selectedRow != null)
        //    {
        //        string selectedItem = selectedRow["fname"].ToString();
        //    }
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            InsertTask(taskName, taskDesc);
        }

        private void InsertTask(string taskName, string taskDesc /*int empID*/)
        {
            try
            {
                connection.Open();

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO Task (taskName, taskDesc) VALUES (@taskName, @taskDesc)";

                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@taskDesc", taskDesc);
                //cmd.Parameters.AddWithValue("@taskStartDate", taskStartDate);
                //cmd.Parameters.AddWithValue("@taskEndDate", taskEndDate);
                //cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

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
        private void chkTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTime.Checked)
            {
                pnlTime.Visible = true;
            }
            else
            {
                pnlTime.Visible = false;
            }
        }
        private void PopulateCmbxTask()
        {
            try
            {
                connection.Open();
                string query = "SELECT taskID, taskName FROM Task";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbxTask.DataSource = dataTable;
                cmbxTask.DisplayMember = "taskName";
                cmbxTask.ValueMember = "taskID";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void PopulateCmbxEmp()
        {
            try
            {
                connection.Open();
                string query = "SELECT EmployeeID, fName FROM Employee";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbxEmp.DataSource = dataTable;
                cmbxEmp.DisplayMember = "fName";
                cmbxEmp.ValueMember = "EmployeeID";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbxAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbxEmp.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedItem = selectedRow["fname"].ToString();
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve selected employee, task, date, and time (if applicable)
                int employeeID = Convert.ToInt32(cmbxEmp.SelectedValue);
                int taskID = Convert.ToInt32(cmbxTask.SelectedValue); 
                DateTime startDate = pickDate1.Value.Date;
                DateTime endDate = pickDate2.Value.Date;
                TimeSpan? timeIn = chkTime.Checked ? (TimeSpan?)pickTimeIn.Value.TimeOfDay : (TimeSpan?)null;
                TimeSpan? timeOut = chkTime.Checked ? (TimeSpan?)pickTimeOut.Value.TimeOfDay : (TimeSpan?)null;

                // Method to remove milliseconds from a TimeSpan
                TimeSpan RemoveMilliseconds(TimeSpan timeSpan)
                {
                    return new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }

                timeIn = chkTime.Checked ? RemoveMilliseconds(pickTimeIn.Value.TimeOfDay) : (TimeSpan?)null;
                timeOut = chkTime.Checked ? RemoveMilliseconds(pickTimeOut.Value.TimeOfDay) : (TimeSpan?)null;


                // Open the OleDbConnection
                connection.Open();

                string scheduledDate = $"{startDate.ToString("dd/MM/yyyy")} - {endDate.ToString("dd/MM/yyyy")}";

                string timeInFormatted = startDate.ToString("dd/MM/yyyy") + " " + timeIn;
                string timeOutFormatted = endDate.ToString("dd/MM/yyyy") + " " + timeOut;

                // Create an OleDbCommand object with the INSERT query and the OleDbConnection
                OleDbCommand command = new OleDbCommand("INSERT INTO Schedule (EmployeeID, TaskID, TimeIn, TimeOut) " +
                       "VALUES (@EmployeeID, @TaskID, @TimeIn, @TimeOut)");

                command.Connection = connection;

                // Add parameters to the command
                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@TaskID", taskID);
               // command.Parameters.AddWithValue("@ScheduledDate", scheduledDate);
                command.Parameters.AddWithValue("@TimeIn", timeInFormatted ?? DBNull.Value.ToString());
                command.Parameters.AddWithValue("@TimeOut", timeOutFormatted ?? DBNull.Value.ToString());

                // Execute the command to perform the insertion
                command.ExecuteNonQuery();

                // Close the OleDbConnection
                connection.Close();

                // Optionally, raise the DataUpdated event to notify subscribers that the data has been updated
                DataUpdated?.Invoke();

                MessageBox.Show("Assignment added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}