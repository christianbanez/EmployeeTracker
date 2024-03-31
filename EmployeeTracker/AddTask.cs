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
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jesse\Downloads\dbtk.accdb");
        private string SelectedName { get; set; }
        public int SelectedID { get; private set; }

        public AddTask(string selectedName, int selectedID)
        {
            InitializeComponent();

            lblSelectedName.Text = selectedName;
            lblSelectedID.Text = selectedID.ToString();
            SelectedID = selectedID;

            PopulateComboBox();
            LoadSchedules(); // Load schedules when form is initialized
        }

        private void AddTask_Load(object sender, EventArgs e)
        {
            // Debugging statement to ensure the method is called
            Console.WriteLine("Selected ID: " + SelectedID);



            PopulateComboBox();
        }

        private void LoadSchedules()
        {
            try
            {
                // Establish connection and query schedules for the selected employee ID
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jesse\Downloads\dbtk.accdb"))
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
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jesse\Downloads\dbtk.accdb"))
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
            if (cmbxAssign.SelectedItem != null)
            {
                DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    int taskID = Convert.ToInt32(selectedRow["taskID"]);
                    DateTime timeIn = dateTimePickerTimeIn.Value;
                    DateTime timeOut = dateTimePickerTimeOut.Value;

                    // Call method to insert task
                    InsertTask(taskID, timeIn, timeOut);
                }
            }
        }


        //inserting the values of the form into database
        private void InsertTask(int taskID, DateTime timeIn, DateTime timeOut)
        {
            try
            {
                // Establish connection and insert data
                using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jesse\Downloads\dbtk.accdb"))
                using (OleDbCommand scheduleCmd = connection.CreateCommand())
                {
                    connection.Open();

                    scheduleCmd.CommandType = CommandType.Text;
                    scheduleCmd.CommandText = "INSERT INTO Schedule (timeIn, timeOut, EmployeeID, TaskID) VALUES (@timeIn, @timeOut, @EmployeeID, @TaskID)";
                    scheduleCmd.Parameters.AddWithValue("@timeIn", timeIn);
                    scheduleCmd.Parameters.AddWithValue("@timeOut", timeOut);
                    scheduleCmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                    scheduleCmd.Parameters.AddWithValue("@TaskID", taskID);
                    scheduleCmd.ExecuteNonQuery();

                    MessageBox.Show("Task and schedule inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
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
    }
}