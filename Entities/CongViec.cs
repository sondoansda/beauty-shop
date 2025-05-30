using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblcongviec")]
    public class CongViec
    {
        [Key]
        [Column("macongviec")]
        public string Macongviec { get; set; }

        [Column("tencongviec")]
        public string Tencongviec { get; set; }

        [Column("mucluong")]
        public int Mucluong { get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }
    }
}
