using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraException : Exception
    {
        public BitacoraException(string message, Exception inner) : base(message, inner) { }
    }
}
