using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblmausac")]
    public class MauSac
    {
        public string MaMau { get; set; }
        public string TenMau { get; set; }


    }
}