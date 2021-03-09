using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBH.Models
{
    public partial class QLBHDbContext : DbContext
    {
        public QLBHDbContext()
            : base("name=QLBHDbContext")
        {
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<HoaDonBH> HoaDonBHs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
