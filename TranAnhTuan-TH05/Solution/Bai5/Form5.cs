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

namespace TranAnhTuan_TH05.Solution.Bai5
{
    public partial class Form5 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        public Form5()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_PMStore();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            try
            {
                List<SanPham> list = new List<SanPham>();
                conn.Open();
                string query = "select * from SanPham where SoLuongTon = 0 or NgayHetHan < GETDATE()";
                cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    SanPham sp = new SanPham();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
