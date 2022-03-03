using Dominio.Interface;
using Dominio.Interface.InterfaceServicos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public  class ServicoNoticia : IServicoNoticia
    {
        private readonly INoticia _INoticia;
        public ServicoNoticia(INoticia INoticia)
        {
            _INoticia = INoticia;
        }
        public async Task AdicionaNoticia(Noticia noticia)
        {
            var validarTitulo = noticia.ValirdarPropiedadesString(noticia.Titulo, "Titulo");
            var validarInformacao = noticia.ValirdarPropiedadesString(noticia.Informacao, "Informacao");

            if (validarTitulo && validarInformacao)
            {
                noticia.DataAlteracao = DateTime.Now;
                noticia.DataCadastro = DateTime.Now;
                noticia.Ativo = true;
                await _INoticia.Adicionar(noticia);
            }

        }

        public async Task AtualizaNoticia(Noticia noticia)
        {
            var validarTitulo = noticia.ValirdarPropiedadesString(noticia.Titulo, "Titulo");
            var validarInformacao = noticia.ValirdarPropiedadesString(noticia.Informacao, "Informacao");

            if (validarTitulo && validarInformacao)
            {
                noticia.DataAlteracao = DateTime.Now;
                noticia.DataCadastro = DateTime.Now;
                noticia.Ativo = true;
                await _INoticia.Atualizar(noticia);
            }
        }

        public async Task<List<Noticia>> ListarNoticiasAtivas()
        {
            return await _INoticia.ListarNoticias(n => n.Ativo);
        }
    }
}
