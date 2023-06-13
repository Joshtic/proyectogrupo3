using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace proyecto
{
    public class Oferta
    {
        public int Id { get; set; }
        public string? NombreOferta { get; set; }
        [Required]
        [Column(TypeName = "varchar(25)")]

        public string? Descripcion { get; set; }
        public int Descuento { get; set; }
    }
}