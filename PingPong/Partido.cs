using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Partido
    {
        public Jugador jugador1 { get; set; }
        public Jugador jugador2 { get; set; }

        public int resJ1 { get; set; }
        public int resJ2 { get; set; }

        public Partido (Jugador jug1, Jugador jug2)
        {
            this.jugador1 = jug1;
            this.jugador2 = jug2;
            this.resJ1 = 0;
            this.resJ2 = 0;
        }
        

    }
}
