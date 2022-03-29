using System;

namespace BTbuoi1
{
    class Program
    {

        static void ptBac1(double a, double b)
        {
            if (a == 0 && b != 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiem phuong trinh : " + x);
            }
        }

        static int tinhGT(int x)
        {
            int gt = 1;
            for (int i = 1 ; i <= x; i++)
            {
                gt = gt * i;
            }
            
            return gt;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a va b : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            ptBac1(a, b);

            Console.WriteLine("Nhap x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int kq = tinhGT(x);
            Console.WriteLine("x! : " + kq);
        }
    }
}
