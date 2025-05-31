using Microsoft.EntityFrameworkCore;

namespace beauty_shop.Model
{
    public class BeautyShopContext : DbContext
    {
        // === DbSet Properties ===
        public DbSet<Loai> Loai { get; set; }
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

        // === Constructors ===
        public BeautyShopContext() : base() { }

        public BeautyShopContext(DbContextOptions<BeautyShopContext> options) : base(options) { }

        // === Connection Configuration ===
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=sql3.freesqldatabase.com;port=3306;database=sql3781960;user=sql3781960;password=3deQ7zieYl;";
                optionsBuilder.UseMySql(
                    connectionString,
                    new MySqlServerVersion(new Version(10, 4, 32)),
                    options => options.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null
                    )
                );
            }
        }

        // === Model Mapping ===
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- Primary Keys ---
            modelBuilder.Entity<Loai>().HasKey(e => e.MaLoai);
            modelBuilder.Entity<KhoiLuong>().HasKey(e => e.MaKhoiLuong);
            modelBuilder.Entity<HangSX>().HasKey(e => e.MaHangSX);
            modelBuilder.Entity<ChatLieu>().HasKey(e => e.MaChatLieu);
            modelBuilder.Entity<NuocSX>().HasKey(e => e.MaNuocSX);
            modelBuilder.Entity<MauSac>().HasKey(e => e.MaMau);
            modelBuilder.Entity<CongDung>().HasKey(e => e.MaCongDung);
            modelBuilder.Entity<Mua>().HasKey(e => e.MaMua);
            modelBuilder.Entity<DMHangHoa>().HasKey(e => e.MaHang);
            modelBuilder.Entity<CongViec>().HasKey(e => e.Macongviec);
            modelBuilder.Entity<NhanVien>().HasKey(e => e.Manhanvien);
            modelBuilder.Entity<KhachHang>().HasKey(e => e.MaKhach);
            modelBuilder.Entity<NhaCungCap>().HasKey(e => e.MaNCC);
            modelBuilder.Entity<HoaDonBan>().HasKey(e => e.SoHDB);
            modelBuilder.Entity<HoaDonNhap>().HasKey(e => e.SoHDN);
            modelBuilder.Entity<ChiTietHDB>().HasKey(e => new { e.SoHDB, e.MaHang });
            modelBuilder.Entity<ChiTietHDN>().HasKey(e => new { e.SoHDN, e.MaHang });

            // --- Relationships ---
            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.Loai)
                .WithMany()
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.KhoiLuong)
                .WithMany()
                .HasForeignKey(d => d.MaKhoiLuong)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.HangSX)
                .WithMany()
                .HasForeignKey(d => d.MaHangSX)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.ChatLieu)
                .WithMany()
                .HasForeignKey(d => d.MaChatLieu)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.NuocSX)
                .WithMany()
                .HasForeignKey(d => d.MaNuocSX)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.MauSac)
                .WithMany()
                .HasForeignKey(d => d.MaMau)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.CongDung)
                .WithMany(c => c.DMHangHoas)
                .HasForeignKey(d => d.MaCongDung);



            modelBuilder.Entity<DMHangHoa>()
                .HasOne(d => d.Mua)
                .WithMany()
                .HasForeignKey(d => d.MaMua)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<NhanVien>()
                .HasOne(nv => nv.CongViec)
                .WithMany(cv => cv.NhanViens)
                .HasForeignKey(nv => nv.Macongviec)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<HoaDonBan>()
                .HasOne(h => h.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.Manhanvien)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<HoaDonBan>()
            .HasOne(h => h.KhachHang)
              .WithMany()
              .HasForeignKey(h => h.MaKhach)
                  .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(c => c.HoaDonBan)
                .WithMany(h => h.ChiTietHDBs)
                .HasForeignKey(c => c.SoHDB)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(c => c.DMHangHoa)
                .WithMany()
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.SetNull);

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
