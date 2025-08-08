using DOMINIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;
        public FileLogger(string filePath)
        {
            _filePath = filePath;
            EnsureFileExists();
        }
        private void EnsureFileExists()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "");
            }
        }
        public void Store(Log log)
        {
            File.AppendAllText(_filePath, $"{log.Severity}|{log.Message}\n");
        }
        public List<Log> GetAll()
        {
            return File.ReadAllLines(_filePath)
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
