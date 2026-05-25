using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces
{
    public interface IPreguntasServices
    {
        Task<Preguntas> Create(CreatePreguntaDTO dto);

        Task<Preguntas> GetById(Guid Id);

        Task<List<Preguntas>> GetByEstado(string estado);

    }
}
