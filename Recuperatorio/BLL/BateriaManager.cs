using DAL;
using SERVICES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BateriaManager
    {
        private readonly IBateriaService _bateriaService;
        private readonly IBitacoraRepository _bitacoraRepository;
        private readonly SuscriptorVisual _visual;
        private readonly SuscriptorBitacora _bitacora;

        public BateriaManager(IBateriaService bateriaService, IBitacoraRepository bitacoraRepository)
        {
            _bateriaService = bateriaService;
            _bitacoraRepository = bitacoraRepository;

            // Crear observadores
            _visual = new SuscriptorVisual();
            _bitacora = new SuscriptorBitacora(_bitacoraRepository);

            // Suscribir observadores
            var bateria = _bateriaService.ObtenerEstadoActual();
            bateria.Suscribir(_visual);
            bateria.Suscribir(_bitacora);
        }

        public void ActualizarEstadoBateria(bool conectado, int carga)
        {
            _bateriaService.ActualizarEstado(conectado, carga);
        }
    }
}
