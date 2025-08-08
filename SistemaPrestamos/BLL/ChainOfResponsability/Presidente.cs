using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ChainOfResponsability
{
    class Presidente : Handler
    {
        public override void Aprobar(Prestamo prestamo)
        {
            throw new NotImplementedException();
        }
    }
}
