using Entidades.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Configurações
{
    public class Contexto : IdentityDbContext<ApplicationUser>
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
        }
        //Criação de objetos no Banco
        public DbSet<Noticia> Noticia { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }
        public string ObterStringConexao()
        {
            string strcon = "Server = localhost; Port = 5432; Database = DDDAPI; User Id = postgres; Password = 123456;";
            return strcon;
        }
    }
}
