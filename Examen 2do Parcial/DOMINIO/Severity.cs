using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMINIO
{
    public enum Severity { Info, Warning, Error }
    public class Log
    {
        public string Message { get; set; }
        public Severity Severity { get; set; }
    }
    public interface ILogger
    {
        void Store(Log log);
        List<Log> GetAll();
    }
}
