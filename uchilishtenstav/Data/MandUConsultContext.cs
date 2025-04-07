using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using uchilishtenstav.Data.Models;

namespace uchilishtenstav.Data
{
    public partial class MandUConsultContext : DbContext
    {
        public MandUConsultContext()
        {
        }

        public MandUConsultContext(DbContextOptions<MandUConsultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<Reminder> Reminders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MandUConsult;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContractDate).HasColumnType("date");

                entity.Property(e => e.Deposit).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.LandlordId).HasColumnName("LandlordID");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.TenantId).HasColumnName("TenantID");

                entity.HasOne(d => d.Landlord)
                    .WithMany(p => p.ContractLandlords)
                    .HasForeignKey(d => d.LandlordId)
                    .HasConstraintName("FK__Contracts__Landl__59FA5E80");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK__Contracts__Prope__5812160E");

                entity.HasOne(d => d.Tenant)
                    .WithMany(p => p.ContractTenants)
                    .HasForeignKey(d => d.TenantId)
                    .HasConstraintName("FK__Contracts__Tenan__59063A47");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.PropertyId)
                    .HasConstraintName("FK__Images__Property__5CD6CB2B");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.Phone, "UQ__People__5C7E359EB7EDE6BD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedPropertyId).HasColumnName("RelatedPropertyID");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SearchPreferences).HasColumnType("text");

                entity.HasOne(d => d.RelatedProperty)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.RelatedPropertyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__People__RelatedP__3B75D760");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Exposure)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Floor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Heating)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Kind)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Layout).HasColumnType("text");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Price).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.RentConditions).HasColumnType("text");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('active')");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Reminders__Perso__628FA481");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Reminders__Prope__619B8048");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
