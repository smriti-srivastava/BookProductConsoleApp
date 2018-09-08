using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    class LogFileRepository:IFileRepository<string>
    {
        private string _filePath;
        public LogFileRepository()
        {
            this._filePath = @"C:\LogFile.txt";
        }
        public void Save(string text)
        {
            File.AppendAllText(this._filePath, text + Environment.NewLine);
        }
    }
}
