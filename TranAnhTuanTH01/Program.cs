using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai 1
            Solution.Bai1.TamGiac tamGiac = new Solution.Bai1.TamGiac();
            tamGiac.InTamGiac();

            //Bai2
            Solution.Bai2.SoThanhChu change = new Solution.Bai2.SoThanhChu();
            change.ChuyenDoi();

            //Bai3

            //Bai4
            Console.Write("Nhap so luong sinh vien : ");
            int slsv = int.Parse(Console.ReadLine());

            Solution.Bai4.SinhVien[] sv = new Solution.Bai4.SinhVien[slsv];

            for (int i = 0; i < slsv; i++)
            {
                sv[i] = new Solution.Bai4.SinhVien();
                sv[i].Nhap();
            }

            for (int i = 0; i < slsv; i++)
            {
                sv[i].Xuat();
            }

            //bai5
            Solution.Bai5.TamGiac tamGiac1 = new Solution.Bai5.TamGiac();
            tamGiac1.Nhap();
            tamGiac1.Xuat();

            Console.ReadKey();
        }
    }
}
