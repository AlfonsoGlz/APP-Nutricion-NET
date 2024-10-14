using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class Comida
    {
        public int IdComida { get; set; }
        public int? AlimentoId { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Alimento? Alimento { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }
}
