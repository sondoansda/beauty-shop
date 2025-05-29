using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblhoadonban")]
    public class HoaDonBan

    {
        public string SoHDB { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKhach { get; set; }
        public decimal TongTien { get; set; }


        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
        public ICollection<ChiTietHDB> ChiTietHDBs { get; set; }
    }
}
