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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int kq = (int)Math.Sqrt(a);
            if (kq * kq == a)
            {
                label1.Text = textBox1.Text + " la so chinh phuong";
            }
            else
            {
                label1.Text = textBox1.Text + " khong phai la so chinh phuong";
            }
        }
    }
}
