﻿using System;
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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "YES";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "NO";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "MAYBE";
        }
    }
}
