using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    class DbConnection
    {

        private static SqlConnection conn = null;

        public static SqlConnection getConnection()
        {
            string connectionString = @"Data Source=ABAYA-PC;Integrated Security=SSPI;Initial Catalog=enquirymanagement";
            conn = new SqlConnection (connectionString);
            return conn;
        }


    }
}
