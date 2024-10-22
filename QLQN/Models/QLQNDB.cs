using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLQN.Models
{
    public partial class QLQNDB : DbContext
    {
        public QLQNDB()
            : base("name=QLQNDB")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<Nuoc> Nuocs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaNC)
                .IsFixedLength();

            modelBuilder.Entity<Loai>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<Loai>()
                .HasMany(e => e.Nuocs)
                .WithRequired(e => e.Loai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nuoc>()
                .Property(e => e.MaNC)
                .IsFixedLength();

            modelBuilder.Entity<Nuoc>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<Nuoc>()
                .HasMany(e => e.ChiTietHoaDons)
                .WithRequired(e => e.Nuoc)
                .WillCascadeOnDelete(false);
        }
    }
}
