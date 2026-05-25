using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models
{
    public class Respuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        [MinLength(2)]
        public string? enunciado { get; set; }

        public Guid pregunta_Id { get; set; }

        [ForeignKey(nameof(pregunta_Id))]
        public Preguntas pregunta { get; set; } = null!;

        public DateTime FechaCreacion { get; set; } = DateTime.Now; 

    }
}
