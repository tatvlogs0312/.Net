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

namespace TranAnhTuan_TH05.Solution.Bai4
{
    public partial class Form4 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;

        public Form4()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_HH();
        }

        private void btbTim_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtMaLop.Text;
                List<BeNgoan> list = new List<BeNgoan>();
                conn.Open();
                string query = $"select * from BeNgoan , LopHoc where BeNgoan.MaLop = LopHoc.MaLop AND LopHoc.MaLop = '{maLop}'";
                cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    BeNgoan bn = new BeNgoan();
                    bn.MaBN = (string)rd["MaBN"];
                    bn.MaLop = (string)rd["MaLop"];
                    bn.TenBN = (string)rd["TenBeNgoan"];
                    bn.NgaySinh = (DateTime)rd["NgaySinh"];
                    bn.GioiTinh = (string)rd["GioiTinh"];
                    bn.HoTenBo = (string)rd["HoTenBo"];
                    bn.HoTenMe = (string)rd["HoTenMe"];
                    bn.DiaChi = (string)rd["DiaChi"];

                    list.Add(bn);
                }
                conn.Close();

                dgvDS.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
