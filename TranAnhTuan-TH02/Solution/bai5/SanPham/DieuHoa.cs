using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai5.SanPham
{
    class DieuHoa : SanPham
    {
        private int CongSuat;
        private String HaiChieu;

        public DieuHoa()
        {

        }

        public DieuHoa(int CongSuat, String HaiChieu, String Ma, long GiaNhap, long GiaBan, int SoLuong, String HangSX)
            : base(Ma, GiaNhap, GiaBan, SoLuong, HangSX)
        {
            this.CongSuat = CongSuat;
            this.HaiChieu = HaiChieu;
        }


        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap cong xuat : ");
            CongSuat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dieu hoa may chieu : ");
            HaiChieu = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{CongSuat}\t{HaiChieu}\t{giaBan - giaNhap}");
        }
    }
}
