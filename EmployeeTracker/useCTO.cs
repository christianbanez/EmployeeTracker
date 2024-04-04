using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class UseCTO : Form
    {
        GlobalConnection conn = new GlobalConnection();
        public int SelectedID { get; set; }
        private EmployeeListCTO addtask;
        public UseCTO(int selectedID)
        {
            InitializeComponent();
            SelectedID = selectedID;
            Console.WriteLine("Selected ID: ", selectedID);

        }
        private void UseCTO_Load(object sender, EventArgs e)
        {


        }
        private void useCTOsave_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            DateTime dateCTOused = datetimepickerUseDate.Value;


            try
            {
                if (useCTOtxt.Text != "")
                {
                    double inputCTO = Convert.ToDouble(useCTOtxt.Text);
                    if (inputCTO != 0 || inputCTO != 0.0)
                    {


                        {
                            connection.Open();

                            OleDbCommand command = connection.CreateCommand();
                            command.CommandType = CommandType.Text;
                            command.CommandText = "SELECT SUM(ctoEarned) AS TotalCTOearned FROM CTOearned WHERE EmployeeID = @EmployeeID";
                            command.Parameters.AddWithValue("@EmployeeID", SelectedID);
                            object TotalCTOearned = command.ExecuteScalar();

                            OleDbCommand cmd = connection.CreateCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "SELECT SUM(ctoUsed) AS TotalCTOused FROM CTOused WHERE EmployeeID = @EmployeeID";
                            cmd.Parameters.AddWithValue("@EmployeeID", SelectedID);
                            object TotalCTOused = cmd.ExecuteScalar();

                            double totalEarned = TotalCTOearned == DBNull.Value ? 0.0 : Convert.ToDouble(TotalCTOearned);
                            double totalUsed = TotalCTOused == DBNull.Value ? 0.0 : Convert.ToDouble(TotalCTOused);


                            if (totalEarned >= (inputCTO + totalUsed))
                            {
                                double totalBalance = totalEarned - (inputCTO + totalUsed);
                                InsertUsed(dateCTOused, inputCTO, totalBalance);
                                //testform.RefreshDataGrid();


                            }
                            else
                            {
                                MessageBox.Show("Error: CTO earned is not enough to be used", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error: CTO earned is not enough to be used", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Please input number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void InsertUsed(DateTime dateCTOused, double inputCTO, double totalBalance)
        {
            OleDbConnection connection = new OleDbConnection(conn.conn);
            try
            {
                connection.Open();
                using (OleDbCommand Cmd = connection.CreateCommand())
                {
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "INSERT INTO CTOused(dateUsed, ctoUsed, EmployeeID) VALUES (@dateCTOused, @ctoUsed, @EmployeeID)";
                    Cmd.Parameters.AddWithValue("@dateCTOused", dateCTOused.ToString("MM/dd/yyyy hh:mm:ss"));
                    Cmd.Parameters.AddWithValue("@ctoUsed", inputCTO);
                    Cmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                    Cmd.ExecuteNonQuery();
                }
                using (OleDbCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE Employee SET ctoBalance = @totalBalance WHERE EmployeeID = @EmployeeID";
                    command.Parameters.AddWithValue("@totalBalance", totalBalance);
                    command.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("CTO has been used by the employee");

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

        private void useCTOtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
