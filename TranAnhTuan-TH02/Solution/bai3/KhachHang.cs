using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.bai3
{
    enum LP { Phongdon, Phongdoi, Phongba }
    public class KhachHang
    {
        private string HoTen;
        private string Diachi;
        private int SoNgayO;
        private float TongTien;
        private int choose1, choose2, choose3;
        private LP LoaiPhong;

        public KhachHang() { }

        public float tongtien
        {
            get
            {
                return TongTien;
            }
        }

        public void Nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();

            Console.Write("Nhap so ngay o: ");
            SoNgayO = int.Parse(Console.ReadLine());

            Console.Write("Chon loai phong(1: Phong don, 2: Phong doi, 3: Phong ba): ");
            int choose1 = int.Parse(Console.ReadLine());
            switch (choose1)
            {
                case 1:
                    TongTien = 300000 * SoNgayO;
                    LoaiPhong = LP.Phongba;
                    break;
                case 2:
                    TongTien = 350000 * SoNgayO;
                    break;
                case 3:
                    TongTien = 400000 * SoNgayO;
                    break;
            }

            Console.Write("Chon tien nghi(1: Tivi, 2: Internet, 3: May nuoc nong): ");
            int choose2 = int.Parse(Console.ReadLine());
            switch (choose2)
            {
                case 1:
                    TongTien += 10000;
                    break;
                case 2:
                    TongTien += 10000;
                    break;
                case 3:
                    TongTien += 10000;
                    break;
            }

            Console.Write("Chon dich vu(1: Karaoke, 2: An sang): ");
            int choose3 = int.Parse(Console.ReadLine());
            switch (choose3)
            {
                case 1:
                    TongTien += 15000 * SoNgayO;
                    break;
                case 2:
                    TongTien += 15000 * SoNgayO;
                    break;
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Dia chi: {Diachi}");
            Console.WriteLine($"So Ngay o: {SoNgayO}");
            Console.Write($"Loai phong: {LoaiPhong}");
            

            Console.Write("Tien nghi: ");
            if (choose2 == 1)
            {
                Console.Write("Tivi ");
            }
            if (choose2 == 2)
            {
                Console.Write("Internet ");
            }
            if (choose2 == 3)
            {
                Console.Write("May nuoc nong ");
            }
            Console.Write("Dich vu: ");
            if (choose3 == 1)
            {
                Console.Write("Karaoke ");
            }
            if (choose3 == 2)
            {
                Console.Write("An sang ");
            }
        }     
    }
}