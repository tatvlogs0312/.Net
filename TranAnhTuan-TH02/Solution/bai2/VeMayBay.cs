using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai2
{
    class VeMayBay
    {
        private String TenChuyen;
        private String NgayBay;
        private long GiaVe;

        public VeMayBay() { }

        public VeMayBay(String TenChuyen , String NgayBay , long GiaVe) 
        {
            this.TenChuyen = TenChuyen;
            this.NgayBay = NgayBay;
            this.GiaVe = GiaVe;
        }

        public long GetGia()
        {
            return GiaVe;
        }

        public void Nhap()
        {
            Console.Write("Nhap ten chuyen bay : ");
            TenChuyen = Console.ReadLine();
            Console.Write("Nhap ngay bay : ");
            NgayBay = Console.ReadLine();
            Console.Write("Nhap gia ve : ");
            GiaVe = long.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{TenChuyen} - {NgayBay} - {GiaVe}");
        }
    }
}
