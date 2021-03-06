using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace aa.Models
{
    public partial class Table
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string PrimeiroNome { get; set; }
        [StringLength(100)]
        public string SegundoNome { get; set; }
        public int? Telefone { get; set; }
        [StringLength(100)]
        public string Endereco { get; set; }
    }
}
