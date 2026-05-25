using System.ComponentModel.DataAnnotations;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs
{
    public class CreatedRespuestaDTO
    {
        [Required]
        [MinLength(2)]
        public string Enunciado { set; get; }

        public Guid Pid { get; set; }
    }
}
