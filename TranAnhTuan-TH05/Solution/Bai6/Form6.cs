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

namespace TranAnhTuan_TH05.Solution.Bai6
{
    public partial class Form6 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        
        public Form6()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_PMStore();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                List<Bai5.SanPham> list = new List<Bai5.SanPham>();
                string ncc = txtNCC.Text;
                conn.Open();
                string query = $"select* from SanPham where NhaCungCap like '%{ncc}%'";
                cmd = new SqlCommand(query,conn);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
