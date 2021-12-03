using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GestionProjet.Data.Models
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

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Typesproduit> Typesproduits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost;user=root;database=gestionstocks;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.IdArticles)
                    .HasName("PRIMARY");

                entity.ToTable("articles");

                entity.HasIndex(e => e.IdCategories, "FK_IdCategories");

                entity.Property(e => e.IdArticles).HasColumnType("int(11)");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.LibelleArticle).HasMaxLength(100);

                entity.Property(e => e.QuatiteStockee).HasColumnType("int(11)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.IdCategories)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdCategories");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategories)
                    .HasName("PRIMARY");

                entity.ToTable("categories");

                entity.HasIndex(e => e.IdTypesProduits, "FK_IdTypesProduits");

                entity.Property(e => e.IdCategories).HasColumnType("int(11)");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleCategorie).HasMaxLength(100);

                entity.HasOne(d => d.Typesproduit)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.IdTypesProduits)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdTypesProduits");
            });

            modelBuilder.Entity<Typesproduit>(entity =>
            {
                entity.HasKey(e => e.IdTypesProduits)
                    .HasName("PRIMARY");

                entity.ToTable("typesproduits");

                entity.Property(e => e.IdTypesProduits).HasColumnType("int(11)");

                entity.Property(e => e.LibelleTypeProduit).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
