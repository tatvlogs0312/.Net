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
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    float a = float.Parse(textBox1.Text);
                    float b = float.Parse(textBox2.Text);
                    textBox3.Text = "" + (2 * a + 2 * b);
                    textBox4.Text = "" + (a * b);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ chiều dài, chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (radioButton2.Checked == true)
            {
                if(textBox1.Text != "")
                {
                    float a = float.Parse(textBox1.Text);
                    textBox3.Text = "" + (Math.PI * 2 * a);
                    textBox4.Text = "" + (Math.PI * a * a);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ chiều dài, chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else if(radioButton3.Checked == true)
            {
                if(textBox1.Text != "")
                {
                    float a = float.Parse(textBox1.Text);
                    textBox3.Text = "" + (4 * a);
                    textBox4.Text = "" + (a * a);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ chiều dài, chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hình trước khi thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
