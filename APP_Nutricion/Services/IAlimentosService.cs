using APP_Nutricion.Models;
using APP_Nutricion.Models.ViewModels;

namespace APP_Nutricion.Services
{
    public interface IAlimentosService
    {
        List<Alimento> ListarAlimentos();
        Alimento ObtenerAlimentoId(int id);
        void AgregarAlimento(UpsertVM v);
        void EditarAlimento(UpsertVM v);
        void EliminarAlimento(Alimento a);
    }
}
