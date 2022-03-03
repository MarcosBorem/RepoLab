using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.App.Dados
{
    class AluraFilmesContexto : DbContext

    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilme;Trusted_connection=true;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //usar a classe no contexto passando a instanâcia
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());

            
        }

    }
}
