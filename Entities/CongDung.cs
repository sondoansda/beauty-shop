namespace beauty_shop.Model
{
    public class CongDung
    {
        public string MaCongDung { get; set; }
        public string TenCongDung { get; set; }

        public ICollection<DMHangHoa> DMHangHoas { get; set; }

    }
}
