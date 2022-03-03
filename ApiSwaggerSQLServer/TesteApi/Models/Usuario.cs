using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }
    }
}
