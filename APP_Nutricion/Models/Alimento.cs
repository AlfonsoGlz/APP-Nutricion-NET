using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class Alimento
    {
        public Alimento()
        {
            Cenas = new HashSet<Cena>();
            Colacions = new HashSet<Colacion>();
            Comida = new HashSet<Comida>();
            Desayunos = new HashSet<Desayuno>();
        }

        public int IdAlimento { get; set; }
        public string NombreAlimento { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal Calorias { get; set; }
        public decimal Proteinas { get; set; }
        public decimal Carbohidratos { get; set; }
        public decimal Grasas { get; set; }
        public decimal Fibra { get; set; }
        public decimal Sodio { get; set; }
        public int? CategoriaId { get; set; }
        public int? UnidadId { get; set; }

        public virtual Categoria? Categoria { get; set; }
        public virtual Unidad? Unidad { get; set; }
        public virtual ICollection<Cena> Cenas { get; set; }
        public virtual ICollection<Colacion> Colacions { get; set; }
        public virtual ICollection<Comida> Comida { get; set; }
        public virtual ICollection<Desayuno> Desayunos { get; set; }
    }
}
