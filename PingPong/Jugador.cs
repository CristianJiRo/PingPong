using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Jugador
    {
        public String nombre { get; set; }
        public String urlFoto { get; set; }
        public int puntos { get; set; }
        public int jugados { get; set; }
        public int dif { get; set; }

        public Jugador (String name, String url)
        {
            this.nombre = name;
            this.urlFoto = url;
            this.puntos =0;
            this.jugados =0;
            this.dif = 0;

        }
    }




    
}
