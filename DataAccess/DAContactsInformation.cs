using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DAContactsInformation
    {
        public static DataSet GetContactsUsingDBWithConfig()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsGetContactsReport = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["ContactsConnection_DEV"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from ContactDetails";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetContactsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetContactsReport;
        }
    }
}
