using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranAnhTuanTh04.Solution.bai2;
using TranAnhTuanTh04.Solution.bai3;
using TranAnhTuanTh04.Solution.bai4;
using TranAnhTuanTh04.Solution.bai5;
using TranAnhTuanTh04.Solution.bai6;

namespace TranAnhTuanTh04
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
            Application.Run(new Form5());
        }
    }
}
