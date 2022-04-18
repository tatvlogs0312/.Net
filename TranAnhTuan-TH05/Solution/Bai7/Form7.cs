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

namespace TranAnhTuan_TH05.Solution.Bai7
{
    public partial class Form7 : Form
    {
        SqlConnection conn;
        Connect connect;
        SqlCommand cmd;
        public Form7()
        {
            connect = new Connect();
            conn = connect.connect_PMStore();
            InitializeComponent();
        }

        public void getData()
        {
            try
            {
                List<Bai5.SanPham> list = new List<Bai5.SanPham>();
                conn.Open();
                string query = "select * from SanPham";
                cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Bai5.SanPham sp = new Bai5.SanPham();
                    sp.MaSanPham1 = (string)rd["MaSanPham"];
                    sp.TenSanPham1 = (string)rd["TenSanPham"];
                    sp.SoLuongTon1 = (int)rd["SoLuongTon"];
                    sp.NgaySanXuat1 = (DateTime)rd["NgaySanXuat"];
                    sp.NgayHetHan1 = (DateTime)rd["NgayHetHan"];
                    sp.NhaCungCap1 = (string)rd["NhaCungCap"];
                    list.Add(sp);
                }
                conn.Close();

                dgvSP.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "delete from SanPham where SoLuongTon = 0 or NgayHetHan < GETDATE()";
                cmd = new SqlCommand(query,conn);
                int sl = cmd.ExecuteNonQuery();
                conn.Close();
                if (sl == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}
