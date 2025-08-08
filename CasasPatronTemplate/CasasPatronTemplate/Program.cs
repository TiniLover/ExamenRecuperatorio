using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPatronTemplate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool pintarRequerido1 = true;
            bool construirSegundoPisoRequerido1 = false;
            bool construirSotanoRequerido1 = true;

            ConstruccionCasa construccionCasa1 = new CasaLadrillo(pintarRequerido1, construirSegundoPisoRequerido1, construirSotanoRequerido1);
            construccionCasa1.ConstruirCasa();

            bool pintarRequerido2 = false;
            bool construirSegundoPisoRequerido2 = true;
            bool construirSotanoRequerido2 = false;

            ConstruccionCasa construccionCasa2 = new CasaMadera(pintarRequerido2, construirSegundoPisoRequerido2, construirSotanoRequerido2);
            construccionCasa2.ConstruirCasa();
            Console.ReadKey();
        }
    }
}
