using Microsoft.EntityFrameworkCore;
namespace beauty_shop.Model
{
    public class BeautyShopContext : DbContext
    {
        public DbSet<Loai> Loais { get; set; }
        public DbSet<KhoiLuong> KhoiLuongs { get; set; }
        public DbSet<HangSX> HangSXes { get; set; }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<NuocSX> NuocSXes { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<CongDung> CongDungs { get; set; }
        public DbSet<Mua> Muas { get; set; }
        public DbSet<DMHangHoa> DMHangHoas { get; set; }
        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<HoaDonBan> HoaDonBans { get; set; }
        public DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<ChiTietHDN> ChiTietHDNs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Đổi chuỗi kết nối cho phù hợp, vd: MySQL, SQL Server...
            var connectionString = "server=localhost;port=3306;database=QuanLyCuaHangMyPham;user=root;password=;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 31)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa khóa chính cho từng entity
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

            // Định nghĩa các khóa ngoại tương ứng

            // DMHangHoa
            modelBuilder.Entity<DMHangHoa>()
                .HasOne(l => l.Loai)
                .WithMany()
                .HasForeignKey(d => d.MaLoai)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(k => k.KhoiLuong)
                .WithMany()
                .HasForeignKey(d => d.MaKhoiLuong)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(h => h.HangSX)
                .WithMany()
                .HasForeignKey(d => d.MaHangSX)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(c => c.ChatLieu)
                .WithMany()
                .HasForeignKey(d => d.MaChatLieu)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(n => n.NuocSX)
                .WithMany()
                .HasForeignKey(d => d.MaNuocSX)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(m => m.MauSac)
                .WithMany()
                .HasForeignKey(d => d.MaMau)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(c => c.CongDung)
                .WithMany()
                .HasForeignKey(d => d.MaCongDung)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DMHangHoa>()
                .HasOne(m => m.Mua)
                .WithMany()
                .HasForeignKey(d => d.MaMua)
                .OnDelete(DeleteBehavior.Restrict);

            // NhanVien - CongViec
            modelBuilder.Entity<NhanVien>()
                .HasOne(c => c.CongViec)
                .WithMany()
                .HasForeignKey(n => n.MaCV)
                .OnDelete(DeleteBehavior.Restrict);

            // HoaDonBan - NhanVien, KhachHang
            modelBuilder.Entity<HoaDonBan>()
                .HasOne(n => n.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.MaNV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonBan>()
                .HasOne(k => k.KhachHang)
                .WithMany()
                .HasForeignKey(h => h.MaKhach)
                .OnDelete(DeleteBehavior.Restrict);

            // ChiTietHDB - HoaDonBan, DMHangHoa
            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(h => h.HoaDonBan)
                .WithMany(hd => hd.ChiTietHDBs)
                .HasForeignKey(c => c.SoHDB)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDB>()
                .HasOne(d => d.DMHangHoa)
                .WithMany()
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);

            // HoaDonNhap - NhanVien, NhaCungCap
            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(nv => nv.NhanVien)
                .WithMany()
                .HasForeignKey(h => h.MaNV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDonNhap>()
                .HasOne(ncc => ncc.NhaCungCap)
                .WithMany()
                .HasForeignKey(h => h.MaNCC)
                .OnDelete(DeleteBehavior.Restrict);

            // ChiTietHDN - HoaDonNhap, DMHangHoa
            modelBuilder.Entity<ChiTietHDN>()
                .HasOne(h => h.HoaDonNhap)
                .WithMany(hdn => hdn.ChiTietHDNs)
                .HasForeignKey(c => c.SoHDN)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ChiTietHDN>()
                .HasOne(d => d.DMHangHoa)
                .WithMany()
                .HasForeignKey(c => c.MaHang)
                .OnDelete(DeleteBehavior.Restrict);

            // Bạn có thể thêm các thiết lập khác nếu cần (ví dụ: bảng nhiều-nhiều)

        }
    }
}
