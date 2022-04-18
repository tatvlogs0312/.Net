using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TranAnhTuan_TH05
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        Connect connect;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_DTDS();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                string TaiKhoan = txtTK.Text;
                string MatKhau = txtMK.Text;
                conn.Open();
                string query = $"select count(*) from Nguoidung where Taikhoan = '{TaiKhoan}' and Matkhau = '{MatKhau}'";
                cmd = new SqlCommand(query,conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Người dùng tồn tại");
                }
                else
                {
                    MessageBox.Show("Người dùng không tồn tại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
