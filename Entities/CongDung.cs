using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblcongdung")]
    public class CongDung
    {
        public string MaCongDung { get; set; }
        public string TenCongDung { get; set; }

        public ICollection<DMHangHoa> DMHangHoas { get; set; }
    }
}