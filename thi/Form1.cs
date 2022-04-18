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

namespace thi
{
    public partial class Form1 : Form
    {
        Connect connect;
        SqlConnection conn;
        public Form1()
        {
            connect = new Connect();
            conn = connect.connection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdsim.Select();
            getData();
        }

        public void getData()
        {
            try
            {
                conn.Open();
                string query = "select * from Sim";
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Sim> list = new List<Sim>();
                while (rd.Read())
                {
                    Sim sim = new Sim();
                    sim.Id = (string)rd["ID"];
                    sim.SoSim = (string)rd["SoSim"];
                    sim.IdMang = (string)rd["MangId"];
                    sim.NKH = (DateTime)rd["NgayKichHoat"];
                    sim.NHH = (DateTime)rd["NgayHetHan"];
                    list.Add(sim);
                }
                conn.Close();

                dgvSim.DataSource = list;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdsim.Text;
                string soSim = txtSosim.Text;
                string idMang = txtMang.Text;
                string ngayKH = txtNKH.Text;
                string ngayHH = txtNHH.Text;
                if (id.Length == 0 || idMang.Length == 0)
                {
                    MessageBox.Show("Id và id mạng không được để trống");
                }

                else if (soSim.Length != 10 || kiemTra() == false)
                {
                    MessageBox.Show("Số sim không hợp lệ");
                    txtSosim.Text = "";
                    txtSosim.Select();
                }
                else
                {
                    conn.Open();
                    string query = $"insert into sim(id,soSim , mangId,ngayKichHoat,ngayHetHan) values " +
                        $"('{id}', '{soSim}', '{idMang}', '{ngayKH}', '{ngayHH}')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int sl = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (sl == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                conn.Close();
            }
            getData();
        }

        public bool kiemTra()
        {
            string soSim = txtSosim.Text;
            for(int i = 0; i < soSim.Length; i++)
            {
                if(soSim[i] < '0' || soSim[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
