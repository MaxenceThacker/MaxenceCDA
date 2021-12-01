using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Aviation.Data.Models
{
    public partial class aviationContext : DbContext
    {
        public aviationContext()
        {
        }

        public aviationContext(DbContextOptions<aviationContext> options) : base(options)
        {
        }

        public virtual DbSet<Agence> Agences { get; set; }
        public virtual DbSet<Apparteniragence> Apparteniragences { get; set; }
        public virtual DbSet<Avion> Avions { get; set; }
        public virtual DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Name=Default");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agence>(entity =>
            {
                entity.HasKey(e => e.IdAgence)
                    .HasName("PRIMARY");

                entity.ToTable("agences");

                entity.Property(e => e.IdAgence).HasColumnType("int(11)");

                entity.Property(e => e.NomAgence).HasMaxLength(50);
            });

            modelBuilder.Entity<Apparteniragence>(entity =>
            {
                entity.HasKey(e => e.IdAppartenirAgences)
                    .HasName("PRIMARY");

                entity.ToTable("apparteniragences");

                entity.HasIndex(e => e.IdAgence, "FK_AppartenirAgences_Agence");

                entity.HasIndex(e => e.IdClient, "FK_AppartenirAgences_Client");

                entity.Property(e => e.IdAppartenirAgences).HasColumnType("int(11)");

                entity.Property(e => e.IdAgence).HasColumnType("int(11)");

                entity.Property(e => e.IdClient).HasColumnType("int(11)");

                entity.HasOne(d => d.IdAgenceNavigation)
                    .WithMany(p => p.Apparteniragences)
                    .HasForeignKey(d => d.IdAgence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppartenirAgences_Agence");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Apparteniragences)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppartenirAgences_Client");
            });

            modelBuilder.Entity<Avion>(entity =>
            {
                entity.HasKey(e => e.IdAvion)
                    .HasName("PRIMARY");

                entity.ToTable("avions");

                entity.HasIndex(e => e.IdAgence, "FK_Tournees_Agence");

                entity.Property(e => e.IdAvion).HasColumnType("int(11)");

                entity.Property(e => e.IdAgence).HasColumnType("int(11)");

                entity.Property(e => e.TypeAvion).HasMaxLength(50);

                entity.HasOne(d => d.IdAgenceNavigation)
                    .WithMany(p => p.Avions)
                    .HasForeignKey(d => d.IdAgence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Tournees_Agence");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PRIMARY");

                entity.ToTable("clients");

                entity.Property(e => e.IdClient).HasColumnType("int(11)");

                entity.Property(e => e.NomClient).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
