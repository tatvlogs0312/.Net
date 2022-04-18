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

namespace TranAnhTuan_TH05.Solution.Bai8
{
    public partial class TheSim : Form
    {
        Connect connect;
        SqlConnection conn;
        SqlCommand cmd;
        public TheSim()
        {
            connect = new Connect();
            conn = connect.connect_SimThe();
            InitializeComponent();
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            try
            {
                string soSim = txtSo.Text;
                conn.Open();
                string query = $"select id , NgayHetHan from Sim where SoSim = '{soSim}'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach(DataRow row in dt.Rows)
                {
                    MessageBox.Show("Mã : " + (string)row["id"] + " - Ngày hết hạn : " + (DateTime)row["NgayHetHan"]);
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
