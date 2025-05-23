using Interfaces;
using Microsoft.AspNetCore.Mvc;
using UseCases;

namespace BibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoMaterialController : Controller
    {
        private readonly ITipoMaterialServices _tipoMaterialService;
        public TipoMaterialController(ITipoMaterialServices tipoMaterialService)
        {
            _tipoMaterialService = tipoMaterialService;
        }

        [HttpGet("ObtenerTipoMaterial")]
        public async Task<IActionResult> ObtenerTipoMaterial()
        {
            var result = await _tipoMaterialService.TipoMaterialActivo();
            if (result == null || !result.Any())
            {
                return NotFound("No se encontraron tipos de material.");
            }
            return Ok(result);

        }
    }
}
