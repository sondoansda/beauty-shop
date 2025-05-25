namespace beauty_shop.Model
{
    public class DMHangHoa
    {
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string MaLoai { get; set; }
        public string MaKhoiLuong { get; set; }
        public string MaHangSX { get; set; }
        public string MaChatLieu { get; set; }
        public string MaNuocSX { get; set; }
        public string MaMau { get; set; }
        public string MaCongDung { get; set; }
        public string MaMua { get; set; }
        public int SoLuong { get; set; }
        public decimal Giaban { get; set; }
        public decimal Gianhap { get; set; }
        public int Thoigianbaohanh { get; set; }
        public string Ghichu { get; set; }
        public string Anh { get; set; }


        public Loai Loai { get; set; }
        public KhoiLuong KhoiLuong { get; set; }
        public HangSX HangSX { get; set; }
        public ChatLieu ChatLieu { get; set; }
        public NuocSX NuocSX { get; set; }
        public CongDung CongDung { get; set; }
        public MauSac MauSac { get; set; }
        public Mua Mua { get; set; }
        public ICollection<ChiTietHDN> ChiTietHDNs { get; set; }


    }
}
