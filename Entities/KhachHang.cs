using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblkhachhang")]
    public class KhachHang
    {
        public string MaKhach { get; set; }
        public string TenKhach { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<HoaDonBan> HoaDonBans { get; set; }

    }
}