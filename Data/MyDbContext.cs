using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options): base(options) { }
        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<ChiTietHD> ChiTietHD { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<HoaDon>(e =>
            {
                e.ToTable("HoaDon");
                e.HasKey(hd => hd.MaHD);
                e.Property(hd => hd.NgayDat).HasDefaultValueSql("getutcdate()");
            });

            model.Entity<ChiTietHD>(e =>
            {
                e.ToTable("ChiTietHD");
                e.HasKey(e=> new {e.MaHD,e.MaHH});


                e.HasOne(e => e.HoaDon)
                .WithMany(e => e.chiTietHDs)
                .HasForeignKey(e => e.MaHD)
                .HasConstraintName("FK_CTHD_HoaDon");

                e.HasOne(e => e.HangHoa)
                .WithMany(e => e.chiTietHDs)
                .HasForeignKey(e => e.MaHH)
                .HasConstraintName("FK_CTHD_HangHoa");
            });
        }
    }
}
