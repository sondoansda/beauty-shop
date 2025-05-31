using System.ComponentModel.DataAnnotations.Schema;

namespace beauty_shop.Model
{
    [Table("tblchatlieu")]
    public class ChatLieu
    {
        public string MaChatLieu { get; set; }
        public string? TenChatLieu { get; set; }
    }
}