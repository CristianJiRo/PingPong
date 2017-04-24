using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        
        //Tests del metodo para comprobar cuantas jornadas quedan.

            //Con valores positivos.
        [TestMethod()]
        public void JornadasTest()
        {

            List<Partido> parts = new List<Partido>();            
            Partido part = new Partido(null, null);
            Partido part2 = new Partido(null, null);
            parts.Add(part);
            parts.Add(part2);
            Liga liga = new Liga(parts);
            liga.jornada = 1;

            int num = liga.jornadasRestantes();
            Assert.AreEqual(num, 1);
            
        }
        
            //con valores negativos
        [TestMethod()]       
        public void JornadasTestOutOfRange()
        {

            List<Partido> parts = new List<Partido>();
            Partido part = new Partido(null, null);
            Partido part2 = new Partido(null, null);
            Liga liga = new Liga(parts);
            liga.jornada = 2;

            int num = liga.jornadasRestantes();

            Assert.IsFalse(num > -1);
                                  

        }

    }
}