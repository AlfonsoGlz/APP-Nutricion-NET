using APP_Nutricion.Models;
using APP_Nutricion.Models.ViewModels;
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
            Alimento alimento = _context.Alimentos.Include("Unidad").Include("Categoria").First(a => a.IdAlimento == id);
            return alimento;
        }

        public void AgregarAlimento(UpsertVM v)
        {
            _context.Alimentos.Add(v.AlimentoItems!);
            _context.SaveChanges();
        }

        public void EditarAlimento(UpsertVM v)
        {
            Alimento alimento = _context.Alimentos.First(a => a.IdAlimento == v.AlimentoItems!.IdAlimento);

            alimento.NombreAlimento = v.AlimentoItems!.NombreAlimento;
            alimento.Cantidad = v.AlimentoItems.Cantidad;
            alimento.Unidad = v.AlimentoItems.Unidad;
            alimento.Calorias = v.AlimentoItems.Calorias;
            alimento.Proteinas = v.AlimentoItems.Proteinas;
            alimento.Carbohidratos = v.AlimentoItems.Carbohidratos;
            alimento.Grasas = v.AlimentoItems.Grasas;
            alimento.Fibra = v.AlimentoItems.Fibra;
            alimento.Sodio = v.AlimentoItems.Sodio;
            alimento.Categoria = v.AlimentoItems.Categoria;

            _context.SaveChanges();

        }

        public void EliminarAlimento(Alimento a)
        {
            Alimento alimento = _context.Alimentos.Find(a.IdAlimento)!;

            _context.Alimentos.Remove(alimento);
            _context.SaveChanges();
        }




    }
}
