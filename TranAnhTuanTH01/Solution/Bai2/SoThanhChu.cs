using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan.Solution.Bai2
{
    public class SoThanhChu
    {
        public void ChuyenDoi()
        {
            Console.Write("Nhap so bat ki tu 0 -> 9 : ");
            int a = int.Parse(Console.ReadLine());
            switch(a){
                case 0:
                    Console.WriteLine("Khong");
                    break;
                case 1:
                    Console.WriteLine("Mot");
                    break;
                case 2:
                    Console.WriteLine("Hai");
                    break;
                case 3:
                    Console.WriteLine("Ba");
                    break;
                case 4:
                    Console.WriteLine("Bon");
                    break;
                case 5:
                    Console.WriteLine("Nam");
                    break;
                case 6:
                    Console.WriteLine("Sau");
                    break;
                case 7:
                    Console.WriteLine("Bay");
                    break;
                case 8:
                    Console.WriteLine("Tam");
                    break;
                case 9:
                    Console.WriteLine("Chin");
                    break;
                default:
                    Console.WriteLine("Nhap khong chinh xac");
                    break;
            }
        }
    }
}
