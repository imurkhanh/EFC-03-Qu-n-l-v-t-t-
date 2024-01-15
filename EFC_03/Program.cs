using EFC_03.IService;
using EFC_03.Service;

void Main()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.InputEncoding = System.Text.Encoding.UTF8;
    IPhieuNhapService phieuNhapService = new PhieuNhapService();
    IPhieuXuatService phieuXuatService = new PhieuXuatService();
    IChiTietPhieuNhapService chiTietPhieuNhapService = new ChiTietPhieuNhapService();
    IChiTietPhieuXuatService chiTietPhieuXuatService = new ChiTietPhieuXuatService();
    IVatTuService vatTuService = new VatTuService();

    Console.WriteLine("----------------------QUẢN LÝ VẬT TƯ (EFC-03)----------------------");
    Console.WriteLine("1. Hiển thị danh sách vật tư hiện đang có trong kho");
    Console.WriteLine("2. Hiển thị danh sách vật tư cần nhập thêm");
    Console.WriteLine("3. Thêm mới phiếu nhập");
    Console.WriteLine("4. Thêm mới chi tiết phiếu nhập");
    Console.WriteLine("5. Thêm mới phiếu xuất");
    Console.WriteLine("6. Thêm mới chi tiết phiếu xuất");
    Console.WriteLine("7. Thoát chương trình");

    string choice;
    do
    {
        Console.WriteLine();
        Console.Write("Nhập lựa chọn (1-7): ");
        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                vatTuService.HienThiDanhSachVatTuHienCo();
                break;
            case "2":
                vatTuService.HienThiDanhSachVatTuCanNhapThem();
                break;
            case "3":
                phieuNhapService.ThemPhieuNhap();
                break;
            case "4":
                chiTietPhieuNhapService.ThemChiTietPhieuNhap();
                break;
            case "5":
                phieuXuatService.ThemPhieuXuat();
                break;
            case "6":
                chiTietPhieuXuatService.ThemChiTietPhieuXuat();
                break;
            case "7":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ.Vui lòng nhập lại");
                break;
        }

    } while (choice != "7");
}
Main();