using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entity
{
    public class ChiTietPhieuNhap
    {
        public int ChiTietPhieuNhapId { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuNhapId { get; set; }
        public PhieuNhap PhieuNhap { get; set; }
        public int SoLuongNhap { get; set; }
    }
}
