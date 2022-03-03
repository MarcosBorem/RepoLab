using Microsoft.EntityFrameworkCore;


#nullable disable

namespace WebApplication1.Models
{
    public partial class bancotesteContext : DbContext
    {
        public bancotesteContext()
        {
        }

        public bancotesteContext(DbContextOptions<bancotesteContext> options)
            : base(options)
        {
        }
        // entidades a serem mapeadas
        public virtual DbSet<Usuariomysql> Usuariomysqls { get; set; }

        //permite selecionar e configurar a fonte de dados a serem usadas atravésdo dbcontext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("server=localhost; database=bancoteste;uid=root; pwd=123456;port=3306");
            }
        }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

       
    }
}
