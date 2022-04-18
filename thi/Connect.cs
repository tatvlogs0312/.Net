using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace thi
{
    class Connect
    {
        public SqlConnection connection()
        {
            string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog =  SimThe; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }

    }
}
