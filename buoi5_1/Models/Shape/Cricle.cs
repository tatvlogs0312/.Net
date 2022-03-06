using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi5_1.Models.Shape
{
    public class Cricle : Shape
    {
        private float r;
        public Cricle() { }
        public /*override*/ float getArea()
        {
            return (float)Math.PI * r * r;
        }

        public /*override*/ void Nhap()
        {
            r = float.Parse(Console.ReadLine());
        }

        public /*override*/ void Xuat()
        {
            Console.WriteLine($"({r})");
        }
    }
}
