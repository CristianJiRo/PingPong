using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Liga
    {
        public List<Partido> partidos { get; set; }
        public int jornada { get; set; }

        public Liga(List<Partido> part)
        {
            this.partidos = part;
            this.jornada = 0;
        }


        public int jornadasRestantes()
        {
            return partidos.Count - jornada;
        }
    }

   
}
