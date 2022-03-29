using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai2
{
    class KhachHang : ConNguoi
    {
        private List<VeMayBay> list = new List<VeMayBay>();

        public KhachHang() { }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so luong ve : ");
            int slv = int.Parse(Console.ReadLine());
            for(int i = 0; i < slv; i++)
            {
                VeMayBay vmb = new VeMayBay();
                vmb.Nhap();
                list.Add(vmb);
            }
        }

        public long TongTien()
        {
            long sum = 0;
            foreach (VeMayBay ve in list)
            {
                sum = sum + ve.GetGia();
            }
            return sum;
        }

        public override void Xuat()
        {
            base.Xuat();
            foreach (VeMayBay ve in list)
            {
                ve.Xuat();
            }
            Console.WriteLine($"Tong tien : {TongTien()}");
        }

        
    }
}
