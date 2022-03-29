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

namespace TranAnhTuanTh04.Solution.bai4
{
    public partial class frmXoa : Form
    {
        Connect connectDB;
        SqlConnection conn;
        SqlCommand cmd;
        public frmXoa()
        {
            InitializeComponent();
            connectDB = new Connect();
            conn = connectDB.Connect_DSCD();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaCD = txtMaCD.Text;
            string query = $"DELETE FROM CongDan WHERE MaCD = '{MaCD}'";
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                int sl = cmd.ExecuteNonQuery();
                if (sl == 1)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Mã không hợp lệ");
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
