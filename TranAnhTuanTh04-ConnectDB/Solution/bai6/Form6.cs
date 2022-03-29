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

namespace TranAnhTuanTh04.Solution.bai6
{
    public partial class Form6 : Form
    {
        Connect connectDB;
        SqlConnection conn;
        SqlCommand cmd;
        public Form6()
        {
            connectDB = new Connect();
            conn = connectDB.Connect_HoaHong();
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaBN = txtMaBN.Text ;
            string MaLop = txtMaLop.Text;
            string TenBeNgoan = txtTenBN.Text;
            string NgaySinh = mtbNS.Text;
            string GioiTinh = txtGT.Text;
            string HoTenBo = txtBo.Text;
            string HoTenMe = txtMe.Text;
            string DiaChi = txtDiaChi.Text;
            string query = $"INSERT INTO BeNgoan (MaBN, MaLop, TenBeNgoan, NgaySinh, GioiTinh, HoTenBo, HoTenMe, DiaChi) VALUES" +
                                        $"('{MaBN}', '{MaLop}', '{TenBeNgoan}', '{NgaySinh}', '{GioiTinh}', '{HoTenBo}', '{HoTenMe}', '{DiaChi}')";

            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
