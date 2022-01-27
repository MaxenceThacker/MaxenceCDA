using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Cinema.Data.Models;

#nullable disable

namespace Cinema.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Salle> Salles { get; set; }
        public virtual DbSet<Seance> Seances { get; set; }
        public virtual DbSet<Texte> Textes { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=cinema;port=3306;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>(entity =>
            {
                entity.HasKey(e => e.IdFilm)
                    .HasName("PRIMARY");

                entity.ToTable("films");

                entity.HasIndex(e => e.LibelleFilm, "libelleFilm")
                    .IsUnique();

                entity.Property(e => e.IdFilm)
                    .HasColumnType("int(11)")
                    .HasColumnName("idFilm");

                entity.Property(e => e.DureeMinuteFilm)
                    .HasColumnType("int(11)")
                    .HasColumnName("dureeMinuteFilm");

                entity.Property(e => e.LibelleFilm)
                    .HasMaxLength(50)
                    .HasColumnName("libelleFilm");
            });

            modelBuilder.Entity<Salle>(entity =>
            {
                entity.HasKey(e => e.IdSalle)
                    .HasName("PRIMARY");

                entity.ToTable("salles");

                entity.Property(e => e.IdSalle)
                    .HasColumnType("int(11)")
                    .HasColumnName("idSalle");

                entity.Property(e => e.NbrPlaceSalle)
                    .HasColumnType("int(11)")
                    .HasColumnName("nbrPlaceSalle");
            });

            modelBuilder.Entity<Seance>(entity =>
            {
                entity.HasKey(e => e.IdSeance)
                    .HasName("PRIMARY");

                entity.ToTable("seances");

                entity.HasIndex(e => e.IdFilm, "idFilm");

                entity.HasIndex(e => e.IdSalle, "idSalle");

                entity.Property(e => e.IdSeance)
                    .HasColumnType("int(11)")
                    .HasColumnName("idSeance");

                entity.Property(e => e.DateSeance).HasColumnName("dateSeance");

                entity.Property(e => e.HoraireSeance).HasColumnName("horaireSeance");

                entity.Property(e => e.IdFilm)
                    .HasColumnType("int(11)")
                    .HasColumnName("idFilm");

                entity.Property(e => e.IdSalle)
                    .HasColumnType("int(11)")
                    .HasColumnName("idSalle");
            });

            modelBuilder.Entity<Texte>(entity =>
            {
                entity.HasKey(e => e.IdTexte)
                    .HasName("PRIMARY");

                entity.ToTable("textes");

                entity.Property(e => e.IdTexte)
                    .HasColumnType("int(11)")
                    .HasColumnName("idTexte");

                entity.Property(e => e.CodeTexte)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("codeTexte");

                entity.Property(e => e.En)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("en");

                entity.Property(e => e.Fr)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("fr");
            });

            modelBuilder.Entity<Utilisateur>(entity =>
            {
                entity.HasKey(e => e.IdUtilisateur)
                    .HasName("PRIMARY");

                entity.ToTable("utilisateurs");

                entity.HasIndex(e => e.AdresseMail, "adresseMail")
                    .IsUnique();

                entity.Property(e => e.IdUtilisateur)
                    .HasColumnType("int(11)")
                    .HasColumnName("idUtilisateur");

                entity.Property(e => e.AdresseMail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adresseMail");

                entity.Property(e => e.MotDePasse)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("motDePasse");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nom");

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prenom");

                entity.Property(e => e.Role)
                    .HasColumnType("int(11)")
                    .HasColumnName("role")
                    .HasComment("2 Admin 1 User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
