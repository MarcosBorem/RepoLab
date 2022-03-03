using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ApiPostgreSql.Models
{
    [Table("Loguin")]
    public partial class Loguin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string User { get; set; }
        [Required]
        [Column(TypeName = "char")]
        public string Password { get; set; }
    }
}
