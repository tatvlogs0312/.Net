using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1___WindowsForms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            //this.textBox2.PasswordChar = '*';
            this.txtMatKhau.UseSystemPasswordChar = true;
        }

        frmMain frm;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập vào hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            //MessageBox.Show($"Tai Khoan: {txtTaiKhoan}, Mat Khau: {txtMatKhau}");
            if(TaiKhoan == "admin" && MatKhau == "123")
            {
                frm = new frmMain();

                //this.Hide();
                //frm.ShowDialog();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // or
            //this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowPasswword.Checked == true)
            {
                txtMatKhau.PasswordChar = ' ';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    frm.Close();
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    frm.Hide();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    frm.Show();
        //}

        //private void frmDangNhap_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Giao diện đang được thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("Giao diện đang được đóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
    }
}
