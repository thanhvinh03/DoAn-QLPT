using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace P1.Models
{
    public partial class QLPTContextDB : DbContext
    {
        public QLPTContextDB()
            : base("name=QLPTContextDB1")
        {
        }

        public virtual DbSet<CT_DICHVU> CT_DICHVU { get; set; }
        public virtual DbSet<CT_DSKHACHHANG> CT_DSKHACHHANG { get; set; }
        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CT_HOPDONG> CT_HOPDONG { get; set; }
        public virtual DbSet<CT_TIENNGHI> CT_TIENNGHI { get; set; }
        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<HOPDONG> HOPDONG { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<KHUCVUC> KHUCVUC { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONG { get; set; }
        public virtual DbSet<LOAITIENNGHI> LOAITIENNGHI { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TIENICH> TIENICH { get; set; }
        public virtual DbSet<TIENNGHI> TIENNGHI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_DICHVU>()
                .Property(e => e.MADICHVU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DICHVU>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DSKHACHHANG>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DSKHACHHANG>()
                .Property(e => e.IDPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_DSKHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MAHOADON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.IDPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MATIENICH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.CHISOCU)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.CHISOMOI)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.TONGSO)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CT_HOPDONG>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOPDONG>()
                .Property(e => e.IDPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOPDONG>()
                .HasMany(e => e.CT_DSKHACHHANG)
                .WithRequired(e => e.CT_HOPDONG)
                .HasForeignKey(e => new { e.MAHD, e.IDPHONG })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_TIENNGHI>()
                .Property(e => e.MATIENNGHI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CT_TIENNGHI>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MADICHVU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.DICHVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHOADON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONG>()
                .Property(e => e.MAHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.CT_DICHVU)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.CT_HOPDONG)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOPDONG>()
                .HasMany(e => e.CT_TIENNGHI)
                .WithRequired(e => e.HOPDONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CCCD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DIENTHOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.CT_DSKHACHHANG)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUCVUC>()
                .Property(e => e.MAKV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHUCVUC>()
                .HasMany(e => e.PHONG)
                .WithRequired(e => e.KHUCVUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAIPHONG>()
                .Property(e => e.IDLOAIPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAIPHONG>()
                .HasMany(e => e.PHONG)
                .WithRequired(e => e.LOAIPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITIENNGHI>()
                .Property(e => e.MALOAITIENNGHI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAITIENNGHI>()
                .HasMany(e => e.TIENNGHI)
                .WithRequired(e => e.LOAITIENNGHI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.IDPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.MAKV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.IDLOAIPHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CT_HOPDONG)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIENICH>()
                .Property(e => e.MATIENICH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIENICH>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.TIENICH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIENNGHI>()
                .Property(e => e.MATIENNGHI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIENNGHI>()
                .Property(e => e.MALOAITIENNGHI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIENNGHI>()
                .HasMany(e => e.CT_TIENNGHI)
                .WithRequired(e => e.TIENNGHI)
                .WillCascadeOnDelete(false);
        }
    }
}
