using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Services
{
    public class PreguntasServices : IPreguntasServices
    {

        private readonly ApplicationDbContext _context;

        public PreguntasServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Preguntas> Create(CreatePreguntaDTO dto)
        {
            var newPregunta = new Preguntas
            {
                Enunciado = dto.Enunciado
            };

            _context.Pregunta.Add(newPregunta);
            await _context.SaveChangesAsync();
            return newPregunta;
        }

        public async Task<Preguntas> GetById(Guid Id)
        {
            return await _context.Pregunta.FindAsync(Id);
        }

        public async Task<List<Preguntas>> GetByEstado(string estado)
        {
            var resultado = await _context.Pregunta.Where(e => e.Estado == "estado").ToListAsync();
            return resultado == null || !resultado.Any() ? null : resultado; 

        }
    }
}
