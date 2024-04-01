using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeTracker
{
    public partial class UseCTO : Form
    {
        public int SelectedID { get; set; }
        public UseCTO(int selectedID)
        {
            InitializeComponent();
            SelectedID = selectedID;
            Console.WriteLine("Selected ID: ", selectedID);
        }
        
        private void useCTOsave_Click(object sender, EventArgs e)
        {
            DateTime dateCTOused = datetimepickerUseDate.Value;
            int inputCTO;

            using (OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\asantocildes\source\repos\EmployeeTracker\dbtk.accdb"))

            try
            {
                    connection.Open();
                    using (OleDbCommand Cmd = connection.CreateCommand())
                    {
                        Cmd.CommandType = CommandType.Text;
                        Cmd.CommandText = "INSERT INTO CTOused(dateUsed, ctoUsed, EmployeeID) VALUES (@dateCTOused, @inputCTO, @EmployeeID)";
                        Cmd.Parameters.AddWithValue("@dateUsed", dateCTOused.ToString("MM/dd/yyyy hh:mm:ss"));
                        Cmd.Parameters.AddWithValue("@ctoUsed", inputCTO);
                        Cmd.Parameters.AddWithValue("@EmployeeID", SelectedID); // Use the selected ID
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


            




        }
    }
}
