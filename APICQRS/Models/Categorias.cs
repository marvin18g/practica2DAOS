using System.ComponentModel.DataAnnotations;

namespace APICQRS.Models
{
    public class Categorias
    {
        [Key]
        public int IdCateogoria { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string NombreCategoria { get; set; }

        public string DescripcionCateogoria { get; set; }
    }
}
