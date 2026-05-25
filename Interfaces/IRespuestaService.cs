using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces
{
    public interface IRespuestaService
    {
        Task<Respuesta> Create(CreatedRespuestaDTO dto);
    }
}
