namespace QuanLyDT.Repositories.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ChiTietSuDung> ChiTietSuDungs { get; set; }
        public virtual DbSet<GiaCuoc> GiaCuocs { get; set; }
        public virtual DbSet<HoaDonDangKy> HoaDonDangKies { get; set; }
        public virtual DbSet<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThongTinSim> ThongTinSims { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.SoPhut7h23h)
                .HasPrecision(19, 3);

            modelBuilder.Entity<ChiTietSuDung>()
                .Property(e => e.SoPhut23h7h)
                .HasPrecision(19, 3);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.MaGiaCuoc)
                .IsUnicode(false);

            modelBuilder.Entity<GiaCuoc>()
                .Property(e => e.Giacuoc1)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.MaHDDK)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonDangKy>()
                .Property(e => e.ChiPhiDK)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.MaHDTC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.PhiHangThang)
                .HasPrecision(19, 3);

            modelBuilder.Entity<HoaDonTinhCuoc>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 3);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSim>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinSim>()
                .Property(e => e.MaKH)
                .IsUnicode(false);
        }
    }
}
