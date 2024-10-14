using APP_Nutricion.Models;

namespace APP_Nutricion.Services
{
    public interface IUnidadService
    {
        List<Unidad> ListarUnidades();
        Unidad ObtenerUnidadId(int id);
        void AgregarUnidad(Unidad u);
        void EditarUnidad(Unidad u);

    }
}
