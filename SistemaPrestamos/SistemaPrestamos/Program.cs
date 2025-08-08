using BLL;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrestamos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Prestamo prestamo = new Prestamo();
            prestamo.Cliente = cliente;
            prestamo.FechaSolicitud = DateTime.Now;
            prestamo.Monto = 50000;

            PrestamoService.Aprobar(prestamo);

            Console.WriteLine($"El prestamo quedó en estado: {prestamo.Estado}");

            prestamo.Estado = EnumEstadoAprobacion.Desaprobado;
            prestamo.Monto = 150000;

            PrestamoService.Aprobar(prestamo);
            Console.WriteLine($"El prestamo quedó en estado: {prestamo.Estado}");
        }
    }
}
