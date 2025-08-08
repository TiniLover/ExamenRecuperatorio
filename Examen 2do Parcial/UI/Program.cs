using BLL;
using DOMINIO;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFilePath = "applogs.txt";
            
            
            // Ejemplo usando nuestro FileLogger original
            ILogger ourLogger = LoggerFactory.CreateFileLogger(logFilePath);
            ourLogger.Store(new Log { Message = "This is a test log", Severity = Severity.Info });

            // Ejemplo usando el Logger del cliente a través del adaptador
            ILogger clientLogger = LoggerFactory.CreateClientLoggerAdapter(logFilePath);
            clientLogger.Store(new Log { Message = "Client adapted log", Severity = Severity.Warning });

            // Mostrar todos los logs
            var allLogs = clientLogger.GetAll();
            Console.WriteLine("Logs stored:");
            foreach (var log in allLogs)
            {
                Console.WriteLine($"[{log.Severity}] {log.Message}");
            }
            Console.WriteLine($"Logs se guardarán en: {Path.GetFullPath(logFilePath)}");
            // Ejemplo con la funcionalidad extendida para emails
            ILogger emailLogger = new EmailLoggerDecorator(clientLogger);
            emailLogger.Store(new Log { Message = "This is a criticalError test", Severity = Severity.Error });
        }

    }
    public class EmailLoggerDecorator : ILogger
    {
        private readonly ILogger _logger;
        public EmailLoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }
        public void Store(Log log)
        {
            if (log.Message.Contains("criticalError"))
            {
                Console.WriteLine($"Email enviado a soporteNivel1@email.com por: {log.Message}");
            }
            else if (log.Message.Contains("FatalError"))
            {
                Console.WriteLine($"Email enviado a soporteNivel2@email.com por: {log.Message}");
            }
            _logger.Store(log);
        }
        public List<Log> GetAll()
        {
            return _logger.GetAll();
        }
    }


}
