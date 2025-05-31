using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblmua")]
    public class Mua
    {
        public string MaMua { get; set; }
        public string TenMua { get; set; }


    }
}