using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai1
{
    class bai1
    {
        private int a;
        private int b;

        public void Nhap()
        {
            Console.Write("Nhap a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            b = int.Parse(Console.ReadLine());
        }

        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }

            return a;
        }

        public int BCNN(int a, int b)
        { 
            return a * b / UCLN(a, b);
        }

        public void Xuat()
        {
            Console.WriteLine($"UCLN : {UCLN(a,b)}");
            Console.WriteLine($"BCNN : {BCNN(a, b)}");
        }
    }
}
