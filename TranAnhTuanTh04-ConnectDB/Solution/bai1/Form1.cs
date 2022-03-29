using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using TranAnhTuanTh04.Solution;

namespace TranAnhTuanTh04
{
    public partial class frmDSCD : Form
    {
        Connect connectDB;
        SqlConnection conn;
        SqlCommand cmd;
        public frmDSCD()
        {
            InitializeComponent();
            connectDB = new Connect();
            conn = connectDB.Connect_DSCD();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaCD = txtMaCD.Text;
            string MaPhuong = txtMaPhuong.Text;
            string TenCD = txtTenCD.Text;
            string CMND = txtCMND.Text;
            string GioiTinh = txtGT.Text;
            int NamSinh = int.Parse(txtNS.Text);
            string SDT = txtSDT.Text;
            try
            {
                string query = $"INSERT INTO CongDan(MaCD,MaPhuong,TenCD,CMND,GioiTinh,NamSinh,SoDienThoai) VALUES ('{MaCD}','{MaPhuong}',N'{TenCD}','{CMND}','{GioiTinh}','{NamSinh}','{SDT}')";
                conn.Open();
                cmd = new SqlCommand(query,conn);
                int sl = cmd.ExecuteNonQuery();
                if(sl == 1)
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
