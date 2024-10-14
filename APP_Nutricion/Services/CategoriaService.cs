using APP_Nutricion.Models;

namespace APP_Nutricion.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly APP_NutricionContext _context;

        public CategoriaService(APP_NutricionContext context)
        {
            _context = context;
        }

        public List<Categoria> ListarCategorias()
        {
            return _context.Categorias.ToList();
        }

        void ICategoriaService.AgregarCategoria(Categoria u)
        {
            throw new NotImplementedException();
        }

        void ICategoriaService.EditarCategoria(Categoria u)
        {
            throw new NotImplementedException();
        }

        Categoria ICategoriaService.ObtenerCategoriaId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
