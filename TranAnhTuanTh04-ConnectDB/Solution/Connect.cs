using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TranAnhTuanTh04.Solution
{
    class Connect
    {
        private string con_str;
        SqlConnection conn;

        public SqlConnection Connect_DSCD()
        {
                con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = DieuTraDS ; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                return conn;
        }

        public SqlConnection Connect_HoaHong()
        {
                con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS ; Initial Catalog = HoaHong ; Integrated Security = SSPI";
                conn = new SqlConnection(con_str);
                return conn;           
        }
    }
}
