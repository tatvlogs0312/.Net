using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai4
{
    public class TinChi : MonHoc
    {
        private float diemtp;
        private float diemthi;

        public TinChi() { }

        public TinChi(float diemtp , float diemthi , int mamh, String tenmh, int sotc) : base(mamh,tenmh,sotc)
        {
            this.diemtp = diemtp;
            this.diemthi = diemthi;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap diem thanh phan : ");
            diemtp = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem thi : ");
            diemthi = float.Parse(Console.ReadLine());
        }

        public float GetDTB()
        {
            return (float)(diemtp * 0.3 + diemthi * 0.7);
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($" - {diemtp} - {diemthi} - {GetDTB()}");
        }
    }
}
