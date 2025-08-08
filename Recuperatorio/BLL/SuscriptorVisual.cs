using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SuscriptorVisual : IObservadorBateria
    {
        public void Actualizar(Bateria bateria)
        {
            Console.Clear();
            Console.WriteLine("=== ESTADO DE LA BATERÍA ===");
            Console.WriteLine($"Estado: {(bateria.Conectado ? "CARGANDO" : "DESCONECTADO")}");
            Console.WriteLine($"Porcentaje de carga: {bateria.Carga}%");

            if (bateria.Conectado)
                Console.WriteLine($"Tiempo restante de carga: {bateria.TiempoCarga} minutos");
            else
                Console.WriteLine($"Tiempo estimado de uso: {bateria.TiempoUso} minutos");

            Console.WriteLine(new string('=', 30));
        }
    }
}
