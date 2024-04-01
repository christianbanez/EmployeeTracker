using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EmployeeTracker
{
    public partial class CdDay : UserControl
    {
       OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tdizon\source\repos\EmployeeTracker\dbtk.accdb");
        string _day, date, weekday;
        //List<string> tasks; // List to store tasks/events for the day

        public void DisplayTask()
        {
            try
            {
                // Assuming 'conn' is your OleDbConnection object
                using (conn)
                {
                    conn.Open();
                    using (OleDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT Schedule.*, Task.taskName FROM Schedule, Task WHERE " +
                            "Schedule.taskId = Task.taskId " +
                            "AND Format(Schedule.timeIn, 'D/M/YYYY') = ?";


                        // Format the date to match the format 'D/M/YYYY'
                        string formattedDate = $"{_day.Trim()}/{tabCALENDAR._month}/{tabCALENDAR._year}";
                        cmd.Parameters.AddWithValue("date", formattedDate);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are rows returned from the query
                            if (reader.HasRows)
                            {
                                List<string> taskNames = new List<string>();

                                // Iterate through the reader and collect task names
                                while (reader.Read())
                                {
                                    taskNames.Add(reader["taskName"].ToString());
                                }

                                // Display the task names as a comma-separated list
                                lblTask.Text = string.Join(", ", taskNames);
                            }
                            else
                            {
                                //lblTask.Text = formattedDate;
                                //lblTask.Text = formattedDate;
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
        }

        private void lblTask_Click(object sender, EventArgs e)
        {

        }

        public CdDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;
            checkBox1.Hide();

            date = $"{_day.Trim()}/{tabCALENDAR._month}/{tabCALENDAR._year}";
            date = Convert.ToString(date);
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
