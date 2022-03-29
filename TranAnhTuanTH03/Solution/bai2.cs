using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranAnhTuanTH03
{
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);

            if (a == 0)
            {
                if(b == 0)
                {
                    textBox3.Text = "Phương trinh vo so nghiem";
                }
                else
                {
                    textBox3.Text = "Phương trinh vo nghiem";
                }
            }
            else
            {
                float x = -b / a;
                textBox3.Text = "" + (x);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
