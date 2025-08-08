using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class BateriaService : IBateriaService
    {
        private readonly Bateria _bateria;

        public BateriaService(Bateria bateria)
        {
            _bateria = bateria;
        }

        public void ActualizarEstado(bool conectado, int carga)
        {
            _bateria.Conectado = conectado;
            _bateria.Carga = carga;
        }

        public Bateria ObtenerEstadoActual() => _bateria;
    }
}
