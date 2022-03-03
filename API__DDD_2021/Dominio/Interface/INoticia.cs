﻿using Dominio.Interface.Genericos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface INoticia : IGenericos<Noticia>
    {
        Task<List<Noticia>> ListarNoticias(Expression<Func<Noticia, bool>> exNoticia);
    }
}