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
            
            //bai 1
            Console.WriteLine("Nhap so luong khach hang : ");
            int slkh = Convert.ToInt32(Console.ReadLine());
            Solution.Bai1.KhachHang[] kh = new Solution.Bai1.KhachHang[slkh];
            for(int i = 0; i < kh.Length; i++)
            {
                kh[i] = new Solution.Bai1.KhachHang();
                kh[i].Nhap();
            }
            for (int i = 0; i < kh.Length; i++)
            {
                kh[i].Xuat();
            }

            long sum = 0;
            for (int i = 0; i < kh.Length; i++)
            {
                sum += kh[i].TongTien();
            }
            Console.WriteLine($"Tong so tien kiem duoc : {sum}");
            
            //bai 2
            //Laptop
            Console.WriteLine("Nhap so luong laptop : ");
            int sllt = Convert.ToInt32(Console.ReadLine());
            Solution.Bai2.SanPham[] sanPham = new Solution.Bai2.Laptop[sllt];

            for(int i = 0; i < sllt; i++)
            {
                sanPham[i] = new Solution.Bai2.Laptop();
                sanPham[i].Nhap();
            }

            for (int i = 0; i < sllt; i++)
            {
                sanPham[i].Xuat();
            }

            for(int i = 0; i < sllt; i++)
            {
                for(int j = 0; j < sllt; j++)
                {
                    if((sanPham[i].giaBan - sanPham[i].giaNhap) > (sanPham[j].giaBan - sanPham[j].giaNhap))
                    {
                        Solution.Bai2.SanPham temp = new Solution.Bai2.Laptop() ;
                        temp = sanPham[i];
                        sanPham[i] = sanPham[j];
                        sanPham[j] = temp;

                    }
                }
                
            }

            Console.WriteLine("Danh sach sau khi sap xep : ");

            for (int i = 0; i < sllt; i++)
            {
                sanPham[i].Xuat();
            }


                //Tivi
                Console.WriteLine("Nhap so luong tivi : ");
            int sltv = Convert.ToInt32(Console.ReadLine());
            sanPham = new Solution.Bai2.Tivi[sltv];
            for (int i = 0; i < sltv; i++)
            {
                sanPham[i] = new Solution.Bai2.Tivi();
                sanPham[i].Nhap();
            }

            for (int i = 0; i < sltv; i++)
            {
                sanPham[i].Xuat();
            }

            for (int i = 0; i < sltv; i++)
            {
                for (int j = 0; j < sltv; j++)
                {
                    if ((sanPham[i].giaBan - sanPham[i].giaNhap) > (sanPham[j].giaBan - sanPham[j].giaNhap))
                    {
                        Solution.Bai2.SanPham temp = new Solution.Bai2.Tivi();
                        temp = sanPham[i];
                        sanPham[i] = sanPham[j];
                        sanPham[j] = temp;

                    }
                }

            }

            Console.WriteLine("Danh sach sau khi sap xep : ");

            for (int i = 0; i < sltv; i++)
            {
                sanPham[i].Xuat();
            }

            //Dieu hoa
            Console.WriteLine("Nhap so luong dieu hoa : ");
            int sldh = Convert.ToInt32(Console.ReadLine());
            sanPham = new Solution.Bai2.DieuHoa[sldh];
            for(int i = 0; i < sldh; i++)
            {
                sanPham[i] = new Solution.Bai2.DieuHoa();
                sanPham[i].Nhap();
            }

            for (int i = 0; i < sldh; i++)
            {
                sanPham[i].Xuat();
            }

            for (int i = 0; i < sldh; i++)
            {
                for (int j = 0; j < sldh; j++)
                {
                    if ((sanPham[i].giaBan - sanPham[i].giaNhap) > (sanPham[j].giaBan - sanPham[j].giaNhap))
                    {
                        Solution.Bai2.SanPham temp = new Solution.Bai2.DieuHoa();
                        temp = sanPham[i];
                        sanPham[i] = sanPham[j];
                        sanPham[j] = temp;

                    }
                }

            }

            Console.WriteLine("Danh sach sau khi sap xep : ");

            for (int i = 0; i < sldh; i++)
            {
                sanPham[i].Xuat();
            }
        }
    }
}
