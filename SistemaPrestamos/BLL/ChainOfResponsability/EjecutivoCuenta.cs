using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ChainOfResponsability
{
    public class EjecutivoCuenta : Handler
    {
        public override void Aprobar(Prestamo prestamo)
        {
            Console.WriteLine($"Ejecutando la aprobación -> EjecutivoCuenta");

            //Aplicar las reglas de negocio de acuerdo a lo solicitado por el dominio...
            if (prestamo.Monto <= 100000)
                prestamo.Estado = EnumEstadoAprobacion.Aprobado;
            else if (this.Successor != null)
                this.Successor.Aprobar(prestamo);
            else
                prestamo.Estado = EnumEstadoAprobacion.Desaprobado;
        }
    }
}
