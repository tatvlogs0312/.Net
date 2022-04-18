using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo
{
    class Connect : Form
    {
        //private string svName = "LAPTOP-MEIFQ91P\\SQLEXPRESS";
        //private string dbName = "demo";
        //private string Security = "SSPI";
        private string con_str;
        SqlConnection conn;

        public Connect()
        {
            con_str = $"Data Source = LAPTOP-MEIFQ91P\\SQLEXPRESS; Initial Catalog = demo ; Integrated Security = SSPI";
            conn = new SqlConnection(con_str);
        }

        public void connect()
        {
            try
            {                         
                conn.Open();
                MessageBox.Show("Kết nối thành công");
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại : " + ex.Message);
            }          
        }

        public void addSV(string maSV , string tenSV , string lop)
        {
            conn.Open();
            string query = $"INSERT INTO sinhvien(MaSV,HoTenSV,Lop) VALUES (N'{maSV}',N'{tenSV}',N'{lop}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int sl = cmd.ExecuteNonQuery();
            if (sl == 1)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            conn.Close();
        }
    }
}
