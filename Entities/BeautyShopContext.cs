using Microsoft.EntityFrameworkCore;

namespace beauty_shop.Model
{
    public class BeautyShopContext : DbContext
    {

        public DbSet<Loai> tblLoai { get; set; }
        public DbSet<KhoiLuong> KhoiLuong { get; set; }
        public DbSet<HangSX> HangSX { get; set; }
        public DbSet<ChatLieu> ChatLieu { get; set; }
        public DbSet<NuocSX> NuocSX { get; set; }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<CongDung> CongDung { get; set; }
        public DbSet<Mua> Mua { get; set; }
        public DbSet<DMHangHoa> DMHangHoa { get; set; }
        public DbSet<CongViec> CongViec { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<HoaDonBan> HoaDonBan { get; set; }
        public DbSet<ChiTietHDB> ChiTietHDB { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhap { get; set; }
        public DbSet<ChiTietHDN> ChiTietHDN { get; set; }

        public BeautyShopContext(DbContextOptions<BeautyShopContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=sql3.freesqldatabase.com;port=3306;database=sql3781960;user=sql3781960;password=3deQ7zieYl;";
                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(10, 4, 32)));
            }
        }
        public BeautyShopContext() : base()
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary Keys

            modelBuilder.Entity<Loai>().HasKey(l => l.MaLoai);
            modelBuilder.Entity<KhoiLuong>().HasKey(k => k.MaKhoiLuong);
            modelBuilder.Entity<HangSX>().HasKey(h => h.MaHangSX);
            modelBuilder.Entity<ChatLieu>().HasKey(c => c.MaChatLieu);
            modelBuilder.Entity<NuocSX>().HasKey(n => n.MaNuocSX);
            modelBuilder.Entity<MauSac>().HasKey(m => m.MaMau);
            modelBuilder.Entity<CongDung>().HasKey(c => c.MaCongDung);
            modelBuilder.Entity<Mua>().HasKey(m => m.MaMua);
            modelBuilder.Entity<DMHangHoa>().HasKey(d => d.MaHang);
            modelBuilder.Entity<CongViec>().HasKey(c => c.MaCV);
            modelBuilder.Entity<NhanVien>().HasKey(n => n.MaNV);
            modelBuilder.Entity<KhachHang>().HasKey(k => k.MaKhach);
            modelBuilder.Entity<NhaCungCap>().HasKey(n => n.MaNCC);
            modelBuilder.Entity<HoaDonBan>().HasKey(h => h.SoHDB);
            modelBuilder.Entity<ChiTietHDB>().HasKey(c => new { c.SoHDB, c.MaHang });
            modelBuilder.Entity<HoaDonNhap>().HasKey(h => h.SoHDN);
            modelBuilder.Entity<ChiTietHDN>().HasKey(c => new { c.SoHDN, c.MaHang });

            // Foreign Keys
            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.Loai)
                .WithMany()
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.KhoiLuong)
                .WithMany()
                .HasForeignKey(d => d.MaKhoiLuong)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.HangSX)
                .WithMany()
                .HasForeignKey(d => d.MaHangSX)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.ChatLieu)
                .WithMany()
                .HasForeignKey(d => d.MaChatLieu)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.NuocSX)
                .WithMany()
                .HasForeignKey(d => d.MaNuocSX)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.MauSac)
                .WithMany()
                .HasForeignKey(d => d.MaMau)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
    .HasOne(d => d.CongDung)
    .WithMany(c => c.DMHangHoas)
    .HasForeignKey(d => d.MaCongDung)
    .HasConstraintName("FK_DMHangHoa_CongDung"); // tên constraint tùy chọn



            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.Mua)
                .WithMany()
                .HasForeignKey(d => d.MaMua)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<NhanVien>()
                .HasOne(n => n.CongViec)
                .WithMany()
                .HasForeignKey(n => n.MaCV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonBan>()
                .HasOne(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.MaNV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonBan>()
                .HasOne(h => h.KhachHang)
                .WithMany()
                .HasForeignKey(h => h.MaKhach)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(c => c.HoaDonBan)
                .WithMany(h => h.ChiTietHDBs)
                .HasForeignKey(c => c.SoHDB)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(c => c.DMHangHoa)
                .WithMany()
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.MaNV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(h => h.NhaCungCap)
                .WithMany()
                .HasForeignKey(h => h.MaNCC)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietHDN>()
                .HasOne(c => c.HoaDonNhap)
                .WithMany(h => h.ChiTietHDNs)
                .HasForeignKey(c => c.SoHDN)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDN>()
                .HasOne(c => c.DMHangHoa)
                .WithMany()
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}