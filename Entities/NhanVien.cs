using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblnhanvien")]
    public class NhanVien
    {
        [Key]
        [Column("Manhanvien")]
        public string Manhanvien { get; set; }

        [Column("Tennhanvien")]
        public string? Tennhanvien { get; set; }

        [Column("Gioitinh")]
        public string? Gioitinh { get; set; }

        [Column("Dienthoai")]
        public string? Dienthoai { get; set; }

        [Column("Ngaysinh")]
        public DateTime Ngaysinh { get; set; }

        [Column("Diachi")]
        public string? Diachi { get; set; }

        [Column("Macongviec")]
        public string? Macongviec { get; set; }

        [ForeignKey("Macongviec")]
        public CongViec? CongViec { get; set; }

        [Column("TaiKhoan")]
        public string? TaiKhoan { get; set; }

        [Column("MatKhau")]
        public string? MatKhau { get; set; }

        public ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
