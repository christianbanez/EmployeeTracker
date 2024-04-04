using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace EmployeeTracker
{
    public class GlobalConnection
    {
        public string connectionStrings = ConfigurationManager.ConnectionStrings["ConnectionName"].ConnectionString;
        public string connection;
        //OleDbConnection connection = new OleDbConnection(connectionString);
        //connection.connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\dkeh\source\repos\EmployeeTracker\dbtk.accdb";
        //public static readonly string ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\dkeh\\source\\repos\\EmployeeTracker\\dbtk.accdb");
        public string conn
        {
            get { return connectionStrings; }
        }
        public void OpenConnection()
        {

            using (OleDbConnection connection = new OleDbConnection(connectionStrings))
            {
                connection.Open();
                // Perform database operations here
            } // Connection is automatically closed when exiting the using block
        }
        public void CloseConnection()
        {

            using (OleDbConnection connection = new OleDbConnection(connectionStrings))
            {
                connection.Close();
                // Perform database operations here
            } // Connection is automatically closed when exiting the using block
        }
        //public string Connection()
        //{
        //    using (OleDbConnection connection = new OleDbConnection(connectionStrings))
        //    {
        //        return connection;
        //    }
        //}
    }
}
