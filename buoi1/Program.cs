using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = Console.ReadLine();
            Console.WriteLine("s = " + s);

            Console.WriteLine("Nhap a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a} + {b} = {(a + b)}");
            //Console.WriteLine(a + " + " + b + " + " + " = " + (a + b));
        }
    }
}
