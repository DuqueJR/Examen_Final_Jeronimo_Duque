using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models
{
    public class Preguntas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }


        [Required]
        [MinLength(8)]
        public string Enunciado { get; set; }

        [Required]
        public string Estado { get; set; } = "Sin_Resolver";

    }
}
