using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai5
{
    public class TamGiac
    {
        private int canhA;
        private int canhB;
        private int canhC;
        public TamGiac(int canhA, int canhB , int canhC)
        {
            if(canhA == 0 || canhB == 0 || canhC == 0)
            {
                if (canhA == 0)
                {
                    this.canhA = 0;
                }
                if (canhB == 0)
                {
                    this.canhB = 0;
                }
                if (canhC == 0)
                {
                    this.canhC = 0;
                }
            }
            else if((canhA + canhB > canhC)&&(canhC + canhB > canhA) &&(canhA + canhC > canhB))
            {
                this.canhA = canhA;
                this.canhB = canhB;
                this.canhC = canhC;
            }

            else
            {
                this.canhA = 0;
                this.canhB = 0;
                this.canhC = 0;
            }
        }

        public TamGiac()
        {

        }

        public int setCanhA
        {
            set
            {
                if(value != 0 || (value + canhB > canhC) && (canhC + canhB > value) && (value + canhC > canhB))
                {
                    canhA = value;
                }
            }
        }

        public int setCanhB
        {
            set
            {
                if (value != 0 || (value + canhA > canhC) && (canhC + canhA > value) && (value + canhC > canhA))
                {
                    canhB = value;
                }
            }
        }

        public int setCanhC
        {
            set
            {
                if (value != 0 || (value + canhB > canhA) && (canhA + canhB > value) && (value + canhA > canhB))
                {
                    canhC = value;
                }
            }
        }

        public bool laTamGiac()
        {
            if ((canhA + canhB > canhC) && (canhC + canhB > canhA) && (canhA + canhC > canhB))
            {
                return true;
            }
            return false;
        }

        public bool laTamGiac(int a, int b , int c)
        {
            if ((a + b > c) && (c + b > a) && (a + c > b))
            {
                return true;
            }
            return false;
        }

        public void Nhap()
        {
            Console.Write("Nhap a : ");
            canhA = int.Parse(Console.ReadLine());
            Console.Write("Nhap b : ");
            canhB = int.Parse(Console.ReadLine());
            Console.Write("Nhap c : ");
            canhC = int.Parse(Console.ReadLine());
        }

        public int chuVi()
        {
            return canhA + canhB + canhC;
        }

        public float dienTich()
        {
            int p = chuVi();
           return (float)Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
        }

        public void Xuat()
        {
            if(laTamGiac() == true)
            {
                Console.WriteLine($"{canhA} - {canhB} - {canhC}");
                Console.WriteLine($"Dien tich : {dienTich()}");
                Console.WriteLine($"Chu vi : {chuVi()}");
            }
            else
            {
                Console.WriteLine($"{canhA} / {canhB} / {canhC}");
                Console.WriteLine("3 canh khong tao duoc tam giac");
            }
        }
    }
}
