using EFC_03.Entity;
using EFC_03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Service
{
    public class VatTuService : IVatTuService
    {
        private readonly AppDbContext dbContext;
        public VatTuService()
        {
            dbContext = new AppDbContext();
        }
        public void HienThiDanhSachVatTuCanNhapThem()
        {
            var vatTu = dbContext.VatTu.Where(x=>x.SoLuongTon==0).ToList();
            foreach (var temp in vatTu)
            {
                Console.WriteLine(temp.TenVatTu);
            }
        }

        public void HienThiDanhSachVatTuHienCo()
        {
            var vatTu = dbContext.VatTu.ToList();
            foreach (var temp in vatTu)
            {
                if(temp.SoLuongTon ==0)
                {
                    Console.WriteLine($"{temp.TenVatTu}- Hết hàng");
                }
                else
                {
                    Console.WriteLine($"{temp.TenVatTu}- SLTK:{temp.SoLuongTon}");
                }
            }
        }
    }
}
