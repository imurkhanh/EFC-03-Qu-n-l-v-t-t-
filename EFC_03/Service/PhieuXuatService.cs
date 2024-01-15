using EFC_03.Entity;
using EFC_03.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_03.Service
{
    public class PhieuXuatService : IPhieuXuatService
    {
        private readonly AppDbContext dbContext;
        public PhieuXuatService()
        {
            dbContext = new AppDbContext();
        }
        public void ThemPhieuXuat()
        {
            Console.WriteLine("Nhập mã phiếu xuất: ");
            string maPhieuXuat = Console.ReadLine();
            Console.WriteLine("Nhập tiêu đề xuất: ");
            string tieuDeXuat = Console.ReadLine();
            Console.WriteLine("Nhập ngày xuất(dd/mm/yyyy): ");
            DateTime ngayXuat = DateTime.Parse(Console.ReadLine());

            var phieuXuat = new PhieuXuat
            {
                MaPhieu = maPhieuXuat,
                TieuDe = tieuDeXuat,
                NgayXuat = ngayXuat,
            };
            dbContext.Add(phieuXuat); 
            dbContext.SaveChanges();
            Console.WriteLine("Thêm phiếu xuất thành công");
        }
    }
}
