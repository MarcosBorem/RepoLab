using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace b.Models
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

        public virtual DbSet<Usuariomysql> Usuariomysqls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost; database=bancoteste;uid=root; pwd=123456;port=3306");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuariomysql>(entity =>
            {
                entity.ToTable("usuariomysql");

                entity.Property(e => e.Email).HasMaxLength(45);

                entity.Property(e => e.Nome).HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
