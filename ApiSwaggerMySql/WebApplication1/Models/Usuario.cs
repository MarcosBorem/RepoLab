using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "char")]
        public string Nome { get; set; }
        [Column(TypeName = "char")]
        public string Password { get; set; }
    }
}
