using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TranAnhTuan_TH05
{
    class Connect
    {
        public SqlConnection connect_DTDS()
        {
            string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = DieuTraDS2; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }

        public SqlConnection connect_HH()
        {
            string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = HoaHong2; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }

        public SqlConnection connect_PMStore()
        {
            string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = PMStore; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }

        public SqlConnection connect_SimThe()
        {
            string con_str = "Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = SimThe; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(con_str);
            return conn;
        }
    }
}
