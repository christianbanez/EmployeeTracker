using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace EmployeeTracker
{
    public partial class EmployeeListCTO : Form
    {
        GlobalConnection conn = new GlobalConnection();
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        private string SelectedName { get; set; }

        private delegate void DEmpty();
        public void RefreshDataGrid()
        {
            this.Invoke(new DEmpty(dataGridViewCTOused.Refresh));
        }

        public int SelectedID { get; set; }

        public EmployeeListCTO(string selectedName, int selectedID)
        {
            InitializeComponent();

            lblSelectedName.Text = selectedName;
            lblSelectedID.Text = selectedID.ToString();
            SelectedID = selectedID;

            PopulateComboBox();
            LoadSchedules(); // Load schedules when form is initialized
        }
        public void LoadSchedules()
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {


                // Establish connection and query schedules for the selected employee ID

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
                    connection.Close();
                }
                //CTO EARNED

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
                        dataGridViewCTOearned.Columns["ID"].Visible = false;
                        dataGridViewCTOearned.Columns["employeeID"].Visible = false;
                        dataGridViewCTOearned.Columns["ctoRendered"].Visible = false;
                    }
                    connection.Close();
                }
                //CTO BALANCE

                using (OleDbCommand command = new OleDbCommand("SELECT ctoBalance AS totalCTOBalance FROM Employee WHERE EmployeeID = @EmployeeID", connection))

                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    // Execute the query and get the total ctoBalance and ctoEarned
                    object totalCTOBalance = command.ExecuteScalar();

                    string finalBalance = totalCTOBalance.ToString();
                    // Display the total in the text box
                    if (totalCTOBalance != DBNull.Value)
                    {
                        txtTotalCTOBalance.Text = finalBalance;
                    }
                    else
                    {
                        txtTotalCTOBalance.Text = "0"; // If no value found, set to 0
                    }
                    connection.Close();
                }
                //DISPLAY CTO USED TO GRIDVIEW

                using (OleDbCommand command = new OleDbCommand("SELECT * FROM CTOused WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable usedTable = new DataTable();
                        adapter.Fill(usedTable);

                        // Bind the retrieved balance to the DataGridView
                        dataGridViewCTOused.DataSource = usedTable;
                    }
                    connection.Close();
                }
                //CTO RENDERED

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
                    connection.Close();
                }
                //CTO BALANCE

                using (OleDbCommand command = new OleDbCommand("SELECT ctoBalance AS totalCTOBalance FROM Employee WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    // Execute the query and get the total ctoBalance and ctoEarned
                    object totalCTOBalance = command.ExecuteScalar();

                    string finalBalance = totalCTOBalance.ToString();
                    // Display the total in the text box
                    if (totalCTOBalance != DBNull.Value)
                    {
                        txtTotalCTOBalance.Text = finalBalance;
                    }
                    else
                    {
                        txtTotalCTOBalance.Text = "0"; // If no value found, set to 0
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadSchedules();

        }

        //Combo Box query
        private void PopulateComboBox()
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {
                // Establish connection and query database

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
            finally
            {
                connection.Close();
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
            OleDbConnection connection = new OleDbConnection(conn.conn);
            DateTime timeIn = dateTimePickerTimeIn.Value;
            DateTime timeOut = dateTimePickerTimeOut.Value;

            if (timeOut > timeIn)
            {
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
                        connection.Open();
                        OleDbCommand cmd = connection.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT ctoBalance AS totalBalance FROM Employee WHERE EmployeeID = @EmployeeID";
                        cmd.Parameters.AddWithValue("@EmployeeID", SelectedID);
                        object totalBalance = cmd.ExecuteScalar();
                        connection.Close();
                        double totalCTObalance = totalBalance == DBNull.Value ? 0.0 : Convert.ToDouble(totalBalance);

                        totalCTObalance += ctoEarned;
                        InsertTask(timeIn, timeOut, taskID, ctoEarned, timeDifference1, totalCTObalance); // Call method to insert task
                        LoadSchedules();
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid time inputted", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //inserting the values of the form into database
        private void InsertTask(DateTime timeIn, DateTime timeOut, int taskID, double ctoEarned, double timeDifference1, double totalCTObalance)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
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
            }
            try
            {
                connection.Open();
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Employee SET ctoBalance = @totalBalance WHERE EmployeeID = @EmployeeID";
                cmd.Parameters.AddWithValue("@totalBalance", totalCTObalance);
                cmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
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
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {

                using (OleDbCommand command = new OleDbCommand("SELECT ctoBalance AS totalCTOBalance FROM Employee WHERE EmployeeID = @EmployeeID", connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID);

                    // Execute the query and get the total ctoBalance and ctoEarned
                    object totalCTOBalance = command.ExecuteScalar();

                    string finalBalance = totalCTOBalance.ToString();
                    // Display the total in the text box
                    if (totalCTOBalance != DBNull.Value && finalBalance != "0")
                    {
                        UseCTO UseCTOForm = new UseCTO(SelectedID);
                        UseCTOForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please add cto first");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadSchedules();
        }

        private void exportButton_Click_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                // Set the default file name to the current ID
                sfd.FileName = $"{SelectedID}_Export.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dtExport = new DataTable();

                            connection.Open();

                            // Exporting data from CTOearned
                            OleDbCommand cmdEarned = connection.CreateCommand();
                            cmdEarned.CommandType = CommandType.Text;
                            cmdEarned.CommandText = "SELECT dateEarned, ctoEarned FROM CTOearned WHERE EmployeeID = @EmployeeID";
                            cmdEarned.Parameters.AddWithValue("@EmployeeID", SelectedID);
                            using (OleDbDataAdapter dpEarned = new OleDbDataAdapter(cmdEarned))
                            {
                                dpEarned.Fill(dtExport);
                            }

                            // Exporting data from CTOused
                            OleDbCommand cmdUsed = connection.CreateCommand();
                            cmdUsed.CommandType = CommandType.Text;
                            cmdUsed.CommandText = "SELECT dateUsed, ctoUsed FROM CTOused WHERE EmployeeID = @EmployeeID";
                            cmdUsed.Parameters.AddWithValue("@EmployeeID", SelectedID);
                            using (OleDbDataAdapter dpUsed = new OleDbDataAdapter(cmdUsed))
                            {
                                dpUsed.Fill(dtExport);
                            }

                            connection.Close();

                            workbook.Worksheets.Add(dtExport, "CTO Data");

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("You have exported the data to an excel file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}