using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project_1.Models
{
    public partial class EMSdatabaseContext : DbContext
    {
        public EMSdatabaseContext()
        {
        }

        public EMSdatabaseContext(DbContextOptions<EMSdatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DeptMaster> DeptMasters { get; set; } = null!;
        public virtual DbSet<EmpProfile> EmpProfiles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-U064AL2;database=EMSdatabase;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeptMaster>(entity =>
            {
                entity.HasKey(e => e.DeptCode)
                    .HasName("PK__DeptMast__BB9B955122785A77");

                entity.ToTable("DeptMaster");

                entity.Property(e => e.DeptCode).ValueGeneratedNever();

                entity.Property(e => e.DeptName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpProfile>(entity =>
            {
                entity.HasKey(e => e.EmpCode)
                    .HasName("PK__EmpProfi__7DA847CB85A9D4D3");

                entity.ToTable("EmpProfile");

                entity.Property(e => e.EmpCode).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.DeptCodeNavigation)
                    .WithMany(p => p.EmpProfiles)
                    .HasForeignKey(d => d.DeptCode)
                    .HasConstraintName("FK__EmpProfil__DeptC__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
