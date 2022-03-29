using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai5.SanPham
{
    class Tivi : SanPham
    {
        private float KichThuoc;
        private String HDH;
        private String ChucNang;

        public Tivi()
        {

        }
        public Tivi(float KichThuoc, String HDH, String ChucNang, string Ma, long GiaNhap, long GiaBan, int SoLuong, string HangSX)
            : base(Ma, GiaNhap, GiaBan, SoLuong, HangSX)
        {
            this.KichThuoc = KichThuoc;
            this.HDH = HDH;
            this.ChucNang = ChucNang;
        }

        public String getHDH()
        {
            return HDH;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap kich thuoc : ");
            KichThuoc = float.Parse(Console.ReadLine());
            Console.Write("Nhap he dieu hanh : ");
            HDH = Console.ReadLine();
            Console.Write("Nhap chuc nang : ");
            ChucNang = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{KichThuoc}\t{HDH}\t{ChucNang}\t{giaBan - giaNhap}");
        }
    }
}
