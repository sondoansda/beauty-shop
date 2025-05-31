using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblnuocsx")]
    public class NuocSX
    {
        public string MaNuocSX { get; set; }
        public string? TenNUocSX { get; set; }


    }
}