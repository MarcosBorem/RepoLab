
namespace Alura.Filmes.App.Negocio
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public short Duracao { get; set; }
        public string Anolancamento { get; set; }
        public override string ToString()
        {
            return $"Filmes ({Id}): {Titulo} {Anolancamento}";
        }
    }
}
