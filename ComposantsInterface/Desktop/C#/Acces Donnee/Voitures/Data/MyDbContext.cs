using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Voitures.Data.Models;

namespace Voitures.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Voiture> Voitures { get; set; }
        public DbSet<Client> Personnes { get; set; }
        public MyDbContext (DbContextOptions<MyDbContext> options) : base (options)
        {
            
        }
    }
}
