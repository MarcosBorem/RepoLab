using Entidades.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interface.InterfaceServicos
{
    public interface IServicoNoticia
    {
        Task AdicionaNoticia(Noticia noticia);
        Task AtualizaNoticia(Noticia noticia);
        Task<List<Noticia>> ListarNoticiasAtivas();
    }
}
