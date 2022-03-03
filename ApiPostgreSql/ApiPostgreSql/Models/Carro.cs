using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ApiPostgreSql.Models
{
    public partial class Carro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string Marca { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string Modelo { get; set; }
        public int Ano { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string Cor { get; set; }
    }
}
