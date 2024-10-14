using Microsoft.AspNetCore.Mvc.Rendering;

namespace APP_Nutricion.Models.ViewModels
{
    public class UpsertVM
    {
        public Alimento ?AlimentoItems { get; set; }
        public IEnumerable<SelectListItem> ?UnidadesList { get; set;}
        public IEnumerable<SelectListItem> ?CategoriasList { get; set; }
    }
}
