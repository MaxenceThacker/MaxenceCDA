using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ECF2.Data.Models;

#nullable disable

namespace ECF2.Data
{
    public partial class Ecf2Context : DbContext
    {
        public Ecf2Context()
        {
        }

        public Ecf2Context(DbContextOptions<Ecf2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Chambre> Chambres { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=ecf2;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chambre>(entity =>
            {
                entity.HasKey(e => e.IdChambre)
                    .HasName("PRIMARY");

                entity.ToTable("chambres");

                entity.HasIndex(e => e.IdHotel, "FK_chambres_hotels");

                entity.Property(e => e.IdChambre)
                    .HasColumnType("int(11)")
                    .HasColumnName("idChambre");

                entity.Property(e => e.CapaciteChambre)
                    .HasColumnType("int(11)")
                    .HasColumnName("capaciteChambre");

                entity.Property(e => e.IdHotel)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHotel");

                entity.Property(e => e.NumChambre)
                    .HasColumnType("int(11)")
                    .HasColumnName("numChambre");

                entity.Property(e => e.TypeChambre)
                    .HasColumnType("int(11)")
                    .HasColumnName("typeChambre");

                entity.HasOne(d => d.HotelAssocie)
                    .WithMany(p => p.ListeChambres)
                    .HasForeignKey(d => d.IdHotel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chambres_hotels");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.IdHotel)
                    .HasName("PRIMARY");

                entity.ToTable("hotels");

                entity.Property(e => e.IdHotel)
                    .HasColumnType("int(11)")
                    .HasColumnName("idHotel");

                entity.Property(e => e.AdresseHotel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adresseHotel");

                entity.Property(e => e.CategorieHotel)
                    .HasColumnType("int(11)")
                    .HasColumnName("categorieHotel");

                entity.Property(e => e.NomHotel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nomHotel");

                entity.Property(e => e.VilleHotel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("villeHotel");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
