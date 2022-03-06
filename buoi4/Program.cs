using System;

namespace buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Models.ConNguoi obj = new Models.SinhVien();
            obj.Nhap();
            obj.Xuat();

            obj = new Models.GiangVien();
            obj.Nhap();
            obj.Xuat();

            Console.ReadKey();
        }
    }
}
