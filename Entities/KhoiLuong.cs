using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblkhoiluong")]
    public class KhoiLuong
    {
        public string MaKhoiLuong { get; set; }
        public string GiaTri { get; set; }
        public string DonVi { get; set; }


    }
}
