using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BiuroWycenyAPI.Models
{
    public partial class pd3100Context : DbContext
    {
        public pd3100Context()
        {
        }

        public pd3100Context(DbContextOptions<pd3100Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cennik> Cennik { get; set; }
        public virtual DbSet<Rzeczoznawca> Rzeczoznawca { get; set; }
        public virtual DbSet<Zlecenie> Zlecenie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=pd3100;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cennik>(entity =>
            {
                entity.Property(e => e.Cena).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Typ)
                    .HasColumnName("TYP")
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rzeczoznawca>(entity =>
            {
                entity.Property(e => e.Imie)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zlecenie>(entity =>
            {
                entity.Property(e => e.Adres)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataZlecenia).HasColumnType("date");

                entity.Property(e => e.Imie)
                    .HasColumnName("IMIE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasColumnName("MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Miasto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .HasColumnName("NAZWISKO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCennikNavigation)
                    .WithMany(p => p.Zlecenie)
                    .HasForeignKey(d => d.IdCennik)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ZLECENIE_CENNIK");

                entity.HasOne(d => d.IdRzeczoznawcaNavigation)
                    .WithMany(p => p.Zlecenie)
                    .HasForeignKey(d => d.IdRzeczoznawca)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ZLECENIE_Rzeczoznawca");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
