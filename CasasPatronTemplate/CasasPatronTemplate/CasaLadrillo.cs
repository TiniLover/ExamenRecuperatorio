using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasasPatronTemplate
{
    public class CasaLadrillo : ConstruccionCasa
    {
        private readonly bool pintarRequerido;
        private readonly bool construirSegundoPisoRequerido;
        private readonly bool construirSotanoRequerido;

        public CasaLadrillo(bool pintarRequerido, bool construirSegundoPisoRequerido, bool construirSotanoRequerido)
        {
            this.pintarRequerido = pintarRequerido;
            this.construirSegundoPisoRequerido = construirSegundoPisoRequerido;
            this.construirSotanoRequerido = construirSotanoRequerido;
        }


        protected override void RealizarPlanos()
        {
            Console.WriteLine("Realizando planos de una casa de ladrillos\n");
        }

        protected override void ConstruirCimientos()
        {
            Console.WriteLine("Construyendo los cimientos de una casa de ladrillos\n");
        }

        protected override void ConstruirPrimerPiso()
        {
            Console.WriteLine("Construyendo primer piso de una casa de ladrillos\n");
        }

        protected override void ConstruirTecho()
        {
            Console.WriteLine("Construyendo techo de una casa de ladrillos\n");
        }

        protected override void ColocarAcabados()
        {
            Console.WriteLine("Colocando los acabados de una casa de ladrillos\n");
        }

        protected override bool PintarRequerido()
        {
            return pintarRequerido;
        }

        protected override bool ConstruirSegundoPisoRequerido()
        {
            return construirSegundoPisoRequerido;
        }

        protected override bool ConstruirSotanoRequerido()
        {
            return construirSotanoRequerido;
        }
    }
}
