using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranAnhTuan_TH05.Solution.Bai4
{
    class BeNgoan
    {
        private string maBN;
        private string maLop;
        private string tenBN;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string hoTenBo;
        private string hoTenMe;
        private string diaChi;

        public string MaBN { get => maBN; set => maBN = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string TenBN { get => tenBN; set => tenBN = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string HoTenBo { get => hoTenBo; set => hoTenBo = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
