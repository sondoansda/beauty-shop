using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tbldmhanghoa")]
    public class DMHangHoa
    {
        [Key]
        [Column("Mahang")]
        [StringLength(10)]
        public string MaHang { get; set; }

        [Column("Tenhanghoa")]
        [StringLength(50)]
        public string? TenHangHoa { get; set; }

        [Column("Maloai")]
        [StringLength(10)]
        public string? MaLoai { get; set; }

        [Column("Makhoiluong")]
        [StringLength(10)]
        public string? MaKhoiLuong { get; set; }

        [Column("Mahangsx")]
        [StringLength(10)]
        public string? MaHangSX { get; set; }

        [Column("Machatlieu")]
        [StringLength(10)]
        public string? MaChatLieu { get; set; }

        [Column("Manuocsx")]
        [StringLength(10)]
        public string? MaNuocSX { get; set; }

        [Column("Mamau")]
        [StringLength(10)]
        public string? MaMau { get; set; }

        [Column("Macongdung")]
        [StringLength(10)]
        public string? MaCongDung { get; set; }

        [Column("Mamua")]
        [StringLength(10)]
        public string? MaMua { get; set; }

        [Column("Soluong")]
        public int SoLuong { get; set; }

        [Column("Dongianhap")]
        public decimal DonGiaNhap { get; set; }

        [Column("Dongiaban")]
        public decimal DonGiaBan { get; set; }

        [Column("Anh")]
        [StringLength(200)]
        public string? Anh { get; set; }

        [Column("Ghichu")]
        [StringLength(100)]
        public string? GhiChu { get; set; }

        [Column("Thoigianbaohanh")]
        public int? ThoiGianBaoHanh { get; set; }



        public Loai? Loai { get; set; }



        public KhoiLuong? KhoiLuong { get; set; }



        public HangSX? HangSX { get; set; }



        public ChatLieu? ChatLieu { get; set; }



        public NuocSX? NuocSX { get; set; }


        public MauSac? MauSac { get; set; }



        public CongDung? CongDung { get; set; }



        public Mua? Mua { get; set; }

        public ICollection<ChiTietHDB> ChiTietHDBs { get; set; } = new List<ChiTietHDB>();
        public ICollection<ChiTietHDN> ChiTietHDNs { get; set; } = new List<ChiTietHDN>();
        public SanPhamDTO ConvertSanPhamDTO()
        {
            return new SanPhamDTO
            {
                MaHang = MaHang,
                TenHangHoa = TenHangHoa,
                TenLoai = Loai?.TenLoai,
                TenCongDung = CongDung?.TenCongDung,
                XuatXu = NuocSX.TenNUocSX,
                SoLuong = SoLuong,
                Gianhap = DonGiaNhap,
                Giaban = DonGiaBan,
                MauSac = MauSac?.TenMau,
                ChatLieu = ChatLieu?.TenChatLieu,
                HangSX = HangSX?.TenHangSX,
                Mua = Mua?.TenMua,
                Anh = Anh,
                GhiChu = GhiChu,
                ThoiGianBaoHanh = ThoiGianBaoHanh
            };
        }
    }
}