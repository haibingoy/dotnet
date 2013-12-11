using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Calculator
{
    public class Log4NetService
    {
        private static Log4NetService _log4NetService;

        public static Log4NetService Instance
        {
            get
            {
                _log4NetService = _log4NetService ?? new Log4NetService();
                return _log4NetService;
            }
        }

        public void LogError(object obj, string message)
        {
            var logger = LogManager.GetLogger(obj.GetType());
            logger.Error(message);
        }

        public void LogFatal(object obj, string message)
        {
            var logger = LogManager.GetLogger(obj.GetType());
            logger.Fatal(message);
        }

        public void LogInfo(object obj, string message)
        {
            var logger = LogManager.GetLogger(obj.GetType());
            logger.Info(message);
        }

        public void LogWarning(object obj, string message)
        {
            var logger = LogManager.GetLogger(obj.GetType());
            logger.Warn(message);
        }
    }
}
