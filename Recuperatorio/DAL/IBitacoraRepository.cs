using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBitacoraRepository
    {
        void RegistrarEvento(Bateria bateria);
    }
}
