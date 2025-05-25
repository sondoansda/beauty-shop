namespace beauty_shop.Model
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string MaCV { get; set; }

        public CongViec CongViec { get; set; }
        public ICollection<HoaDonBan> HoaDonBans { get; set; }

    }
}
