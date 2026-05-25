using System.ComponentModel.DataAnnotations;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs
{
    public class CreatePreguntaDTO
    {
        [Required]
        [MinLength(8)]
        public string Enunciado { get; set; }
    }
}
