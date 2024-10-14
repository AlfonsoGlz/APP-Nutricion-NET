using APP_Nutricion.Models;

namespace APP_Nutricion.Services
{
    public class UnidadService : IUnidadService
    {
        private readonly APP_NutricionContext _context;

        public UnidadService(APP_NutricionContext context)
        {
            _context = context;
        }

        public List<Unidad> ListarUnidades()
        {
            return _context.Unidad.ToList();
        }

        void IUnidadService.AgregarUnidad(Unidad u)
        {
            throw new NotImplementedException();
        }

        void IUnidadService.EditarUnidad(Unidad u)
        {
            throw new NotImplementedException();
        }

        Unidad IUnidadService.ObtenerUnidadId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
