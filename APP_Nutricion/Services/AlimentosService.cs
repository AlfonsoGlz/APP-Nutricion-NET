using APP_Nutricion.Models;
using Microsoft.EntityFrameworkCore;

namespace APP_Nutricion.Services
{
    public class AlimentosService : IAlimentosService
    {
        private readonly APP_NutricionContext _context;

        public AlimentosService (APP_NutricionContext context)
        {
            _context = context;

        }

        public List<Alimento> ListarAlimentos()
        {
            return _context.Alimentos.Include("Unidad").ToList();
        }

        public Alimento ObtenerAlimentoId(int id)
        {
            Alimento alimento = _context.Alimentos.First(a => a.IdAlimento == id);
            return alimento;
        }

        public void AgregarAlimento(Alimento a)
        {
            _context.Alimentos.Add(a);
            _context.SaveChanges();
        }

        public void EditarAlimento(Alimento a)
        {
            Alimento alimento = _context.Alimentos.First(a => a.IdAlimento == a.IdAlimento);

            alimento.NombreAlimento = a.NombreAlimento;
            alimento.Cantidad = a.Cantidad;
            alimento.Unidad = a.Unidad;
            alimento.Calorias = a.Calorias;
            alimento.Proteinas = a.Proteinas;
            alimento.Carbohidratos = a.Carbohidratos;
            alimento.Grasas = a.Grasas;
            alimento.Fibra = a.Fibra;
            alimento.Sodio = a.Sodio;
            alimento.Categoria = a.Categoria;

            _context.SaveChanges();

        }

        public void EliminarAlimento(int id)
        {
            Alimento alimento = _context.Alimentos.First(a => a.IdAlimento == id);

            _context.Alimentos.Remove(alimento);
            _context.SaveChanges();
        }




    }
}
