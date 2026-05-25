using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Interfaces;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models;
using FINAL_WEB_JERONIMO_DUQUE_RUIZ.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace FINAL_WEB_JERONIMO_DUQUE_RUIZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : Controller
    {

        private readonly IPreguntasServices _service;

        public PreguntasController(IPreguntasServices service)
        {
            _service = service; 
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var result = await _service.GetById(Id);
            return result != null ? Ok(result) : NotFound("Ninguna Pregunta Encontrada con este ID"); 
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePreguntaDTO dto)
        {
            var created = await _service.Create(dto);
            return CreatedAtAction(nameof(GetById),
                                    new { id = created.Id }, dto);

        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> GetByEstado(string estado)
        {
            var response = await _service.GetByEstado(estado);
            return response != null ? Ok(response) : NotFound("Ninguna Pregunta Encontrada con este estado");
        }

    }
}
