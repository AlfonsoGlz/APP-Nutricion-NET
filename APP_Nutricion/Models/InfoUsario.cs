using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class InfoUsario
    {
        public int IdInfo { get; set; }
        public int Peso { get; set; }
        public int Estatura { get; set; }
        public int Edad { get; set; }
        public bool Genero { get; set; }
        public string NivelActividad { get; set; } = null!;
        public decimal? ReqCaloricos { get; set; }
        public int? UsuarioId { get; set; }

        public virtual Usuario? Usuario { get; set; }
    }
}
