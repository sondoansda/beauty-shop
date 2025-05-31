using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblloai")]
    public class Loai
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }


    }
}