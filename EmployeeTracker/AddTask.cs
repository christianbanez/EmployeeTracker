using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class AddTask : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb");
        private string SelectedName { get; set; }
        public int SelectedID { get; set; }

        public AddTask(string selectedName, int selectedID)
        {
            InitializeComponent();

            lblSelectedName.Text = selectedName;
            lblSelectedID.Text = selectedID.ToString();
            SelectedID = selectedID;

            PopulateComboBox();
            LoadSchedules(); // Load schedules when form is initialized
        }
        private void LoadSchedules()
        {
            try
            {
                // Establish connection and query schedules for the selected employee ID
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb"))
                using (OleDbCommand command = new OleDbCommand("SELECT * FROM Schedule WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable scheduleTable = new DataTable();
                        adapter.Fill(scheduleTable);

                        // Bind the retrieved schedules to the DataGridView
                        dataGridViewSchedules.DataSource = scheduleTable;
                    }
                }
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb"))
                using (OleDbCommand command = new OleDbCommand("SELECT * FROM CTOearned WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable scheduleTable = new DataTable();
                        adapter.Fill(scheduleTable);

                        // Bind the retrieved schedules to the DataGridView
                        dataGridViewCTOearned.DataSource = scheduleTable;
                    }
                }
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb"))
                using (OleDbCommand command = new OleDbCommand("SELECT SUM(ctoRendered) AS TotalCTORendered FROM CTOearned WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    // Execute the query and get the total ctoRendered
                    object totalCTORendered = command.ExecuteScalar();

                    // Display the total in the text box
                    if (totalCTORendered != DBNull.Value)
                    {
                        txtTotalCTORendered.Text = totalCTORendered.ToString() + " Hours";
                    }
                    else
                    {
                        txtTotalCTORendered.Text = "0"; // If no value found, set to 0
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        //Combo Box query
        private void PopulateComboBox()
        {
            try
            {
                // Establish connection and query database
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb"))
                using (OleDbCommand command = new OleDbCommand("SELECT taskID, taskName AS employeetask FROM Task", connection))
                {
                    connection.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbxAssign.DataSource = dataTable;
                        cmbxAssign.DisplayMember = "employeetask";
                        cmbxAssign.ValueMember = "taskID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Assign to: combox Box Display
        private void cmbxAssign_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
            if (selectedRow != null)
            {
                string selectedItem = selectedRow["employeetask"].ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime timeIn = dateTimePickerTimeIn.Value;
            DateTime timeOut = dateTimePickerTimeOut.Value;

            if (cmbxAssign.SelectedItem != null)
            {
                DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
                if (selectedRow != null)
                {

                    // SelectedID is already assigned in the constructor
                    int taskID = Convert.ToInt32(selectedRow["taskID"]); // Retrieve taskID from the selectedRow

                    TimeSpan timeDifference = timeOut - timeIn;
                    double hoursNeeded = timeDifference.TotalHours / 10;
                    double timeDifference1 = timeDifference.TotalHours;
                    double ctoEarned = Math.Round(hoursNeeded, 2);
                    // Call method to insert task
                    InsertTask(timeIn, timeOut, taskID, ctoEarned, timeDifference1);
                }
            }
        }


        //inserting the values of the form into database
        private void InsertTask(DateTime timeIn, DateTime timeOut, int taskID, double ctoEarned, double timeDifference1)
        {
            try
            {
                // Establish connection and insert data
                connection.Open();
                using (OleDbCommand Cmd = connection.CreateCommand())
                {

                    //Console.WriteLine("Time Out: ", timeOut);
                    //Console.WriteLine("Hours needed: ", hoursNeeded);
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "INSERT INTO Schedule(timeIn, timeOut, EmployeeID, TaskID) VALUES (@timeIn, @timeOut, @EmployeeID, @TaskID)";
                    Cmd.Parameters.AddWithValue("@timeIn", timeIn.ToString("MM/dd/yyyy hh:mm:ss"));
                    Cmd.Parameters.AddWithValue("@timeOut", timeOut.ToString("MM/dd/yyyy hh:mm:ss"));
                    Cmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                    Cmd.Parameters.AddWithValue("@TaskID", taskID);

                    Cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Close the connection
                this.Close();
            }

            try
            {
                // Establish connection and insert data
                connection.Open();
                using (OleDbCommand Cmd = connection.CreateCommand())
                {

                    //Console.WriteLine("Time Out: ", timeOut);
                    //Console.WriteLine("Hours needed: ", hoursNeeded);
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "INSERT INTO CTOearned(dateEarned, ctoEarned, EmployeeID, ctoRendered) VALUES (@timeOut, @ctoEarned, @EmployeeID, @timeDifference1)";
                    Cmd.Parameters.AddWithValue("@timeOut", timeOut.ToString("MM/dd/yyyy hh:mm:ss"));
                    Cmd.Parameters.AddWithValue("@ctoEarned", ctoEarned);
                    Cmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                    Cmd.Parameters.AddWithValue("@timeDifference1", timeDifference1);
                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Task and schedule inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Close the connection
                this.Close();
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void useCTObtn_Click(object sender, EventArgs e)
        {
           
                UseCTO UseCTOForm = new UseCTO(SelectedID);
                UseCTOForm.Show();
            //useCTO.DataUpdated
            
        }
    }
}