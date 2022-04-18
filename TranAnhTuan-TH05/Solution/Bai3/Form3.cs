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

namespace TranAnhTuan_TH05.Solution.Bai3
{
    public partial class Form3 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        public Form3()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_DTDS();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Bai2.CongDan> list = new List<Bai2.CongDan>();
                string cmnd = txtCMND.Text;
                conn.Open();
                string query = $"select * from CongDan where CMND = '{cmnd}'";
                cmd = new SqlCommand(query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Bai2.CongDan congDan = new Bai2.CongDan();
                    congDan.MaCD = (string)rd["MaCD"];
                    congDan.TenCD = (string)rd["TenCD"];
                    congDan.Cmnd = (string)rd["CMND"];
                    congDan.Gioitinh = (string)rd["GioiTinh"];
                    congDan.Namsinh = (int)rd["NamSinh"];
                    congDan.Sdt = (string)rd["SoDienThoai"];
                    list.Add(congDan);
                }
                conn.Close();

                dgvCongDan.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
