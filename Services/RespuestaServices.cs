using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Persistence;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Services
{
    public class RespuestaServices
    {
        private readonly ApplicationDbContext _context;

        public RespuestaServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Respuesta> Create(CreatedRespuestaDTO dto)
        {
            var associated_pregunta = await _context.Pregunta.FindAsync(dto.Pid);
            if (associated_pregunta == null || associated_pregunta.Estado == "Resuelta")
            {
                return null!;
            }

            var Respuesta = new Respuesta();
            Respuesta.enunciado = dto.Enunciado;
            Respuesta.pregunta_Id = dto.Pid;

            associated_pregunta.Estado = "Resuelta";

            _context.Respuesta.Add(Respuesta);
            await _context.SaveChangesAsync();
            return Respuesta;


        }
    }
}
