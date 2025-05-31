using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblhangsx")]
    public class HangSX
    {
        public string MaHangSX { get; set; }
        public string TenHangSX { get; set; }
    }
}