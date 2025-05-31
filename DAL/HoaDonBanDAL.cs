using beauty_shop.DTO;
using beauty_shop.Model;
using Microsoft.EntityFrameworkCore;

namespace beauty_shop.DAL
{
    public class HoaDonBanDAL
    {
        private readonly BeautyShopContext _context;

        public HoaDonBanDAL(BeautyShopContext context)
        {
            _context = context;
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return _context.NhanVien.ToList();
        }

        public KhachHang TimKhachHangTheoTen(string tenKhach)
        {
            return _context.KhachHang
                .FirstOrDefault(kh => kh.TenKhach.ToLower().Contains(tenKhach.ToLower()));
        }

        public DMHangHoa TimHangHoaTheoMa(string maHang)
        {
            return _context.DMHangHoa
                .FirstOrDefault(hh => hh.MaHang == maHang);
        }

        public List<HoaDonBanDTO> LayDanhSachHoaDon()
        {
            return _context.HoaDonBan
                .Include(hdb => hdb.NhanVien)
                .Include(hdb => hdb.KhachHang)
                .Select(h => new HoaDonBanDTO
                {
                    SoHDB = h.SoHDB,
                    TenNV = h.NhanVien != null ? h.NhanVien.Tennhanvien : "Không có",
                    TenKhach = h.KhachHang != null ? h.KhachHang.TenKhach : "Không có",
                    NgayBan = h.NgayBan,
                    TongTien = h.TongTien
                })
                .ToList();
        }



        public bool LuuHoaDon(HoaDonBan hoaDon, List<ChiTietHDB> chiTietHDBs, out string errorMessage)
        {
            try
            {
                _context.HoaDonBan.Add(hoaDon);
                _context.ChiTietHDB.AddRange(chiTietHDBs);
                _context.SaveChanges();
                errorMessage = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = $"Lỗi khi lưu hóa đơn: {ex.Message}";
                return false;
            }
        }

        public bool KiemTraTonKho(string maHang, float soLuong, out string errorMessage)
        {
            var hangHoa = _context.DMHangHoa.Find(maHang);
            if (hangHoa == null)
            {
                errorMessage = "Hàng hóa không tồn tại.";
                return false;
            }
            if (hangHoa.SoLuong < soLuong)
            {
                errorMessage = $"Số lượng tồn kho không đủ. Còn lại: {hangHoa.SoLuong}";
                return false;
            }
            errorMessage = null;
            return true;
        }

        public void CapNhatTonKho(string maHang, float soLuong)
        {
            var hangHoa = _context.DMHangHoa.Find(maHang);
            if (hangHoa != null)
            {
                hangHoa.SoLuong -= (int)soLuong;
                _context.SaveChanges();
            }
        }
    }
}