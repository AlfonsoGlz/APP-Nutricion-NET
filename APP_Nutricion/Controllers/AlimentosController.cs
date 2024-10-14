using APP_Nutricion.Models;
using APP_Nutricion.Models.ViewModels;
using APP_Nutricion.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Immutable;

namespace APP_Nutricion.Controllers
{
    public class AlimentosController : Controller
    {
        private readonly IAlimentosService _service;
        private readonly IUnidadService _unidadService;
        private readonly ICategoriaService _categoriaService;

        public AlimentosController(IAlimentosService service, IUnidadService unidadService, ICategoriaService categoriaService)
        {
            _service = service;
            _unidadService = unidadService;
            _categoriaService = categoriaService;
        }

        public IActionResult Index()
        {
            var alimentos = _service.ListarAlimentos();
            return View(alimentos);
        }

        public IActionResult Agregar()
        {
            UpsertVM VM = new UpsertVM()
            {
                UnidadesList = _unidadService.ListarUnidades().Select(u => new SelectListItem 
                { 
                    Value = u.IdUnidad.ToString(),
                    Text = u.NombreUnidad
                }),
                CategoriasList = _categoriaService.ListarCategorias().Select(c => new SelectListItem
                {
                    Value = c.IdCategoria.ToString(),
                    Text = c.NombreCategoria
                }),
            };

            return View(VM);
        }

    }
}
