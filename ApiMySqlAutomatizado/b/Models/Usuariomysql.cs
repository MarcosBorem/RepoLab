using System;
using System.Collections.Generic;

#nullable disable

namespace b.Models
{
    public partial class Usuariomysql
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Celular { get; set; }
        public string Email { get; set; }
    }
}
