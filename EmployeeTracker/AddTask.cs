using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;


namespace EmployeeTracker
{
    public partial class AddTask : Form
    {
        private CdDay cd = new CdDay("");
        private string date;
        private string selectedItem;
        private string employeeName;
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        //dbConnection(OleDbConnection connection);
        GlobalConnection conn = new GlobalConnection();

        //OleDbConnection connection = new OleDbConnection();
        //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tdizon\source\repos\EmployeeTracker\dbtk.accdb");
        //public AddTask()
        //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\source\repos\EmployeeTracker\dbtk.accdb");
        public AddTask(string date, string selectedItem, string employeeName)
        {
            InitializeComponent();
            this.date = date;
            this.selectedItem = selectedItem;
            this.employeeName = employeeName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCmbxEmp();
            PopulateCmbxTask();

            if (pnlAssign.Visible)
            {
                DateTime dateDT;
                //dateDT = DateTime.ParseExact(date, "M/d/yyyy", CultureInfo.InvariantCulture);
                //date = dateDT.ToString("dd/MM/yyyy");
                MessageBox.Show(date);
                pickDate1.Value = DateTime.Parse(date);
                pickDate2.Value = DateTime.Parse(date);
                //MessageBox.Show(pickDate1.ToString() + pickDate2.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            InsertTask(taskName, taskDesc);
        }

        private void InsertTask(string taskName, string taskDesc /*int empID*/)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);

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
                OleDbConnection connection = new OleDbConnection(conn.conn);

                MessageBox.Show("Selected Item: " + selectedItem);
                if (selectedItem != null)
                {
                    connection.Open();
                    string selectedTask = selectedItem;

                    // Build the query dynamically
                    string query = "SELECT taskID, taskName FROM Task WHERE taskName = @taskName";

                    // Create a new instance of OleDbCommand
                    OleDbCommand command = new OleDbCommand(query, connection);

                    // Add parameter to the command
                    command.Parameters.AddWithValue("@taskName", selectedTask);

                    // Create OleDbDataAdapter and fill the DataTable
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the ComboBox
                    cmbxTask.DataSource = dataTable;
                    cmbxTask.DisplayMember = "taskName";
                    cmbxTask.ValueMember = "taskID";

                    connection.Close();
                }
                else
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
                OleDbConnection connection = new OleDbConnection(conn.conn);
                if (selectedItem != null)
                {
                    connection.Open();
                    // Split the employee name further into first name and last name
                    string[] names = employeeName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = "";
                    string lastName = "";

                    if (names.Length >= 2)
                    {
                        firstName = names[0];
                        lastName = string.Join(" ", names.Skip(1));
                        //MessageBox.Show("Values here: " + firstName + " " + lastName);
                    }
                    else if (names.Length == 1)
                    {
                        // Only one name provided, consider it as the first name
                        firstName = names[0]; // Contains "cruz"
                        lastName = ""; // No last name
                    }

                    // Build the query dynamically
                    string query = "SELECT lName, fName, EmployeeID FROM Employee WHERE fName = @fName AND lName = @lName";

                    // Create a new instance of OleDbCommand
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@fName", firstName);
                    command.Parameters.AddWithValue("@lName", lastName);

                    // Create OleDbDataAdapter and fill the DataTable
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataTable.Columns.Add("FullName", typeof(string), "fName + ' ' + lName");

                    // Bind the DataTable to the ComboBox
                    cmbxEmp.DataSource = dataTable;
                    cmbxEmp.DisplayMember = "FullName";
                    cmbxEmp.ValueMember = "EmployeeID";

                    connection.Close();
                }
                else 
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to refresh the panel
        public void RefreshPanel()
        {
            CdDay cd = new CdDay(""); // Create an instance of the form
            cd.MyPanel.Invalidate(); // Refresh the panel
            cd.MyPanel.Update();
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
                OleDbConnection connection = new OleDbConnection(conn.conn);


                // gets selected employee, task, date, and time
                int employeeID = Convert.ToInt32(cmbxEmp.SelectedValue);
                int taskID = Convert.ToInt32(cmbxTask.SelectedValue);
                DateTime startDate = pickDate1.Value.Date;
                DateTime endDate = pickDate2.Value.Date;
                TimeSpan? timeIn = chkTime.Checked ? pickTimeIn.Value.TimeOfDay : (TimeSpan?)null;
                TimeSpan? timeOut = chkTime.Checked ? pickTimeOut.Value.TimeOfDay : (TimeSpan?)null;

                // remove milliseconds from a TimeSpan
                TimeSpan RemoveMilliseconds(TimeSpan timeSpan)
                {
                    return new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }

                timeIn = chkTime.Checked ? RemoveMilliseconds(pickTimeIn.Value.TimeOfDay) : (TimeSpan?)null;
                timeOut = chkTime.Checked ? RemoveMilliseconds(pickTimeOut.Value.TimeOfDay) : (TimeSpan?)null;

                connection.Open();

                string timeInFormatted = startDate.ToString("MM/dd/yyyy") + " " + timeIn;
                string timeOutFormatted = endDate.ToString("MM/dd/yyyy") + " " + timeOut;

                OleDbCommand command = new OleDbCommand("INSERT INTO Schedule (EmployeeID, TaskID, TimeIn, TimeOut, PlannedStart, PlannedEnd) " +
                       "VALUES (@EmployeeID, @taskID, @timeIn, @timeOut, @plannedStart, @plannedEnd)");

                command.Connection = connection;

                command.Parameters.AddWithValue("@EmployeeID", employeeID);
                command.Parameters.AddWithValue("@taskID", taskID);
                command.Parameters.AddWithValue("@plannedStart", startDate);
                command.Parameters.AddWithValue("@plannedEnd", endDate);
                command.Parameters.AddWithValue("@timeIn", timeInFormatted ?? DBNull.Value.ToString());
                command.Parameters.AddWithValue("@timeOut", timeOutFormatted ?? DBNull.Value.ToString());

                MessageBox.Show(employeeID + " " + taskID + " " + timeInFormatted + " " + timeOutFormatted);
                //Application.Exit();

                command.ExecuteNonQuery();

                connection.Close();

                DataUpdated?.Invoke();

                MessageBox.Show("Assignment added successfully!");
                cd.listBox1.ClearSelected();
                RefreshPanel();         
                //cd.ReloadListBoxFromDatabase();
                this.Close();

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

        private void btnSvCal_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            OleDbCommand cmd = new OleDbCommand("SELECT Task.taskID FROM Task WHERE taskName = @taskName", connection);
            cmd.Parameters.AddWithValue("@taskName", selectedItem);
            //MessageBox.Show(selectedItem);

            connection.Open();
            object result = (Int32)cmd.ExecuteScalar();


            int taskID = 0;

            if (result != null)
            {
                taskID = Convert.ToInt32(result);
                //MessageBox.Show("Value of TaskID is = " + taskID);
                // Now you can use taskID variable as needed.
            }
            else
            {
                MessageBox.Show("No Tasks Found.");
            }

            //fetching taskID here

            int employeeID = Convert.ToInt32(cmbxEmp.SelectedValue);

            OleDbCommand cmdSc = new OleDbCommand("SELECT Schedule.ID FROM Schedule WHERE taskID = @taskID AND timeIn = @date AND EmployeeID = @employeeID", connection);
            DateTime dateTimeIn = DateTime.Parse(date);
            date = dateTimeIn.ToString("MM/dd/yyyy");
            cmdSc.Parameters.AddWithValue("@taskID", taskID);
            cmdSc.Parameters.AddWithValue("@date", date);
            cmdSc.Parameters.AddWithValue("@employeeID", employeeID);
            MessageBox.Show(taskID + " " + date + " " + employeeID);
            MessageBox.Show(date.ToString());


            object resultSc = cmdSc.ExecuteScalar();


            int scheduleID = 0;

            if (resultSc != null)
            {
                scheduleID = Convert.ToInt32(resultSc);
                //MessageBox.Show("ScheduleID = " +  scheduleID);
                //MessageBox.Show("Value of TaskID is = " + taskID);
                // Now you can use taskID variable as needed.
            }
            else
            {
                MessageBox.Show("No Schedules Found.");
            }

            //// gets selected employee, task, date, and time
            //int taskID = Convert.ToInt32(cmbxTask.SelectedValue);
            DateTime startDate = pickDate1.Value.Date;
            DateTime endDate = pickDate2.Value.Date;
            TimeSpan? timeIn = chkTime.Checked ? (TimeSpan?)pickTimeIn.Value.TimeOfDay : (TimeSpan?)null;
            TimeSpan? timeOut = chkTime.Checked ? (TimeSpan?)pickTimeOut.Value.TimeOfDay : (TimeSpan?)null;

            // remove milliseconds from a TimeSpan
            TimeSpan RemoveMilliseconds(TimeSpan timeSpan)
            {
                return new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            }

            timeIn = chkTime.Checked ? RemoveMilliseconds(pickTimeIn.Value.TimeOfDay) : (TimeSpan?)null;
            timeOut = chkTime.Checked ? RemoveMilliseconds(pickTimeOut.Value.TimeOfDay) : (TimeSpan?)null;

            string timeInFormatted = startDate.ToString("MM/dd/yyyy") + " " + timeIn;
            string timeOutFormatted = endDate.ToString("MM/dd/yyyy") + " " + timeOut;

            OleDbCommand command = new OleDbCommand("UPDATE Schedule " +
                            "SET TimeIn = @TimeIn, " +
                            "TimeOut = @TimeOut " +
                            "WHERE ID = @scheduleID", connection);

            command.Connection = connection;
            //command.Parameters.AddWithValue("@EmployeeID", employeeID);
            //command.Parameters.AddWithValue("@TaskID", taskID);
            //command.Parameters.AddWithValue("@StartDate", startDate);
            //command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@TimeIn", timeInFormatted ?? DBNull.Value.ToString());
            command.Parameters.AddWithValue("@TimeOut", timeOutFormatted ?? DBNull.Value.ToString());
            command.Parameters.AddWithValue("@scheduleID", scheduleID);

            //MessageBox.Show(scheduleID + " " + taskID + " " + timeInFormatted + " " + timeOutFormatted + "selected date: " + date);
            //Application.Exit();

            command.ExecuteNonQuery();

            connection.Close();

            DataUpdated?.Invoke();

            MessageBox.Show("Assignment saved successfully!");
            //cd.listBox1.ClearSelected();
            //cd.ReloadListBoxFromDatabase();
            this.Close();
        }
    }
}