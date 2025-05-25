namespace beauty_shop.Model
{
    public class ChiTietHDB
    {

        public string SoHDB { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public decimal Giaban { get; set; }
        public decimal Giamgia { get; set; }
        public decimal ThanhTien { get; set; }

        public HoaDonBan HoaDonBan { get; set; }
        public DMHangHoa DMHangHoa { get; set; }
    }
}
