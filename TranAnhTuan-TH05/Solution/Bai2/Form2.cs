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

namespace TranAnhTuan_TH05.Solution.Bai2
{
    public partial class Form2 : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
            connect = new Connect();
            conn = connect.connect_DTDS();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                List<CongDan> list = new List<CongDan>();
                conn.Open();
                string query = "select * from CongDan order by TenCD asc";
                cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    CongDan congDan = new CongDan();
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
