using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
namespace Alura.Filmes.App.Dados
{
    class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
                .ToTable("film");

            builder
                .Property(f => f.Id)
                .HasColumnName("film_id");

            builder
               .Property(f => f.Titulo)
               .HasColumnName("title")
               .HasColumnType("varchar(255)")
               .IsRequired();


            builder
              .Property(f => f.Descricao)
              .HasColumnName("description")
              .HasColumnType("text");

            builder
              .Property(f => f.Duracao)
              .HasColumnName("length");


            builder
            .Property(f => f.Anolancamento)
            .HasColumnName("release_year")
            .HasColumnType("varchar(4)");

            // shadow prop
            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime");
        }
    }
}
