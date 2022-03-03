using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication1.Models
{
    [Table("usuariomysql")]
    public partial class Usuariomysql
    {
        [Key]
        public int Id { get; set; }
        [StringLength(45)]
        public string Nome { get; set; }
        public int? Celular { get; set; }
        [StringLength(45)]
        public string Email { get; set; }

        internal object Authenticate(string nome)
        {
            throw new NotImplementedException();
        }

    }
}
