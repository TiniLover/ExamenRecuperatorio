using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public interface IBateriaService
    {
        void ActualizarEstado(bool conectado, int carga);
        Bateria ObtenerEstadoActual();
    }
}
