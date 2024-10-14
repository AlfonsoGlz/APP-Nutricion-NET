using System;
using System.Collections.Generic;

namespace APP_Nutricion.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cenas = new HashSet<Cena>();
            Colacions = new HashSet<Colacion>();
            Comida = new HashSet<Comida>();
            Desayunos = new HashSet<Desayuno>();
            InfoUsarios = new HashSet<InfoUsario>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public string Paterno { get; set; } = null!;
        public string Materno { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Usuario1 { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string Foto { get; set; } = null!;
        public bool Administrador { get; set; }

        public virtual ICollection<Cena> Cenas { get; set; }
        public virtual ICollection<Colacion> Colacions { get; set; }
        public virtual ICollection<Comida> Comida { get; set; }
        public virtual ICollection<Desayuno> Desayunos { get; set; }
        public virtual ICollection<InfoUsario> InfoUsarios { get; set; }
    }
}
