using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5_1.Models.Shape
{
    public class Square:Shape
    {
        private float a;
        public /*override*/ float getArea()
        {
            return a * a;
        }

        public /*override*/ void Nhap()
        {
            a = float.Parse(Console.ReadLine());
        }

        public /*override*/ void Xuat()
        {
            Console.WriteLine($"({a})");
        }
    }
}
