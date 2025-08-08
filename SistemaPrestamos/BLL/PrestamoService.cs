using BLL.ChainOfResponsability;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PrestamoService
    {
        private static Handler ejecutivo;

        private static Handler lider;

        static PrestamoService(){
            lider = new Lider();
            ejecutivo = new EjecutivoCuenta();
            ejecutivo.SetSuccessor(lider);
        }

        public static void Aprobar(Prestamo prestamo)
        {
            ejecutivo.Aprobar(prestamo);
        }

        //Utilizar singleton con constructor privado...
        /*public PrestamoService()
        {

        }*/
    }
}
