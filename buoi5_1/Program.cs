using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.Shape.Shape obj = new Models.Shape.Cricle();
            obj.Nhap();
            obj.Xuat();
            Console.WriteLine("Dien tich hinh tron : " + obj.getArea());

            obj = new Models.Shape.Square();
            obj.Nhap();
            obj.Xuat();
            Console.WriteLine("Dien tich hinh vuong : " + obj.getArea());

            Console.ReadKey();
        }
    }
}
