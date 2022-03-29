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

namespace TranAnhTuanTh04.Solution.bai2
{
    public partial class frmSua : Form
    {
        Connect connectDB;
        SqlConnection conn;
        SqlCommand cmd;
        public frmSua()
        {
            InitializeComponent();
            connectDB = new Connect();
            conn = connectDB.Connect_DSCD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaCD = txtMaCD.Text;
                string TenCD = txtTenCD.Text;
                conn.Open();
                string query = $"UPDATE CongDan SET TenCD = N'{TenCD}' WHERE MaCD = '{MaCD}'";
                cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
