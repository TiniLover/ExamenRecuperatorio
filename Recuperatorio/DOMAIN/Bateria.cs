using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Bateria
    {
        private bool _conectado;
        private int _carga;
        private int _tiempoCarga;
        private int _tiempoUso;
        private List<IObservadorBateria> _observadores = new List<IObservadorBateria>();

        public bool Conectado
        {
            get => _conectado;
            set
            {
                if (_conectado != value)
                {
                    _conectado = value;
                    Notificar();
                }
            }
        }

        public int Carga
        {
            get => _carga;
            set
            {
                if (value < 0) value = 0;
                if (value > 100) value = 100;

                if (_carga != value)
                {
                    _carga = value;
                    CalcularTiempos();
                    Notificar();
                }
            }
        }

        public int TiempoCarga { get; private set; }
        public int TiempoUso { get; private set; }

        protected virtual void CalcularTiempos()
        {
            TiempoCarga = 100 - Carga;
            TiempoUso = Carga;
        }

        public void Suscribir(IObservadorBateria observador)
        {
            if (!_observadores.Contains(observador))
                _observadores.Add(observador);
        }

        public void Desuscribir(IObservadorBateria observador)
        {
            if (_observadores.Contains(observador))
                _observadores.Remove(observador);
        }

        protected void Notificar()
        {
            foreach (var observador in _observadores)
                observador.Actualizar(this);
        }
    }
}
