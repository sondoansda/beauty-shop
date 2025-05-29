using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblhoadonnhap")]
    public class HoaDonNhap
    {
        public string SoHDN { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public decimal TongTien { get; set; }

        public NhanVien NhanVien { get; set; }
        public NhaCungCap NhaCungCap { get; set; }
        public ICollection<ChiTietHDN> ChiTietHDNs { get; set; }

    }
}
