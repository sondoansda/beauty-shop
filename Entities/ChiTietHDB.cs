using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblchitiethdb")]
    public class ChiTietHDB
    {

        public string? SoHDB { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal Giaban { get; set; }
        public decimal Giamgia { get; set; }
        public decimal ThanhTien { get; set; }

        public HoaDonBan HoaDonBan { get; set; }
        public DMHangHoa DMHangHoa { get; set; }
    }
}
