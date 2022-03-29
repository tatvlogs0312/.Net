using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TranAnhTuanTh04.Solution.bai5
{
    
    public partial class Form5 : Form
    {
        Connect connectDB;
        SqlConnection conn;
        public Form5()
        {
            InitializeComponent();
            connectDB = new Connect();
            conn = connectDB.Connect_HoaHong();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string MaLop = txtMaLop.Text;
                string query = $"DELETE FROM LopHoc WHERE MaLop = '{MaLop}'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Mã không hợp lệ");
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
