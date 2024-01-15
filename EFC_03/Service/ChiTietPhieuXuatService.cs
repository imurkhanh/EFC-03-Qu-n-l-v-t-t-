using EFC_03.Entity;
using EFC_03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Service
{
    public class ChiTietPhieuXuatService : IChiTietPhieuXuatService
    {
        private readonly AppDbContext dbContext;
        public ChiTietPhieuXuatService()
        {
            dbContext = new AppDbContext();
        }
        public void ThemChiTietPhieuXuat()
        {
            Console.WriteLine("Nhập phiếu xuất ID: ");
            int phieuXuatId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vật tư ID: ");
            int vatTuId = int.Parse(Console.ReadLine());
            var phieuXuat = dbContext.PhieuXuat.Find(phieuXuatId);
            if(phieuXuat == null )
            {
                return;
            }
            var vatTu = dbContext.VatTu.Find(vatTuId);
            if(vatTu == null )
            {
                return;
            }
            Console.WriteLine("Số lượng xuất: ");
            int soLuongXuat = int.Parse(Console.ReadLine());
            var chiTietPhieuXuat = new ChiTietPhieuXuat
            {
                VatTuId = vatTuId,
                PhieuXuatId = phieuXuatId,
                SoLuongXuat = soLuongXuat,
            };
            dbContext.Add(chiTietPhieuXuat);
            dbContext.SaveChanges();
            vatTu.SoLuongTon -= soLuongXuat;
            dbContext.SaveChanges();
            Console.WriteLine("Thêm chi tiết phiếu xuất thành công");

        }
    }
}
