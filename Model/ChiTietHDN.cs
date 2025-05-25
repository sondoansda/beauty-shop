namespace beauty_shop.Model
{
    public class ChiTietHDN
    {
        public string SoHDN { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }

        public decimal GiaNhap { get; set; }
        public decimal ThanhTien { get; set; }

        public HoaDonNhap HoaDonNhap { get; set; }
        public DMHangHoa DMHangHoa { get; set; }

    }
}
