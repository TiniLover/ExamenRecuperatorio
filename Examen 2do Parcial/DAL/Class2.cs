using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public enum LoggerType { File }
    public class Logger
    {
        private readonly string _filePath;
        public Logger(LoggerType type, string filePath)
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
        public void Write(string message)
        {
            File.AppendAllText(_filePath, $"{message}\n");
        }
        public string[] ReadAll()
        {
            return File.ReadAllLines(_filePath);
        }
    }
}
