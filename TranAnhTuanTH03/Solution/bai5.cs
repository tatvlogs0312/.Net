using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranAnhTuanTH03.Solution
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        int[] a;
        int n;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            a = new int[n];
            int dem = 0;
            n = int.Parse(textBox1.Text);
            if (button1.Enabled == true)
            {
                if (dem < n)
                {
                    a[dem] = int.Parse(textBox2.Text);
                    textBox3.Text += a[dem].ToString() + " ";
                    dem++;
                }
                if(dem >= n)
                {
                    MessageBox.Show("Nhập quá số phần tử của mảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
