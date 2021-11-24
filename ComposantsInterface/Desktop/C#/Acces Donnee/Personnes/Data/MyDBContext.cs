using Microsoft.EntityFrameworkCore;
using Personnes.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Personnes.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Personne> Personnes { get; set; }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}
