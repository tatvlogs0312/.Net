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

namespace TranAnhTuanTh04.Solution.bai3
{
    public partial class frmSuaCMND : Form
    {
        Connect connectDB;
        SqlConnection conn;
        SqlCommand cmd;
        public frmSuaCMND()
        {
            InitializeComponent();
            connectDB = new Connect();
            conn = connectDB.Connect_DSCD();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaCD = txtMaCD.Text;
            string CMND = txtCMND.Text;
            try 
            {
                string query = $"UPDATE CongDan SET CMND = '{CMND}' WHERE MaCD = '{MaCD}'";
                conn.Open();
                cmd = new SqlCommand(query,conn);
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
