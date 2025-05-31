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
            try
            {

                var khachHang = _context.KhachHang
                    .FirstOrDefault(kh => EF.Functions.Like(kh.TenKhach, $"%{tenKhach}%"));

                return khachHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in TimKhachHangTheoTen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public NhanVien TimNhanVienTheoTen(string tenNhanvien)
        {
            try
            {

                var nhanvien = _context.NhanVien
                    .FirstOrDefault(kh => EF.Functions.Like(kh.Tennhanvien, $"%{tenNhanvien}%"));

                return nhanvien;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in NhanvienTheoTen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public DMHangHoa TimHangHoaTheoMa(string maHang)
        {
            return _context.DMHangHoa.FirstOrDefault(h => h.MaHang == maHang);
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
            catch (DbUpdateException ex)
            {
                errorMessage = $"Database error: {ex.InnerException?.Message ?? ex.Message}";
                return false;
            }
        }
        public int LaySoLuongHoaDon()
        {
            return _context.HoaDonBan.Count();
        }
        public bool KiemTraTonKho(string maHang, float soLuong, out string errorMessage)
        {
            var hangHoa = _context.DMHangHoa.FirstOrDefault(h => h.MaHang == maHang);
            if (hangHoa == null)
            {
                errorMessage = $"Hàng hóa {maHang} không tồn tại.";
                return false;
            }
            if (hangHoa.SoLuong < soLuong)
            {
                errorMessage = $"Số lượng tồn kho của {maHang} không đủ. Tồn kho hiện tại: {hangHoa.SoLuong}";
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