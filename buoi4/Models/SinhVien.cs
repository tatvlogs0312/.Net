using System;

namespace buoi4.Models
{
    public class SinhVien : ConNguoi
    {
        // Khai báo các Fields
        private string MaSV;
        private string MaLop;
        private float DTB;
        // Định nghĩa các Methods
        // Constructor
        public SinhVien() { }
        public SinhVien(string MaSV, string MaLop, float DTB, string CMND, string HoTen, string QueQuan, int NamSinh)
            : base(CMND, HoTen, QueQuan, NamSinh)
        {
            this.MaSV = MaSV;
            this.MaLop = MaLop;
            this.DTB = DTB;
        }
        // Query methods
        public override void Xuat()
        {
            // Gọi phương thức Xuat của lớp ConNguoi
            base.Xuat();
            Console.WriteLine($"{MaSV}\t{MaLop}\t{DTB}");
        }
        // Update methods
        public override void Nhap()
        {
            // Gọi phương thức Nhap của lớp ConNguoi
            base.Nhap();

            Console.Write("Ma SV: ");
            MaSV = Console.ReadLine();
            Console.Write("Ma lop: ");
            MaLop = Console.ReadLine();
            Console.Write("DTB: ");
            DTB = (float)Convert.ToDouble(Console.ReadLine());
        }
    }
}