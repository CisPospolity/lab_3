using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class CommonLogger : ILogger
    {
        private ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        public void Dispose()
        {
            foreach(ILogger logger in loggers)
            {
                logger.Dispose();
            }
        }

        public void Log(params string[] messages)
        {
            foreach(ILogger logger in loggers)
            {
                logger.Log(messages);
            }
        }

        
    }
}
