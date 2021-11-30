using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Models;

namespace Voitures.Data
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Client> Clients { get; set; }
        public MyDbContext (DbContextOptions<MyDbContext> options) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(c1 =>
            {
                c1.ToTable("Clients");
                c1.Property(a => a.IdClient).HasColumnName("IdClient");
            });

            modelBuilder.Entity<Voiture>(v1 =>
            {
                v1.ToTable("Voitures");
                v1.Property(a => a.IdClient).HasColumnName("IdClient");
                v1.HasOne(a => a.Clt).WithOne().HasForeignKey<Client>(a => a.IdClient);
            });
        }
    }
}
