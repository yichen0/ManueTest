using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Manu.Models
{
    public partial class ManueContext : DbContext
    {
        public ManueContext()
        {
        }

        public ManueContext(DbContextOptions<ManueContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Manue> Manue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSI;Database=Manue;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manue>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.建立時間).HasColumnType("datetime");

                entity.Property(e => e.更新時間).HasColumnType("datetime");

                entity.Property(e => e.項目)
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
