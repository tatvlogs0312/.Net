using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai5.SanPham
{
    class SanPham 
    {
        private String Ma;
        private long GiaNhap;
        private long GiaBan;
        private int SoLuong;
        private String HangSX;

        public SanPham()
        {

        }

        public SanPham(String Ma, long GiaNhap, long GiaBan, int SoLuong, String HangSX)
        {
            this.Ma = Ma;
            this.GiaNhap = GiaNhap;
            this.GiaBan = GiaBan;
            this.SoLuong = SoLuong;
            this.HangSX = HangSX;
        }

        public long giaNhap
        {
            get
            {
                return GiaNhap;
            }
        }

        public long giaBan
        {
            get
            {
                return GiaBan;
            }
        }

        public virtual void Nhap()
        {
            Console.Write("Ma : ");
            Ma = Console.ReadLine();
            Console.Write("Gia ban : ");
            GiaBan = Convert.ToInt64(Console.ReadLine());
            Console.Write("Gia nhap : ");
            GiaNhap = Convert.ToInt64(Console.ReadLine());
            Console.Write("So Luong : ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap hang san xuat : ");
            HangSX = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"{Ma}\t{GiaBan}\t{GiaNhap}\t{SoLuong}\t{HangSX}");
        }

    }
}
