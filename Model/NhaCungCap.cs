namespace beauty_shop.Model
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }

        public ICollection<HoaDonNhap> HoaDonNhaps { get; set; }

    }
}
