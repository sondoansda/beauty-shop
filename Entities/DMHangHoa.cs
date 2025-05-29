namespace beauty_shop.Model
{
    public class DMHangHoa
    {
        public string MaHang { get; set; }
        public string? TenHang { get; set; }
        public string? MaLoai { get; set; }
        public string? MaKhoiLuong { get; set; }
        public string? MaHangSX { get; set; }
        public string? MaChatLieu { get; set; }
        public string? MaNuocSX { get; set; }
        public string? MaMau { get; set; }
        public string? MaCongDung { get; set; }
        public string? MaMua { get; set; }
        public int SoLuong { get; set; }
        public decimal Giaban { get; set; }
        public decimal Gianhap { get; set; }
        public int Thoigianbaohanh { get; set; }
        public string? Ghichu { get; set; }
        public string? Anh { get; set; }


        public required Loai Loai { get; set; }
        public required KhoiLuong KhoiLuong { get; set; }
        public required HangSX HangSX { get; set; }
        public required ChatLieu ChatLieu { get; set; }
        public required NuocSX NuocSX { get; set; }
        public required CongDung CongDung { get; set; }
        public required MauSac MauSac { get; set; }
        public required Mua Mua { get; set; }
        public required ICollection<ChiTietHDN> ChiTietHDNs { get; set; }


    }
}
