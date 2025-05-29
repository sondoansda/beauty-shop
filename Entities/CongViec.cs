using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblcongviec")]
    public class CongViec
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public int Mucluong { get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }

    }
}
