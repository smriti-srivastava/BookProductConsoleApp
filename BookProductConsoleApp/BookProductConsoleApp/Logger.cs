using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProductConsoleApp
{
    public class Logger
    {
        private static Logger _logger;
        private IRepository<string> repository;
        private Logger()
        {
            this.repository = new LogFileRepository();
        }
        public static Logger getLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }
            return _logger;
        }
        public void LogMessage(string message)
        {
            this.repository.Save(message);
        }
    }


}
