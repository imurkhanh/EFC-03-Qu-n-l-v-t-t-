﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Entity
{
    public class ChiTietPhieuXuat
    {
        public int ChiTietPhieuXuatId { get; set; }
        public int VatTuId { get; set; }
        public VatTu VatTu { get; set; }
        public int PhieuXuatId { get; set; }
        public PhieuXuat PhieuXuat { get; set; }
        public int SoLuongXuat {  get; set; }

    }
}
