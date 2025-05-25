namespace beauty_shop.Model
{
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
