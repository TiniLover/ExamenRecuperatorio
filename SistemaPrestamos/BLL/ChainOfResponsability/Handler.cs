using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ChainOfResponsability
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void Aprobar(Prestamo prestamo);
        
        /// <summary>
        /// Dejamos una implementación concreta. Verificar en caso de querer especializar...
        /// </summary>
        /// <param name="handler"></param>
        public void SetSuccessor(Handler handler)
        {
            this.Successor = handler;
        }
    }
}
