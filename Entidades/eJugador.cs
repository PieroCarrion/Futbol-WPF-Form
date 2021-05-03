using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class eJugador {
        public string NombreCompleto { get; set; }
        public string DNI { get; set; }
        public int partidosJugados { get; set; }
        public int trofeosObtenidos { get; set; }
        public decimal talla { get; set; }
        public decimal peso { get; set; }
        public int edad { get; set; }
        public string posicionDeJuego { get; set; }
    }
}
