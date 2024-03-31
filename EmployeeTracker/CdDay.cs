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
       OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\source\repos\EmployeeTracker\dbtk.accdb");
        string _day, date, weekday;
        //List<string> tasks; // List to store tasks/events for the day

        //public void displayTask()
        //{
        //    try
        //    {
        //        // Use using statement for automatic disposal and better resource management
        //        using (conn)
        //        {
        //            conn.Open();
        //            using (OleDbCommand cmd = conn.CreateCommand())
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cmd.CommandText = "SELECT * FROM Schedule WHERE Date = ?";
        //                // Assuming 'Date' is a column name in your database
        //                cmd.Parameters.AddWithValue("date", tabCALENDAR._year + "-" + tabCALENDAR._month + "-" + lblDay.Text);

        //                using (OleDbDataReader reader = cmd.ExecuteReader())
        //                {
        //                    // Check if there are rows returned from the query
        //                    if (reader.HasRows)
        //                    {
        //                        // Read the first row (assuming only one result is expected)
        //                        reader.Read();
        //                        lblTask.Text = reader["event"].ToString();
        //                    }
        //                    else
        //                    {
        //                        lblTask.Text = "No task for this date.";
        //                    }
        //                }
        //            }
        //        }
        //    } 
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

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


        public CdDay(string day)
        {
            InitializeComponent();
            _day = day;
            lblDay.Text = day;
            checkBox1.Hide();

            date = tabCALENDAR._month + "/" + _day + "/" + tabCALENDAR._year;
        }

        private void CdDay_Load(object sender, EventArgs e)
        {
            //displayTask();
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
