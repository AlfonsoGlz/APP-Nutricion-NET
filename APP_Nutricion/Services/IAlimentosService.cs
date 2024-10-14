using APP_Nutricion.Models;

namespace APP_Nutricion.Services
{
    public interface IAlimentosService
    {
        List<Alimento> ListarAlimentos();
        Alimento ObtenerAlimentoId(int id);
        void AgregarAlimento(Alimento a);
        void EditarAlimento(Alimento a);
        void EliminarAlimento(int id);
    }
}
