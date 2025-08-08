using BLL;
using DAL;
using DOMAIN;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuración de la inyección de dependencias (simplificada)
            var bateria = new Bateria();
            var bateriaService = new BateriaService(bateria);
            var bitacoraRepo = new BitacoraFileRepository();
            var bateriaManager = new BateriaManager(bateriaService, bitacoraRepo);

            // Simular cambios en la batería
            Console.WriteLine("Simulación de estados de batería. Presione cualquier tecla para avanzar...");

            // Estado 1: Desconectado al 20%
            bateriaManager.ActualizarEstadoBateria(false, 20);
            Console.ReadKey();

            // Estado 2: Conectado al 20%
            bateriaManager.ActualizarEstadoBateria(true, 20);
            Console.ReadKey();

            // Estado 3: Cargando al 50%
            bateriaManager.ActualizarEstadoBateria(true, 50);
            Console.ReadKey();

            // Estado 4: Carga completa
            bateriaManager.ActualizarEstadoBateria(true, 100);
            Console.ReadKey();

            // Estado 5: Desconectado al 100%
            bateriaManager.ActualizarEstadoBateria(false, 100);
            Console.ReadKey();

            // Estado 6: Desconectado al 75%
            bateriaManager.ActualizarEstadoBateria(false, 75);
            Console.ReadKey();

            Console.WriteLine("Simulación completada. Revise los archivos de bitácora.");
        }
    }
}
