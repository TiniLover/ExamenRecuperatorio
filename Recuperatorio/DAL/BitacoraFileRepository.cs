using DOMAIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraFileRepository : IBitacoraRepository
    {
        private readonly string _rutaBase = "bitacora";
        private string _rutaArchivoActual;

        public BitacoraFileRepository()
        {
            RotarArchivo();
        }

        private void RotarArchivo()
        {
            string fecha = DateTime.Now.ToString("yyyyMMdd");
            _rutaArchivoActual = $"{_rutaBase}_{fecha}.txt";
        }

        public void RegistrarEvento(Bateria bateria)
        {
            // Verificar si necesitamos rotar el archivo (nuevo día)
            string fechaHoy = DateTime.Now.ToString("yyyyMMdd");
            if (!_rutaArchivoActual.Contains(fechaHoy))
                RotarArchivo();

            try
            {
                string registro = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] " +
                                $"Estado: {(bateria.Conectado ? "CARGANDO" : "DESCONECTADO")}, " +
                                $"Carga: {bateria.Carga}%, " +
                                $"{(bateria.Conectado ? $"TiempoCarga: {bateria.TiempoCarga} min" : $"TiempoUso: {bateria.TiempoUso} min")}";

                File.AppendAllText(_rutaArchivoActual, registro + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new BitacoraException("Error al escribir en bitácora", ex);
            }
        }
    }
}
