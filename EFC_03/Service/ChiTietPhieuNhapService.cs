using EFC_03.Entity;
using EFC_03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Service
{
    public class ChiTietPhieuNhapService : IChiTietPhieuNhapService
    {
        private readonly AppDbContext dbContext;
        public ChiTietPhieuNhapService()
        {
            dbContext = new AppDbContext();
        }
        public void ThemChiTietPhieuNhap()
        {
            Console.Write("Nhập phiếu nhập ID: ");
            int phieuNhapId = int.Parse(Console.ReadLine());
            Console.Write("Nhập vật tư ID: ");
            int vatTuId = int.Parse(Console.ReadLine());
            
            var phieuNhap = dbContext.PhieuNhap.Find(phieuNhapId);
            if(phieuNhap == null)
            {
                return;
            }
            var vatTu = dbContext.VatTu.Find(vatTuId);
            if (vatTu == null)
            {
                return;
            }

            Console.WriteLine("Số lượng nhập: ");
            int soLuongNhap = int.Parse(Console.ReadLine());
            var chiTietPhieuNhap = new ChiTietPhieuNhap
            {
                VatTuId = vatTuId,
                PhieuNhapId = phieuNhapId,
                SoLuongNhap = soLuongNhap,
            };
            dbContext.Add(chiTietPhieuNhap);
            dbContext.SaveChanges();

            vatTu.SoLuongTon += soLuongNhap;
            dbContext.SaveChanges();
            Console.WriteLine("Thêm chi tiết phiếu nhập thành công");
        }
    }
}
