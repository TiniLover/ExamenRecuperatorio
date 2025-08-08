using DAL;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SuscriptorBitacora : IObservadorBateria
    {
        private readonly IBitacoraRepository _bitacoraRepository;

        public SuscriptorBitacora(IBitacoraRepository bitacoraRepository)
        {
            _bitacoraRepository = bitacoraRepository;
        }

        public void Actualizar(Bateria bateria)
        {
            try
            {
                _bitacoraRepository.RegistrarEvento(bateria);
            }
            catch (BitacoraException ex)
            {
                Console.WriteLine($"Error en bitácora: {ex.Message}");
            }
        }
    }
}
