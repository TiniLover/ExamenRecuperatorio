using BLL;
using DAL;
using DOMINIO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public static class LoggerFactory
    {
        public static ILogger CreateFileLogger(string filePath)
        {
            return new FileLogger(filePath);
        }
        public static ILogger CreateClientLoggerAdapter(string filePath)
        {
            return new LoggerAdapter(filePath);
        }
    }
}
