using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblnhacungcap")]
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }

    }
}
