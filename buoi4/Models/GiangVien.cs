using System;

namespace buoi4.Models
{
    public class GiangVien : ConNguoi
    {
        private string MaGV;
        private int SoBB;

        public GiangVien() { }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Ma GV: ");
            MaGV = Console.ReadLine();
            Console.Write("So bai bao: ");
            SoBB = Convert.ToInt32(Console.ReadLine());
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"{MaGV}\t{SoBB}");
        }
    }
}