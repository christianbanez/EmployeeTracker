using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EmployeeTracker
{
    public partial class CdDay : UserControl
    {

        GlobalConnection conn = new GlobalConnection();
        //string _day, date;
        public Panel MyPanel { get { return panel1; } }
        public string selectedItem;
        //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\source\repos\EmployeeTracker\dbtk.accdb");
        string _day, date, weekday;
        //List<string> tasks; // List to store tasks/events for the day
        public void DisplayTask()
        {
            //OleDbConnection connection = new OleDbConnection(connection);
            try
            {
                OleDbConnection connection = new OleDbConnection(conn.conn);
                {
                    connection.Open();
                    using (OleDbCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Schedule.*, Task.taskName, Employee.fName, Employee.lName FROM Schedule, Task, Employee WHERE " +
                            "Schedule.taskId = Task.taskId " +
                            "AND Schedule.EmployeeID = Employee.EmployeeID " +
                            "AND Format(Schedule.plannedStart, 'M/D/yyyy') = ?";


                        // Format the date to match the format 'D/M/YYYY'
                        string formattedDate = $"{tabCALENDAR._month}/{_day.Trim()}/{tabCALENDAR._year}";
                        this.date = formattedDate;

                        cmd.Parameters.AddWithValue("date", formattedDate);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are rows returned from the query
                            if (reader.HasRows)
                            {
                                // Clear existing items in ListBox
                                listBox1.Items.Clear();

                                // Populate ListBox with task names
                                while (reader.Read())
                                {
                                    listBox1.Items.Add(reader["taskName"].ToString() + " - " + reader["fname"].ToString() + " " + reader["lName"].ToString());
                                }
                            }
                            else
                            {
                                listBox1.Items.Clear();
                                // Handle case where no tasks are found for the date
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

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
            listBox1.ClearSelected();
        }

        private AddTask addTask;

        //public void ReloadListBoxFromDatabase()
        //{
        //    // Connection string for your database

        //    // Query to retrieve data from the database
        //    string query = "SELECT Schedule.*, Task.taskName FROM Schedule, Task WHERE " +
        //                    "Schedule.taskId = Task.taskId " +
        //                    "AND Format(Schedule.timeIn, 'M/D/yyyy') = ?";

        //    using (conn)
        //    {
        //        // Open the connection
        //        conn.Open();

        //        // Create a command
        //        using (OleDbCommand command = new OleDbCommand(query, conn))
        //        {
        //            using (OleDbDataReader reader = command.ExecuteReader())
        //            {
        //                // Clear existing items in the ListBox
        //                listBox1.Items.Clear();

        //                // Read the data and add it to the ListBox
        //                while (reader.Read())
        //                {
        //                    listBox1.Items.Add(reader["taskName"].ToString());
        //                }
        //            }
        //        }

        //        conn.Close();
        //    }
        //}
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 155, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 155, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }

            int selectedIndex = listBox1.IndexFromPoint(e.Location);


            if (selectedIndex != ListBox.NoMatches || listBox1.Bounds.Contains(e.Location))
            {
                // If double-click occurred on a valid item
                if (selectedIndex != ListBox.NoMatches)
                {
                    // Get the selected item
                    selectedItem = listBox1.Items[selectedIndex].ToString();

                    // Call a method and pass the selected item as an argument
                    HandleDoubleClick(selectedItem);
                }
                else
                {
                    addTask = new AddTask(date,null,null);
                    addTask.pnlAssign.Show();
                    addTask.btnSvCal.Hide();
                    addTask.ShowDialog();
                }
            }

        }

        private void HandleDoubleClick(string selectedItem)
        {
            // Perform action based on the selected item
            //MessageBox.Show("Double-clicked on: " + selectedItem);

            // Checks if an item is selected
            if (listBox1.SelectedItem != null)
            {
                //MessageBox.Show("Item Found: " + selectedItem);
                // Retrieve the selected task name
                string selectedTask = listBox1.SelectedItem.ToString();
                selectedItem = listBox1.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    string taskName = parts[0]; // Contains "C# Coding"
                    string employeeName = parts[1]; // Contains "cruz jana"
                    addTask = new AddTask(date, taskName, employeeName);
                }

                addTask.pnlAssign.Show();
                addTask.pickDate1.Enabled = false;
                addTask.pickDate2.Enabled = false;
                addTask.btnAssign.Hide();
                addTask.ShowDialog();

            }
        }

        public CdDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;
            checkBox1.Hide();

            date = $"{tabCALENDAR._month.ToString().PadLeft(2, '0')}/{_day.Trim().PadLeft(2, '0')}/{tabCALENDAR._year}";
            date = Convert.ToString(date);
            //MessageBox.Show(date);
        }


        private void CdDay_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblDay.Text))
            {
                DisplayTask();
            }
        }
    }
}


//private void loadTasks()
//{


//    using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\source\repos\EmployeeTracker\dbtk.accdb"))
//    {
//        //adding values into database
//        conn.Open();
//        OleDbCommand cmd = conn.CreateCommand();
//        cmd.CommandType = CommandType.Text;
//        //cmd.CommandText = "SELECT * FROM Schedule WHERE Date = @timeIN";
//        //cmd.ExecuteNonQuery();
//        OleDbCommand command = new OleDbCommand("SELECT * FROM Schedule WHERE Date = @timeIN", conn);
//        command.Parameters.AddWithValue("@Date", date);
//        conn.Close();


//        try
//        {
//            conn.Open();
//            OleDbDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                tasks.Add(reader["Description"].ToString());
//            }
//            conn.Close();
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error loading tasks: " + ex.Message);
//            conn.Close();
//        }
//    }

//    // Update UI to display tasks/events
//    DisplayTasks();
//}

//// Method to display tasks/events on the user control
//private void DisplayTasks()
//{
//    // Clear any existing tasks displayed
//    panel1.Controls.Clear();

//    // Display tasks as labels within the panel
//    int yPos = 5;
//    foreach (var task in tasks)
//    {
//        Label taskLabel = new Label();
//        taskLabel.AutoSize = true;
//        taskLabel.Text = task;
//        taskLabel.Location = new Point(5, yPos);
//        panel1.Controls.Add(taskLabel);
//        yPos += taskLabel.Height + 5;
//    }
//}
