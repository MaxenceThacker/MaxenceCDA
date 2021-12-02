using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using GestionProjet.Data.Models;

#nullable disable

namespace GestionProjet.Data
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

        public virtual DbSet<article> articles { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<typesproduit> typesproduits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost;user=root;database=gestionstocks;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<article>(entity =>
            {
                entity.HasKey(e => e.IdArticles)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCategories, "FK_IdCategories");

                entity.Property(e => e.IdArticles).HasColumnType("int(11)");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.LibelleArticle).HasMaxLength(100);

                entity.Property(e => e.QuatiteStockee).HasColumnType("int(11)");

                entity.HasOne(d => d.IdCategoriesNavigation)
                    .WithMany(p => p.articles)
                    .HasForeignKey(d => d.IdCategories)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCategories");
            });

            modelBuilder.Entity<category>(entity =>
            {
                entity.HasKey(e => e.IdCategories)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdTypesProduits, "FK_IdTypesProduits");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleCategorie).HasMaxLength(100);

                entity.HasOne(d => d.IdTypesProduitsNavigation)
                    .WithMany(p => p.categories)
                    .HasForeignKey(d => d.IdTypesProduits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdTypesProduits");
            });

            modelBuilder.Entity<typesproduit>(entity =>
            {
                entity.HasKey(e => e.IdTypesProduits)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleTypeProduit).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
