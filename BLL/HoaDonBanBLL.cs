using beauty_shop.DAL;
using beauty_shop.DTO;
using beauty_shop.Model;

namespace beauty_shop.BLL
{
    public class HoaDonBanBLL
    {
        private readonly HoaDonBanDAL _hoaDonBanDAL;

        public HoaDonBanBLL(BeautyShopContext context)
        {
            _hoaDonBanDAL = new HoaDonBanDAL(context);
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            return _hoaDonBanDAL.LayDanhSachNhanVien();
        }

        public KhachHang TimKhachHangTheoTen(string tenKhach)
        {
            if (string.IsNullOrWhiteSpace(tenKhach))
            {
                throw new ArgumentException("Tên khách hàng không được để trống.");
            }
            return _hoaDonBanDAL.TimKhachHangTheoTen(tenKhach);
        }
        public string TaoSoHDB()
        {
            int count = _hoaDonBanDAL.LaySoLuongHoaDon();
            return $"HDB{count + 1}";
        }
        public DMHangHoa TimHangHoaTheoMa(string maHang)
        {
            if (string.IsNullOrWhiteSpace(maHang))
            {
                throw new ArgumentException("Mã hàng hóa không được để trống.");
            }
            return _hoaDonBanDAL.TimHangHoaTheoMa(maHang);
        }
        public List<HoaDonBanDTO> LayDanhSachHoaDon()
        {
            return _hoaDonBanDAL.LayDanhSachHoaDon();
        }

        public bool KiemTraTonKho(string maHang, float soLuong, out string errorMessage)
        {
            return _hoaDonBanDAL.KiemTraTonKho(maHang, soLuong, out errorMessage);
        }

        public bool LuuHoaDon(HoaDonBanDTO hoaDonDTO, List<ChiTietHDBDTO> chiTietHDBs, out string errorMessage)
        {
            // Validate inputs
            if (hoaDonDTO == null)
            {
                errorMessage = "Hóa đơn không được null.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoaDonDTO.SoHDB))
            {
                errorMessage = "Số hóa đơn không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoaDonDTO.TenNV))
            {
                errorMessage = "Mã nhân viên không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(hoaDonDTO.TenKhach))
            {
                errorMessage = "Tên khách hàng không được để trống.";
                return false;
            }

            if (chiTietHDBs == null || !chiTietHDBs.Any())
            {
                errorMessage = "Danh sách chi tiết hóa đơn không được trống.";
                return false;
            }

            // Validate employee
            var nhanVien = _hoaDonBanDAL.TimNhanVienTheoTen(hoaDonDTO.TenNV);
            if (nhanVien == null)
            {
                errorMessage = "Nhân viên không hợp lệ.";
                return false;
            }

            // Validate customer
            var khachHang = _hoaDonBanDAL.TimKhachHangTheoTen(hoaDonDTO.TenKhach);
            if (khachHang == null)
            {
                errorMessage = "Khách hàng không hợp lệ.";
                return false;
            }

            // Validate inventory and calculate totals for each item
            foreach (var chiTiet in chiTietHDBs)
            {
                if (!ValidateChiTietHDB(chiTiet, out errorMessage))
                {
                    return false;
                }

                var hangHoa = _hoaDonBanDAL.TimHangHoaTheoMa(chiTiet.MaHang);
                if (hangHoa == null)
                {
                    errorMessage = $"Hàng hóa {chiTiet.MaHang} không tồn tại.";
                    return false;
                }

                if (!_hoaDonBanDAL.KiemTraTonKho(chiTiet.MaHang, chiTiet.SoLuong, out errorMessage))
                {
                    return false;
                }

                // Verify price consistency
                if (chiTiet.DonGia != hangHoa.DonGiaNhap)
                {
                    chiTiet.DonGia = hangHoa.DonGiaBan;
                }

                chiTiet.ThanhTien = chiTiet.SoLuong * chiTiet.DonGia * (1 - chiTiet.GiamGia / 100);
            }

            // Convert DTO to Model
            var hoaDon = new HoaDonBan
            {
                SoHDB = hoaDonDTO.SoHDB,
                Manhanvien = nhanVien.Manhanvien,
                MaKhach = khachHang.MaKhach,
                NgayBan = hoaDonDTO.NgayBan,
                TongTien = chiTietHDBs.Sum(ct => ct.ThanhTien)
            };

            var chiTietHDBsModel = chiTietHDBs.Select(ct => new ChiTietHDB
            {
                SoHDB = hoaDonDTO.SoHDB,
                MaHang = ct.MaHang,
                SoLuong = ct.SoLuong,
                Giaban = ct.DonGia,
                Giamgia = ct.GiamGia,
                ThanhTien = ct.ThanhTien
            }).ToList();

            // Save invoice and update inventory in a transaction

            // Save invoice
            if (!_hoaDonBanDAL.LuuHoaDon(hoaDon, chiTietHDBsModel, out errorMessage))
            {
                return false;
            }

            // Update inventory
            foreach (var chiTiet in chiTietHDBs)
            {
                _hoaDonBanDAL.CapNhatTonKho(chiTiet.MaHang, chiTiet.SoLuong);
            }

            errorMessage = null;
            return true;
        }



        private bool ValidateChiTietHDB(ChiTietHDBDTO chiTiet, out string errorMessage)
        {
            if (chiTiet == null)
            {
                errorMessage = "Chi tiết hóa đơn không được null.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(chiTiet.MaHang))
            {
                errorMessage = "Mã hàng hóa không được để trống.";
                return false;
            }

            if (chiTiet.SoLuong <= 0)
            {
                errorMessage = "Số lượng phải lớn hơn 0.";
                return false;
            }

            if (chiTiet.DonGia < 0)
            {
                errorMessage = "Đơn giá không được âm.";
                return false;
            }

            if (chiTiet.GiamGia < 0 || chiTiet.GiamGia > 100)
            {
                errorMessage = "Giảm giá phải nằm trong khoảng từ 0 đến 100%.";
                return false;
            }

            errorMessage = null;
            return true;
        }
    }
}