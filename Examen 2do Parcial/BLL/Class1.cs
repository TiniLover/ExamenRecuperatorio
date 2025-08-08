using DAL;
using DOMINIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoggerAdapter : ILogger
    {
        private readonly Logger _logger;
        public LoggerAdapter(string filePath)
        {
            _logger = new Logger(LoggerType.File, filePath);
        }
        public void Store(Log log)
        {
            _logger.Write($"{log.Severity}|{log.Message}");
        }
        public List<Log> GetAll()
        {
            return _logger.ReadAll()
                .Select(line =>
                {
                    var parts = line.Split('|');
                    return new Log
                    {
                        Severity = (Severity)Enum.Parse(typeof(Severity), parts[0]),
                        Message = parts[1]
                    };
                })
                .ToList();
        }
    }
}
