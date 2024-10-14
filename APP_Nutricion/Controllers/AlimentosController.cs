using APP_Nutricion.Services;
using Microsoft.AspNetCore.Mvc;

namespace APP_Nutricion.Controllers
{
    public class AlimentosController : Controller
    {
        private readonly IAlimentosService _service;

        public AlimentosController(IAlimentosService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var alimentos = _service.ListarAlimentos();
            return View(alimentos);
        }

    }
}
