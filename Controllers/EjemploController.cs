using Microsoft.AspNetCore.Mvc;
using ProyectoAPISimple.RequestDtos;
using ProyectoAPISimple.ResponseDtos;

namespace ProyectoAPISimple.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EjemploController : ControllerBase
    {
        // GET /ejemplo
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new EjemploResponseDto
            {
                Mensaje = "Hola desde la API",
                CantidadDoble = 0
            });
        }

        // POST /ejemplo
        // Body: { "nombre": "Ana", "cantidad": 3 }
        [HttpPost]
        public IActionResult Post(EjemploRequestDto request)
        {
            EjemploResponseDto respuesta = new EjemploResponseDto
            {
                Mensaje = $"Hola {request.Nombre}",
                CantidadDoble = request.Cantidad * 2
            };

            return Ok(respuesta);
        }
    }
}
