using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScrumProject.Models
{
    public partial class Scrum_StudentAccomodationContext : DbContext
    {
        public Scrum_StudentAccomodationContext()
        {
        }

        public Scrum_StudentAccomodationContext(DbContextOptions<Scrum_StudentAccomodationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseType> HouseType { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Scrum_StudentAccomodation;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdAcc);

                entity.Property(e => e.IdAcc)
                    .HasColumnName("ID_Acc")
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<House>(entity =>
            {
                entity.HasKey(e => e.IdHouse);

                entity.Property(e => e.IdHouse)
                    .HasColumnName("ID_House")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adress).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.IdAcc).HasColumnName("ID_Acc");

                entity.Property(e => e.IdType).HasColumnName("ID_Type");

                entity.Property(e => e.Price).HasMaxLength(10);

                entity.HasOne(d => d.IdAccNavigation)
                    .WithMany(p => p.House)
                    .HasForeignKey(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_House_Account");

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.House)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_House_HouseType1");
            });

            modelBuilder.Entity<HouseType>(entity =>
            {
                entity.HasKey(e => e.IdType);

                entity.Property(e => e.IdType)
                    .HasColumnName("ID_Type")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdAcc);

                entity.Property(e => e.IdAcc)
                    .HasColumnName("ID_Acc")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.HasOne(d => d.IdAccNavigation)
                    .WithOne(p => p.User)
                    .HasForeignKey<User>(d => d.IdAcc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Account1");
            });
        }
    }
}
