using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai4
{
    public class MonHoc
    {
        private int mamh;
        private String tenmh;
        private int sotc;

        public MonHoc()
        {

        }
        public MonHoc(int mamh , String tenmh , int sotc)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.sotc = sotc;
        }

        public virtual void Nhap()
        {
            Console.Write("Nhap ma mon hoc : ");
            mamh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten mon hoc : ");
            tenmh = Console.ReadLine();
            Console.Write("Nhap so tin chi : ");
            sotc = int.Parse(Console.ReadLine());
        }

        public int GetSTC()
        {
            return sotc;
        }

        public virtual void Xuat()
        {
            Console.Write($"{mamh} - {tenmh} - {sotc}");
        }
    }
}
