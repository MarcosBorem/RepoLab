using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TesteApi.Models;

namespace TesteApi.Data
{
    public class TesteApiContext : DbContext
    {
        public TesteApiContext (DbContextOptions<TesteApiContext> options)
            : base(options)
        {
        }

        public DbSet<TesteApi.Models.Usuario> Usuario { get; set; }
    }
}
