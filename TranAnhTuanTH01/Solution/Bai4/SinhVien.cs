using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai4
{
    public class SinhVien
    {
        private int masv;
        private String tensv;
        private int sltc;
        private TinChi[] tinchi;

        public SinhVien() { }

        public void Nhap()
        {
            Console.Write("Nhap ma sinh vien : ");
            sltc = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten sinh vien : ");
            tensv = Console.ReadLine();
            Console.Write("Nhap so luong tin chi da dang ki : ");
            sltc = int.Parse(Console.ReadLine());
            tinchi = new TinChi[sltc];
            for(int i = 0; i < sltc; i++)
            {
                tinchi[i] = new TinChi();
                tinchi[i].Nhap();
            }
        }

        public float TongKet()
        {
            float kq = 0;
            int STC = 0;
            for (int i = 0; i < sltc; i++)
            {
                kq = kq + tinchi[i].GetDTB() * tinchi[i].GetSTC();
                STC = STC + tinchi[i].GetSTC();
            }
            if(STC != 0)
            {
                kq = kq / STC;
            }

            return kq;
        }

        public void XepLoai()
        {
            if(TongKet() < 6)
            {
                Console.WriteLine("Xep loai trung binh");
            } 
            else if (TongKet() < 8 && TongKet() >= 6)
            {
                Console.WriteLine("Xep loai kha");
            }
            else
            {
                Console.WriteLine("Xep loai gioi");
            }
        }

        public void Xuat()
        {
            Console.WriteLine($"{masv} - {tensv} - {sltc}");
            for(int i = 0; i < sltc; i++)
            {
                tinchi[i].Xuat();
            }
            Console.WriteLine(TongKet());
            XepLoai();
        }
    }
}
