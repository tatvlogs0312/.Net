using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai1
{
    public class TamGiac
    {
        public void InTamGiac()
        {
            Console.Write("Nhap chieu cao : ");
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = 0 ; i <= a; i++)
            {
                for (int j = 0; j <= a; j++)
                {
                    if (j <= a - i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
