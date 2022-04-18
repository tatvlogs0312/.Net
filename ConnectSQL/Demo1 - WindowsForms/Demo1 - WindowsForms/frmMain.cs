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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            //int idx = listAnimal.SelectedIndex;
            //String item = listAnimal.SelectedItem.ToString();

            foreach(int idx in listAnimal.SelectedIndices)
            {
                String item = listAnimal.Items[idx].ToString();
                MessageBox.Show($"Người dùng chon {idx} : {item}");
            }
                       
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
