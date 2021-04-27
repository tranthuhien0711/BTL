using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace btlquanli.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode (false);
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.KhachHangID)
                .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.SoLuong)
                .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.HangHoaID)
                .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonGia)
                .IsUnicode(false);
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.HoaDonID)
                .IsUnicode(false);
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayBan)
                .IsUnicode(false);
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.NhanVienID)
                .IsUnicode(false);
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDTNV)
                .IsUnicode(false);
        }
    }
}
