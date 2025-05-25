namespace beauty_shop.Model
{
    public class CongViec
    {
        public string MaCV { get; set; }
        public string TenCV { get; set; }
        public int Mucluong { get; set; }

        public ICollection<NhanVien> NhanViens { get; set; }

    }
}
