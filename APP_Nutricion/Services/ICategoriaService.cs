using APP_Nutricion.Models;

namespace APP_Nutricion.Services
{
    public interface ICategoriaService
    {
        List<Categoria> ListarCategorias();
        Categoria ObtenerCategoriaId(int id);
        void AgregarCategoria(Categoria u);
        void EditarCategoria(Categoria u);
    }
}
