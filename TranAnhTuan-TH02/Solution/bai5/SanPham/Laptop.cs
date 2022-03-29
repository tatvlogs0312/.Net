using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai5.SanPham
{
    class Laptop : SanPham
    {
        private String CPU;
        private int Ram;
        private String GPU;
        private String ManHinh;

        public Laptop()
        {
        }

        public Laptop(String CPU, int Ram, String GPU, String ManHinh, string Ma, long GiaNhap, long GiaBan, int SoLuong, string HangSX)
            : base(Ma, GiaNhap, GiaBan, SoLuong, HangSX)
        {
            this.CPU = CPU;
            this.Ram = Ram;
            this.GPU = GPU;
            this.ManHinh = ManHinh;
        }

        public int getRam()
        {
            
            return Ram;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap CPU : ");
            CPU = Console.ReadLine();
            Console.Write("Nhap Ram : ");
            Ram = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap GPU : ");
            GPU = Console.ReadLine();
            Console.Write("Nhap loai man hinh : ");
            ManHinh = Console.ReadLine();

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{CPU}\t{Ram}\t{GPU}\t{ManHinh}\t{giaBan - giaNhap}");
        }
    }
}
