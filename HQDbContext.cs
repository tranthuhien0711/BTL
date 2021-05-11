using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTLQLBHHQ1.Models
{
    public partial class HQDbContext : DbContext
    {
        public HQDbContext()
            : base("name=HQDbContext")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ChatLieu> ChatLieus { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatLieu>()
                .Property(e => e.ChatLieuID)
                .IsUnicode(false);
            modelBuilder.Entity<ChatLieu>()
                .Property(e => e.KieuDang)
                .IsUnicode(false);
        }
    }
}
