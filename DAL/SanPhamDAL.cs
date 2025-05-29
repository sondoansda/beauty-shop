using beauty_shop.Model;
using Microsoft.EntityFrameworkCore;

namespace beauty_shop.DAL
{
    public class SanPhamDAL
    {
        private BeautyShopContext context;
        //private string connectionString = "server=localhost;port=3306;database=QuanLyCuaHangMyPham;user=root;password=;";
        public SanPhamDAL()
        {
            context = new BeautyShopContext();
        }
        public List<DMHangHoa> GetAll()
        {
            using (var context = new BeautyShopContext())
            {
                Unknown column 'd.CongDungMaCongDung' in 'field list''
                var list = context.DMHangHoa
                    .Include(d => d.Loai)
                    .Include(d => d.KhoiLuong)
                    .Include(d => d.HangSX)
                    .Include(d => d.ChatLieu)
                    .Include(d => d.NuocSX)
                    .Include(d => d.MauSac)
                    .Include(d => d.CongDung)
                    .Include(d => d.Mua)
                    .ToList();

                return list;
            }
        }





        //public void Insert(DMHangHoa newItem)
        //{
        //    using (var context = new BeautyShopContext())
        //    {
        //        context.DMHangHoa.Add(newItem);
        //        context.SaveChanges();
        //    }
        //}

        //// Update
        //public void Update(DMHangHoa updatedItem)
        //{
        //    using (var context = new BeautyShopContext())
        //    {
        //        // Lấy entity cũ từ DB
        //        var existingItem = context.DMHangHoas.Find(updatedItem.MaHang);
        //        if (existingItem != null)
        //        {
        //            // Cập nhật các thuộc tính cần thiết
        //            existingItem.TenHang = updatedItem.TenHang;
        //            existingItem.MaLoai = updatedItem.MaLoai;
        //            existingItem.MaKhoiLuong = updatedItem.MaKhoiLuong;
        //            existingItem.MaHangSX = updatedItem.MaHangSX;
        //            existingItem.MaChatLieu = updatedItem.MaChatLieu;
        //            existingItem.MaNuocSX = updatedItem.MaNuocSX;
        //            existingItem.MaMau = updatedItem.MaMau;
        //            existingItem.MaCongDung = updatedItem.MaCongDung;
        //            existingItem.MaMua = updatedItem.MaMua;
        //            existingItem.SoLuong = updatedItem.SoLuong;
        //            existingItem.Giaban = updatedItem.Giaban;
        //            existingItem.Gianhap = updatedItem.Gianhap;
        //            existingItem.Thoigianbaohanh = updatedItem.Thoigianbaohanh;
        //            existingItem.Ghichu = updatedItem.Ghichu;
        //            existingItem.Anh = updatedItem.Anh;

        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //            throw new Exception("Không tìm thấy mặt hàng để cập nhật.");
        //        }
        //    }
        //}

        //// Delete
        //public void Delete(string maHang)
        //{
        //    using (var context = new BeautyShopContext())
        //    {
        //        var item = context.DMHangHoas.Find(maHang);
        //        if (item != null)
        //        {
        //            context.DMHangHoas.Remove(item);
        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //            throw new Exception("Không tìm thấy mặt hàng để xóa.");
        //        }
        //    }
        //}
    }
}
