using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai2
{
    enum GioiTinh { Nam, Nu }
    class ConNguoi
    {
        private String HoTen;
        private GioiTinh gioiTinh;
        private int Tuoi;

        public ConNguoi() { }

        public ConNguoi(String HoTen , GioiTinh gioiTinh, int Tuoi)
        {
            this.HoTen = HoTen;
            this.gioiTinh = gioiTinh;
            this.Tuoi = Tuoi;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ho ten : ");
            HoTen = Console.ReadLine();
            Console.Write("(1 - nam , 0 - nu)Nhap gioi tinh : ");
            int gt = int.Parse(Console.ReadLine());
            if (gt == 1)
            {
                gioiTinh = GioiTinh.Nam;
            }
            else if (gt == 0)
            {
                gioiTinh = GioiTinh.Nu;
            }
            else
            {
                Console.WriteLine("Khong co gioi tinh nay");
            }
            Console.Write("Nhap tuoi : ");
            Tuoi = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"{HoTen} - {gioiTinh} - {Tuoi}");
        }
    }
}
