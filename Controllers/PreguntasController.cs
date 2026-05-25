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

        

        [HttpPost]
        public async Task<IActionResult> Create(CreatePreguntaDTO dto)
        {
            var created = await _service.Create(dto);
            return Ok(created);

        }

        [HttpGet("{estado}")]
        public async Task<IActionResult> GetByEstado(string estado)
        {
            var response = await _service.GetByEstado(estado);
            return response != null ? Ok(response) : NotFound("Ninguna Pregunta Encontrada con este estado");
        }

    }
}
