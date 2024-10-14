using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class Desayuno
    {
        public int IdDesayuno { get; set; }
        public int? AlimentoId { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Alimento? Alimento { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
