using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Filrouge.Data.Models;

#nullable disable

namespace Filrouge.Data
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

        public virtual DbSet<Adresses> Adresses { get; set; }
        public virtual DbSet<Approvisionnements> Approvisionnements { get; set; }
        public virtual DbSet<CategoriesClient> CategoriesClients { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Commandes> Commandes { get; set; }
        public virtual DbSet<EtatsCommande> EtatsCommandes { get; set; }
        public virtual DbSet<Factures> Factures { get; set; }
        public virtual DbSet<Fournisseurs> Fournisseurs { get; set; }
        public virtual DbSet<Historiquetva> Historiquetvas { get; set; }
        public virtual DbSet<LignesCommande> LignesCommandes { get; set; }
        public virtual DbSet<Livraisons> Livraisons { get; set; }
        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Produits> Produits { get; set; }
        public virtual DbSet<ProgressionsCommande> ProgressionsCommandes { get; set; }
        public virtual DbSet<Reglements> Reglements { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rubriques> Rubriques { get; set; }
        public virtual DbSet<Tva> Tvas { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Villes> Villes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySQL("server=localhost;user=root;database=filrougebdd;ssl mode=none");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresses>(entity =>
            {
                entity.HasKey(e => e.IdAdresse)
                    .HasName("PRIMARY");

                entity.ToTable("adresses");

                entity.HasIndex(e => e.IdVille, "FK_Adresses_Villes");

                entity.Property(e => e.IdAdresse).HasColumnType("int(11)");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("adresse");

                entity.Property(e => e.ComplementAdresse)
                    .HasMaxLength(50)
                    .HasColumnName("complementAdresse");

                entity.Property(e => e.EmailAdresse)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("emailAdresse");

                entity.Property(e => e.IdVille).HasColumnType("int(11)");

                entity.Property(e => e.Province)
                    .HasMaxLength(50)
                    .HasColumnName("province");

                entity.Property(e => e.TelFixe)
                    .HasMaxLength(12)
                    .HasColumnName("telFixe");

                entity.Property(e => e.TelMobile)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("telMobile");
            });

            modelBuilder.Entity<Approvisionnements>(entity =>
            {
                entity.HasKey(e => e.IdApprovisionnement)
                    .HasName("PRIMARY");

                entity.ToTable("approvisionnements");

                entity.HasIndex(e => e.IdFournisseur, "FK_Approvisionnements_Fournisseurs");

                entity.HasIndex(e => e.IdProduit, "FK_Approvisionnements_Produits");

                entity.Property(e => e.IdApprovisionnement).HasColumnType("int(11)");

                entity.Property(e => e.IdFournisseur).HasColumnType("int(11)");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.RefFournisseur)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("refFournisseur");
            });

            modelBuilder.Entity<CategoriesClient>(entity =>
            {
                entity.HasKey(e => e.IdCategorieClient)
                    .HasName("PRIMARY");

                entity.ToTable("categoriesclient");

                entity.Property(e => e.IdCategorieClient).HasColumnType("int(11)");

                entity.Property(e => e.CoefCategClient)
                    .HasColumnType("int(11)")
                    .HasColumnName("coefCategClient");

                entity.Property(e => e.InfoReglement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("infoReglement");

                entity.Property(e => e.LibelleCategClient)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("libelleCategClient");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("clients");

                entity.HasIndex(e => e.IdCategorieClient, "FK_Clients_CategoriesClient");

                entity.HasIndex(e => e.RefClient, "refClient")
                    .IsUnique();

                entity.Property(e => e.IdUser).HasColumnType("int(11)");

                entity.Property(e => e.CoefClient)
                    .HasColumnType("int(11)")
                    .HasColumnName("coefClient");

                entity.Property(e => e.IdCategorieClient).HasColumnType("int(11)");

                entity.Property(e => e.RefClient)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("refClient");
            });

            modelBuilder.Entity<Commandes>(entity =>
            {
                entity.HasKey(e => e.IdCommande)
                    .HasName("PRIMARY");

                entity.ToTable("commandes");

                entity.HasIndex(e => e.IdAdresse, "FK_Commandes_Adresses");

                entity.HasIndex(e => e.IdUser, "FK_Commandes_Clients");

                entity.HasIndex(e => e.NumeroCommande, "NumeroCommande")
                    .IsUnique();

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.DateCommande)
                    .HasColumnType("date")
                    .HasColumnName("dateCommande");

                entity.Property(e => e.IdAdresse).HasColumnType("int(11)");

                entity.Property(e => e.IdUser).HasColumnType("int(11)");

                entity.Property(e => e.NumeroCommande).HasMaxLength(10);
            });

            modelBuilder.Entity<EtatsCommande>(entity =>
            {
                entity.HasKey(e => e.IdEtatCommande)
                    .HasName("PRIMARY");

                entity.ToTable("etatscommande");

                entity.Property(e => e.IdEtatCommande).HasColumnType("int(11)");

                entity.Property(e => e.LibelleEtatCommande)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("libelleEtatCommande");
            });

            modelBuilder.Entity<Factures>(entity =>
            {
                entity.HasKey(e => e.IdFacture)
                    .HasName("PRIMARY");

                entity.ToTable("factures");

                entity.HasIndex(e => e.IdCommande, "FK_Factures_Commandes");

                entity.HasIndex(e => e.IdReglement, "FK_Factures_Reglements");

                entity.Property(e => e.IdFacture).HasColumnType("int(11)");

                entity.Property(e => e.DatePaiement)
                    .HasColumnType("date")
                    .HasColumnName("datePaiement");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdReglement).HasColumnType("int(11)");

                entity.Property(e => e.MontantPaiement)
                    .HasColumnType("decimal(19,4)")
                    .HasColumnName("montantPaiement");
            });

            modelBuilder.Entity<Fournisseurs>(entity =>
            {
                entity.HasKey(e => e.IdFournisseur)
                    .HasName("PRIMARY");

                entity.ToTable("fournisseurs");

                entity.Property(e => e.IdFournisseur).HasColumnType("int(11)");

                entity.Property(e => e.NomFournisseur)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nomFournisseur");
            });

            modelBuilder.Entity<Historiquetva>(entity =>
            {
                entity.HasKey(e => e.IdHistoriqueTva)
                    .HasName("PRIMARY");

                entity.ToTable("historiquetva");

                entity.HasIndex(e => e.IdProduit, "FK_HistoriqueTVA_Produits");

                entity.HasIndex(e => e.IdTva, "FK_HistoriqueTVA_TVA");

                entity.Property(e => e.IdHistoriqueTva)
                    .HasColumnType("int(11)")
                    .HasColumnName("IdHistoriqueTVA");

                entity.Property(e => e.DateTva)
                    .HasColumnType("date")
                    .HasColumnName("dateTVA");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.IdTva)
                    .HasColumnType("int(11)")
                    .HasColumnName("IdTVA");
            });

            modelBuilder.Entity<LignesCommande>(entity =>
            {
                entity.HasKey(e => e.IdLigneCommande)
                    .HasName("PRIMARY");

                entity.ToTable("lignescommande");

                entity.HasIndex(e => e.IdProduit, "FK_LigneCommande_Produits");

                entity.HasIndex(e => e.IdCommande, "FK_LignesCommande_Commandes");

                entity.Property(e => e.IdLigneCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.QuantiteProduit)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantiteProduit");
            });

            modelBuilder.Entity<Livraisons>(entity =>
            {
                entity.HasKey(e => e.IdLivraison)
                    .HasName("PRIMARY");

                entity.ToTable("livraisons");

                entity.HasIndex(e => e.IdAdresse, "FK_Livraisons_Adresses");

                entity.HasIndex(e => e.IdCommande, "FK_Livraisons_Commandes");

                entity.Property(e => e.IdLivraison).HasColumnType("int(11)");

                entity.Property(e => e.DateLivraison)
                    .HasColumnType("date")
                    .HasColumnName("dateLivraison");

                entity.Property(e => e.IdAdresse).HasColumnType("int(11)");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.QuantiteLivraison)
                    .HasColumnType("int(11)")
                    .HasColumnName("quantiteLivraison");
            });

            modelBuilder.Entity<Pays>(entity =>
            {
                entity.HasKey(e => e.IdPays)
                    .HasName("PRIMARY");

                entity.ToTable("pays");

                entity.HasIndex(e => e.NomPays, "nomPays")
                    .IsUnique();

                entity.Property(e => e.IdPays).HasColumnType("int(11)");

                entity.Property(e => e.NomPays)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nomPays");
            });

            modelBuilder.Entity<Produits>(entity =>
            {
                entity.HasKey(e => e.IdProduit)
                    .HasName("PRIMARY");

                entity.ToTable("produits");

                entity.HasIndex(e => e.IdRubrique, "FK_Produits_Rubriques");

                entity.HasIndex(e => e.RefProduit, "refProduit")
                    .IsUnique();

                entity.Property(e => e.IdProduit).HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.IdRubrique).HasColumnType("int(11)");

                entity.Property(e => e.LibelleProduit)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("libelleProduit");

                entity.Property(e => e.Photo)
                    .HasMaxLength(150)
                    .HasColumnName("photo");

                entity.Property(e => e.PrixHorsTaxe)
                    .HasColumnType("decimal(19,4)")
                    .HasColumnName("prixHorsTaxe");

                entity.Property(e => e.RefProduit)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("refProduit");

                entity.Property(e => e.Stock)
                    .HasColumnType("int(11)")
                    .HasColumnName("stock");
            });

            modelBuilder.Entity<ProgressionsCommande>(entity =>
            {
                entity.HasKey(e => e.IdProgressionsCommande)
                    .HasName("PRIMARY");

                entity.ToTable("progressionscommande");

                entity.HasIndex(e => e.IdEtatCommande, "FK_ProgressionsCommande_EtatsCommande");

                entity.HasIndex(e => e.IdCommande, "FK_ProgressionsCommande_commandes");

                entity.Property(e => e.IdProgressionsCommande).HasColumnType("int(11)");

                entity.Property(e => e.DateEtatCommande)
                    .HasColumnType("date")
                    .HasColumnName("dateEtatCommande");

                entity.Property(e => e.IdCommande).HasColumnType("int(11)");

                entity.Property(e => e.IdEtatCommande).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Reglements>(entity =>
            {
                entity.HasKey(e => e.IdReglement)
                    .HasName("PRIMARY");

                entity.ToTable("reglements");

                entity.Property(e => e.IdReglement).HasColumnType("int(11)");

                entity.Property(e => e.TypePaiement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("typePaiement");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.IdRole).HasColumnType("int(11)");

                entity.Property(e => e.LibelleRole)
                    .HasMaxLength(50)
                    .HasColumnName("libelleRole");
            });

            modelBuilder.Entity<Rubriques>(entity =>
            {
                entity.HasKey(e => e.IdRubrique)
                    .HasName("PRIMARY");

                entity.ToTable("rubriques");

                entity.HasIndex(e => e.IdRubriqueMere, "FK_Rubriques_RubriqueMere");

                entity.Property(e => e.IdRubrique).HasColumnType("int(11)");

                entity.Property(e => e.IdRubriqueMere).HasColumnType("int(11)");

                entity.Property(e => e.LibelleRubrique)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("libelleRubrique");

                entity.HasOne(d => d.IdRubriqueMereNavigation)
                    .WithMany(p => p.InverseIdRubriqueMereNavigation)
                    .HasForeignKey(d => d.IdRubriqueMere)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rubriques_RubriqueMere");
            });

            modelBuilder.Entity<Tva>(entity =>
            {
                entity.HasKey(e => e.IdTva)
                    .HasName("PRIMARY");

                entity.ToTable("tva");

                entity.Property(e => e.IdTva)
                    .HasColumnType("int(11)")
                    .HasColumnName("IdTVA");

                entity.Property(e => e.TauxTva)
                    .HasColumnType("int(11)")
                    .HasColumnName("tauxTVA");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.HasIndex(e => e.EmailUser, "EmailUser")
                    .IsUnique();

                entity.HasIndex(e => e.IdRole, "FK_User_Roles");

                entity.Property(e => e.IdUser).HasColumnType("int(11)");

                entity.Property(e => e.EmailUser)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.IdRole).HasColumnType("int(11)");

                entity.Property(e => e.MdpUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("mdpUser");

                entity.Property(e => e.NomUser)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("nomUser");

                entity.Property(e => e.PrenomUser)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("prenomUser");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Roles");
            });

            modelBuilder.Entity<Villes>(entity =>
            {
                entity.HasKey(e => e.IdVille)
                    .HasName("PRIMARY");

                entity.ToTable("villes");

                entity.HasIndex(e => e.IdPays, "FK_Villes_Pays");

                entity.Property(e => e.IdVille).HasColumnType("int(11)");

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("codePostal");

                entity.Property(e => e.IdPays).HasColumnType("int(11)");

                entity.Property(e => e.LibelleVille)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("libelleVIlle");

                entity.HasOne(d => d.IdPaysNavigation)
                    .WithMany(p => p.Villes)
                    .HasForeignKey(d => d.IdPays)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Villes_Pays");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
