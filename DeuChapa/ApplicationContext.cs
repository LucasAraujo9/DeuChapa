using DeuChapa.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeuChapa
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Lanche> Lanche { get; set; } // tabela lanche 
        public DbSet<Bebida> Bebida { get; set; } // tabela bebida 
        public DbSet<Combo> Combo { get; set; } // tabela lanche 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Combo>().HasKey(x => x.Id_Combo);
            modelBuilder.Entity<Combo>().HasOne(x => x.Lanche);
            modelBuilder.Entity<Combo>().HasOne(x => x.Bebida);

            modelBuilder.Entity<Lanche>().HasKey(x => x.Id_Lanche);
            modelBuilder.Entity<Lanche>().HasOne(x => x.Ingredientes);

            modelBuilder.Entity<Bebida>().HasKey(x => x.Id_Bebida);

            modelBuilder.Entity<Ingredientes>().HasKey(x => x.Id_Ingrediente);
            
            
        }
    }
}
