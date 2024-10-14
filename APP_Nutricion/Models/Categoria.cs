using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Alimentos = new HashSet<Alimento>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; } = null!;

        public virtual ICollection<Alimento> Alimentos { get; set; }
    }
}
