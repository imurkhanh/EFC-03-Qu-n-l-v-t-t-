using EFC_03.Entity;
using EFC_03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Service
{
    public class PhieuNhapService : IPhieuNhapService
    {
        private readonly AppDbContext dbContext;
        public PhieuNhapService()
        {
            dbContext = new AppDbContext();
        }
        public void ThemPhieuNhap()
        {
            Console.WriteLine("Nhập mã phiếu nhập: ");
            string maPhieuNhap = Console.ReadLine();
            Console.WriteLine("Nhập tiêu đề nhập: ");
            string tieuDeNhap = Console.ReadLine();
            Console.WriteLine("Nhập ngày nhập(dd/mm/yyyy): ");
            DateTime ngayNhap = DateTime.Parse(Console.ReadLine());

            var phieuNhap = new PhieuXuat
            {
                MaPhieu = maPhieuNhap,
                TieuDe = tieuDeNhap,
                NgayXuat = ngayNhap,
            };
            dbContext.Add(phieuNhap);
            dbContext.SaveChanges();
            Console.WriteLine("Thêm phiếu nhập thành công");
        }
    }
}
