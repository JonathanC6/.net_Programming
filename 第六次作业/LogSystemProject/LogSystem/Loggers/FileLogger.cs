using LogSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogSystem.Loggers
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath = "log.txt";

        public void Log(string message)
        {
            File.AppendAllText(_filePath, $"File Log: {message}{Environment.NewLine}");
        }
    }
}
