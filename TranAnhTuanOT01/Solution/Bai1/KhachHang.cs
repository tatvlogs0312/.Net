using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai1
{
    class KhachHang
    {
        private string TenKH;
        private int NhoRang;
        private int TramRang;

        public KhachHang() { }

        public KhachHang(string TenKH, int NhoRang, int TramRang)
        {
            this.TenKH = TenKH;
            this.NhoRang = NhoRang;
            this.TramRang = TramRang;
 
        }


        public void Nhap()
        {
            Console.Write("Ten khach hang: ");
            TenKH = Console.ReadLine();
            Console.Write("So luong nho rang : ");
            NhoRang = int.Parse(Console.ReadLine());
            Console.Write("So luong tram rang: ");
            TramRang = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine($"{TenKH}\t{NhoRang}\t{TramRang}");
        }

        public long TongTien()
        {
            return NhoRang * 150000 + TramRang * 200000;
        }

    }
}
