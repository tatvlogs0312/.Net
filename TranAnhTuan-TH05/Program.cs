using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranAnhTuan_TH05.Solution.Bai2;
using TranAnhTuan_TH05.Solution.Bai3;
using TranAnhTuan_TH05.Solution.Bai4;
using TranAnhTuan_TH05.Solution.Bai5;
using TranAnhTuan_TH05.Solution.Bai6;
using TranAnhTuan_TH05.Solution.Bai7;
using TranAnhTuan_TH05.Solution.Bai8;

namespace TranAnhTuan_TH05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form4());
            //Application.Run(new Form5());
            //Application.Run(new Form6());
            //Application.Run(new Form7());
            Application.Run(new TheSim());
        }
    }
}
