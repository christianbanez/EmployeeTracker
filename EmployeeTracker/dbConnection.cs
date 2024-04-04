using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace EmployeeTracker
{
    public class DbConnect
    {
        public string connectionStrings;
        //OleDbConnection connection = new OleDbConnection(connectionString);
        //connection.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\dkeh\source\repos\EmployeeTracker\dbtk.accdb";
        //public static readonly string ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\dkeh\\source\\repos\\EmployeeTracker\\dbtk.accdb");

        public DbConnection()
        {
            this.connectionStrings = ConfigurationManager.ConnectionStrings["Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\dkeh\source\repos\EmployeeTracker\dbtk.accdb"].ConnectionString;

            //ConnectionString = connectionString;
        }
        public void OpenConnection()
        {

            using dbConnection (OleDbConnection connection = new OleDbConnection(connectionStrings))
            {
                connection.Open();
                // Perform database operations here
            } // Connection is automatically closed when exiting the using block
        }
        public void CloseConnection()
        {

            using dbConnection (OleDbConnection connection = new OleDbConnection(connectionStrings))
            {
                connection.Close();
                // Perform database operations here
            } // Connection is automatically closed when exiting the using block
        }
    }
}
