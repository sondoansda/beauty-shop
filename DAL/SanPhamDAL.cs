using beauty_shop.Model;
using Microsoft.EntityFrameworkCore;

namespace beauty_shop.DAL
{
    public class SanPhamDAL
    {
        private readonly BeautyShopContext _context;

        public SanPhamDAL(BeautyShopContext context)
        {
            _context = context;
        }

        public List<SanPhamDTO> GetAllSanPham()
        {
            try
            {
                return _context.DMHangHoa
                    .Include(d => d.Loai)
                    .Include(d => d.CongDung)
                    .Include(d => d.MauSac)
                    .Include(d => d.ChatLieu)
                    .Include(d => d.HangSX)
                    .Include(d => d.Mua)
                    .Include(d => d.NuocSX)
                    .Select(d => d.ConvertSanPhamDTO())
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving products: " + ex.Message, ex);
            }
        }

        public void SaveOrUpdateSanPham(SanPhamDTO product, string imagePath)
        {
            try
            {
                var existingProduct = _context.DMHangHoa
                    .FirstOrDefault(p => p.MaHang == product.MaHang);

                // Validate foreign keys
                if (_context.tblLoai.FirstOrDefault(l => l.TenLoai == product.TenLoai) == null)
                    throw new Exception($"Loại '{product.TenLoai}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.CongDung.FirstOrDefault(c => c.TenCongDung == product.TenCongDung) == null)
                    throw new Exception($"Công dụng '{product.TenCongDung}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.MauSac.FirstOrDefault(m => m.TenMau == product.MauSac) == null)
                    throw new Exception($"Màu sắc '{product.MauSac}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.ChatLieu.FirstOrDefault(c => c.TenChatLieu == product.ChatLieu) == null)
                    throw new Exception($"Chất liệu '{product.ChatLieu}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.HangSX.FirstOrDefault(h => h.TenHangSX == product.HangSX) == null)
                    throw new Exception($"Hãng sản xuất '{product.HangSX}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.Mua.FirstOrDefault(m => m.TenMua == product.Mua) == null)
                    throw new Exception($"Mùa '{product.Mua}' không tồn tại trong cơ sở dữ liệu!");
                if (_context.NuocSX.FirstOrDefault(n => n.TenNUocSX == product.XuatXu) == null)
                    throw new Exception($"Xuất xứ '{product.XuatXu}' không tồn tại trong cơ sở dữ liệu!");

                if (existingProduct == null)
                {
                    // Create new product
                    var newProduct = new DMHangHoa
                    {
                        MaHang = product.MaHang,
                        TenHangHoa = product.TenHangHoa,
                        MaLoai = _context.tblLoai.FirstOrDefault(l => l.TenLoai == product.TenLoai).MaLoai,
                        MaCongDung = _context.CongDung.FirstOrDefault(c => c.TenCongDung == product.TenCongDung).MaCongDung,
                        MaMau = _context.MauSac.FirstOrDefault(m => m.TenMau == product.MauSac).MaMau,
                        MaChatLieu = _context.ChatLieu.FirstOrDefault(c => c.TenChatLieu == product.ChatLieu).MaChatLieu,
                        MaHangSX = _context.HangSX.FirstOrDefault(h => h.TenHangSX == product.HangSX).MaHangSX,
                        MaMua = _context.Mua.FirstOrDefault(m => m.TenMua == product.Mua).MaMua,
                        MaNuocSX = _context.NuocSX.FirstOrDefault(n => n.TenNUocSX == product.XuatXu).MaNuocSX,
                        SoLuong = product.SoLuong,
                        DonGiaNhap = product.Gianhap,
                        DonGiaBan = product.Giaban,
                        Anh = imagePath,
                        GhiChu = product.GhiChu,
                        ThoiGianBaoHanh = product.ThoiGianBaoHanh
                    };
                    _context.DMHangHoa.Add(newProduct);
                }
                else
                {
                    // Update existing product
                    existingProduct.TenHangHoa = product.TenHangHoa;
                    existingProduct.MaLoai = _context.tblLoai.FirstOrDefault(l => l.TenLoai == product.TenLoai).MaLoai;
                    existingProduct.MaCongDung = _context.CongDung.FirstOrDefault(c => c.TenCongDung == product.TenCongDung).MaCongDung;
                    existingProduct.MaMau = _context.MauSac.FirstOrDefault(m => m.TenMau == product.MauSac).MaMau;
                    existingProduct.MaChatLieu = _context.ChatLieu.FirstOrDefault(c => c.TenChatLieu == product.ChatLieu).MaChatLieu;
                    existingProduct.MaHangSX = _context.HangSX.FirstOrDefault(h => h.TenHangSX == product.HangSX).MaHangSX;
                    existingProduct.MaMua = _context.Mua.FirstOrDefault(m => m.TenMua == product.Mua).MaMua;
                    existingProduct.MaNuocSX = _context.NuocSX.FirstOrDefault(n => n.TenNUocSX == product.XuatXu).MaNuocSX;
                    existingProduct.SoLuong = product.SoLuong;
                    existingProduct.DonGiaNhap = product.Gianhap;
                    existingProduct.DonGiaBan = product.Giaban;
                    existingProduct.Anh = imagePath;
                    existingProduct.GhiChu = product.GhiChu;
                    existingProduct.ThoiGianBaoHanh = product.ThoiGianBaoHanh;
                }

                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Database error while saving product: " + ex.InnerException?.Message ?? ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving product: " + ex.Message, ex);
            }
        }

        public void DeleteSanPham(string maHang)
        {
            try
            {
                // Find the product to delete
                var product = _context.DMHangHoa
                    .FirstOrDefault(p => p.MaHang == maHang);

                if (product == null)
                {
                    throw new Exception($"Sản phẩm với mã '{maHang}' không tồn tại trong cơ sở dữ liệu!");
                }

                // Remove the product (cascading deletes handle ChiTietHDB and ChiTietHDN)
                _context.DMHangHoa.Remove(product);

                // Save changes to the database
                int rowsAffected = _context.SaveChanges();

                if (rowsAffected == 0)
                {
                    throw new Exception("Không có bản ghi nào được xóa. Vui lòng kiểm tra lại!");
                }
            }
            catch (DbUpdateException ex)
            {
                throw new Exception($"Lỗi cơ sở dữ liệu khi xóa sản phẩm: {ex.InnerException?.Message ?? ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa sản phẩm: {ex.Message}", ex);
            }
        }
    }
}