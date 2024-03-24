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
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmployeeTracker
{
     public partial class Form3 : Form
    {
        public delegate void DataUpdatedEventHandler();
        public event DataUpdatedEventHandler DataUpdated;
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Jazmine Dizon\Downloads\dbtk.accdb");
        int state;
        public Form3()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string eMailchecker)
        {
            bool result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMailchecker);

                result = (eMailchecker.LastIndexOf(".") > eMailchecker.LastIndexOf("@"));
            }
            catch
            {
                result = false;
            };

            return result;
        }

        //private void DisplayData_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        // Get the selected row index
        //        int rowIndex = e.RowIndex;

        //        // Ensure a valid row is selected
        //        if (rowIndex >= 0 && rowIndex < displayData.Rows.Count)
        //        {
        //            // Update text fields
        //            txtEmployeeID.Text = displayData.Rows[rowIndex].Cells["EmployeeID"].Value.ToString();
        //            txtlName.Text = displayData.Rows[rowIndex].Cells["fName"].Value.ToString();
        //            txtfName.Text = displayData.Rows[rowIndex].Cells["lName"].Value.ToString();
        //            txtContact.Text = displayData.Rows[rowIndex].Cells["contactNum"].Value.ToString();
        //            txtAge.Text = displayData.Rows[rowIndex].Cells["age"].Value.ToString();
        //            txtEmail.Text = displayData.Rows[rowIndex].Cells["email"].Value.ToString();
        //            txtrole.Text = displayData.Rows[rowIndex].Cells["role"].Value.ToString();

        //            // Update checkbox state
        //            bool isActive = Convert.ToInt32(displayData.Rows[rowIndex].Cells["status"].Value) == 1;
        //            chkActive.Checked = isActive;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}
        //Form1 form = new Form1();
        //form.Show();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Use class-level variable
                int state = chkActive.Checked ? 1 : 0;

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Employee SET fName = @fName, lName = @lName, contactNum = @contact, age = @age, email = @email, status = @status WHERE EmployeeID = @employeeID";

                // Parameters
                cmd.Parameters.AddWithValue("@fName", txtlName.Text);
                cmd.Parameters.AddWithValue("@lName", txtfName.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@status", state);
                cmd.Parameters.AddWithValue("@employeeID", txtEmployeeID.Text);


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated in Database", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Employee ID not found or no changes made", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();

                //dataView();
                //refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
