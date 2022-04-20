using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            writer = Console.Out;
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
