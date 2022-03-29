using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranAnhTuan.Solution.bai1;
namespace TranAnhTuan
{
    class Program
    {
        static void Main(string[] args)
        {
            //bai1
            bai1 bai1 = new bai1();
            //bai1.Nhap();
            //bai1.Xuat();

            //bai2
            Console.Write("Nhap so luong khach hang : ");
            int slkh = int.Parse(Console.ReadLine());
            Solution.bai2.KhachHang[] KH = new Solution.bai2.KhachHang[slkh];
            for (int i = 0; i < slkh; i++)
            {
                KH[i] = new Solution.bai2.KhachHang();
                KH[i].Nhap();
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Danh sach khach hang : ");
            for (int i = 0; i < slkh; i++)
            {
                KH[i].Xuat();
                Console.WriteLine("-----------------------");
            }

            for (int i = 0; i < slkh - 1; i++)
            {
                for (int j = i + 1; j < slkh; j++)
                {
                    if (KH[i].TongTien() > KH[j].TongTien())
                    {
                        Solution.bai2.KhachHang temp = new Solution.bai2.KhachHang();
                        temp = KH[i];
                        KH[i] = KH[j];
                        KH[j] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sach khach hang sau khi sap xep : ");
            for (int i = 0; i < slkh; i++)
            {
                KH[i].Xuat();
                Console.WriteLine("-----------------------");
            }

            //bai3
            Console.Write("Nhap so luong khach hang : ");
            int slkh2 = int.Parse(Console.ReadLine());
            Solution.bai3.KhachHang[] kh = new Solution.bai3.KhachHang[slkh2];
            for (int i = 0; i < slkh2; i++)
            {
                KH[i] = new Solution.bai2.KhachHang();
                KH[i].Nhap();
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("Danh sach khach hang : ");
            for (int i = 0; i < slkh2; i++)
            {
                KH[i].Xuat();
                Console.WriteLine("-----------------------");
            }

            float tongTien = 0;
            for (int i = 0; i < slkh2; i++)
            {
                tongTien += kh[i].tongtien;
            }

            Console.WriteLine($"Tong doanh thu : {tongTien}");

            //bai5
            List<Solution.bai5.SanPham.Laptop> listlt = new List<Solution.bai5.SanPham.Laptop>();
            List<Solution.bai5.SanPham.Tivi> listtv = new List<Solution.bai5.SanPham.Tivi>();
            List<Solution.bai5.SanPham.DieuHoa> listdh = new List<Solution.bai5.SanPham.DieuHoa>();

            Console.Write("Nhap so luong san pham : ");
            int slsp = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nhap laptop : ");
            for (int i = 0; i < slsp; i++)
            {
                Solution.bai5.SanPham.Laptop lt = new Solution.bai5.SanPham.Laptop();
                lt.Nhap();
                listlt.Add(lt);
            }
            
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nhap tivi : ");
            for (int i = 0; i < slsp; i++)
            {
                Solution.bai5.SanPham.Tivi tv = new Solution.bai5.SanPham.Tivi();
                tv.Nhap();
                listtv.Add(tv);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Nhap dieu hoa : ");
            for (int i = 0; i < slsp; i++)
            {
                Solution.bai5.SanPham.DieuHoa dh = new Solution.bai5.SanPham.DieuHoa();
                dh.Nhap();
                listdh.Add(dh);
            }
            

            Console.WriteLine("Danh sach laptop : ");
            foreach (Solution.bai5.SanPham.Laptop sanpham in listlt)
            {
                sanpham.Xuat();
            }

            Console.WriteLine("Danh sach laptop : ");
            for (int i = 0; i < listlt.Count; i++) 
            {
                for (int j = 1; j < listlt.Count; j++)
                {
                    if ((listlt[i].giaBan - listlt[i].giaNhap) > (listlt[j].giaBan - listlt[j].giaNhap))
                    {
                        Solution.bai5.SanPham.Laptop temp = new Solution.bai5.SanPham.Laptop();
                        temp = listlt[i];
                        listlt[i] = listlt[j];
                        listlt[j] = temp;
                    }
                    
                }
            }

            foreach (Solution.bai5.SanPham.Laptop sanpham in listlt)
            {
                sanpham.Xuat();
            }

            int max = 0;
            foreach (Solution.bai5.SanPham.Laptop sanpham in listlt)
            {
                if (sanpham.getRam() > max)
                {
                    max = sanpham.getRam();
                }
            }

            //tim laptop co ram lon nhat
            Console.WriteLine("Laptop co ram lon nhat : ");
            foreach (Solution.bai5.SanPham.Laptop sanpham in listlt)
            {
                if (sanpham.getRam() == max)
                {
                    sanpham.Xuat();
                }
            }
            
            Console.WriteLine("Danh sach tivi : ");
            foreach (Solution.bai5.SanPham.Tivi sanpham in listtv)
            {
                sanpham.Xuat();
            }

            Console.WriteLine("Danh sach tivi : ");
            for (int i = 0; i < listtv.Count; i++)
            {
                for (int j = 1; j < listtv.Count; j++)
                {
                    if ((listtv[i].giaBan - listtv[i].giaNhap) > (listtv[j].giaBan - listtv[j].giaNhap))
                    {
                        Solution.bai5.SanPham.Tivi temp = new Solution.bai5.SanPham.Tivi();
                        temp = listtv[i];
                        listtv[i] = listtv[j];
                        listtv[j] = temp;
                    }

                }
            }

            Console.WriteLine("Danh sach tivi : ");
            foreach (Solution.bai5.SanPham.Tivi sanpham in listtv)
            {
                sanpham.Xuat();
            }

            Console.WriteLine("\n====Nhung Tivi co he dieu hanh ANDROID nhat la====");
            foreach(Solution.bai5.SanPham.Tivi sanpham in listtv)
            {
                if(sanpham.getHDH() == "ANDROID")
                {
                    sanpham.Xuat();
                }
            }

            Console.WriteLine("Danh sach dieu hoa : ");
            foreach (Solution.bai5.SanPham.DieuHoa sanpham in listdh)
            {
                sanpham.Xuat();
            }

            Console.WriteLine("Danh sach dieu hoa : ");
            for (int i = 0; i < listdh.Count; i++)
            {
                for (int j = 1; j < listdh.Count; j++)
                {
                    if ((listdh[i].giaBan - listdh[i].giaNhap) > (listdh[j].giaBan - listdh[j].giaNhap))
                    {
                        Solution.bai5.SanPham.DieuHoa temp = new Solution.bai5.SanPham.DieuHoa();
                        temp = listdh[i];
                        listdh[i] = listdh[j];
                        listdh[j] = temp;
                    }

                }
            }
            Console.WriteLine("Danh sach dieu hoa : ");
            foreach (Solution.bai5.SanPham.DieuHoa sanpham in listdh)
            {
                sanpham.Xuat();
            }

            long sum = 0;
            foreach (Solution.bai5.SanPham.DieuHoa sanpham in listdh)
            {
                sum += sanpham.giaNhap; 
            }
            Console.WriteLine($"Tong gia nhap dieu hoa : {sum}");

            Console.ReadKey();
        }
    }
}
