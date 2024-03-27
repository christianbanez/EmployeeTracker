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
    public partial class frmAddTask : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\jsantiago3\Downloads\dbtk.accdb");
        public frmAddTask()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbxAssign.Items.Clear(); 
            PopulateComboBox();

        }

        private void PopulateComboBox()
        {
            try
            {
                connection.Open();
                string query = "SELECT ID, Projects FROM Project";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("ID", typeof(int));
                dataTable.Columns.Add("Projects", typeof(string));
                dataTable.Rows.Add(-1, ""); 

                adapter.Fill(dataTable);

                cmbxAssign.DataSource = dataTable;
                cmbxAssign.DisplayMember = "Projects";
                cmbxAssign.ValueMember = "Projects";

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
                string selectedItem = selectedRow["Projects"].ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDesc = txtTaskDesc.Text;
            string project = "";

            if (cmbxAssign.SelectedItem != null)
            {
                DataRowView selectedRow = cmbxAssign.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    project = selectedRow["Projects"].ToString();
                }
            }
            else
            {
                project = cmbxAssign.Text.Trim(); 
                if (string.IsNullOrWhiteSpace(project))
                {
                    MessageBox.Show("Please select or enter a project.");
                    return;
                }

            }

            if (string.IsNullOrWhiteSpace(taskName) || string.IsNullOrWhiteSpace(taskDesc))
            {
                MessageBox.Show("Please enter task name and description.");
            }
            else
            {
                InsertTask(taskName, taskDesc, project);
            }
        }
        private void InsertTask(string taskName, string taskDesc, string project)
        {
            try
            {
                connection.Open();

                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "INSERT INTO Task (taskName, taskDesc, project) VALUES (@taskName, @taskDesc, @project)";
                cmd.Parameters.AddWithValue("@taskName", taskName); 
                cmd.Parameters.AddWithValue("@taskDesc", taskDesc); 

                if (project != null)
                    cmd.Parameters.AddWithValue("@project", project);
                else
                    cmd.Parameters.AddWithValue("@project", DBNull.Value); 

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to insert task.");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbxProj_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
