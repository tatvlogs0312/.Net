using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan_TH05.Solution.Bai2
{
    class CongDan
    {
        private string maCD;
        private string tenCD;
        private string cmnd;
        private string gioitinh;
        private int namsinh;
        private string sdt;

        public string MaCD { get => maCD; set => maCD = value; }
        public string TenCD { get => tenCD; set => tenCD = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
