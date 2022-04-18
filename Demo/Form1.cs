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

namespace Demo
{
    public partial class frmDemo : Form
    {
        private Connect connectDB;

        public frmDemo()
        {
            InitializeComponent();
            connectDB = new Connect();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            connectDB.connect();           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSV = txtMa.Text;
            string tenSV = txtTen.Text;
            string lop = txtLop.Text;
            connectDB.addSV(maSV,tenSV,lop);
        }
    }
}
