using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto
{
    public class usuario
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]

        public string? Apellido { get; set; }
        public string? Area { get; set; }
    }
}