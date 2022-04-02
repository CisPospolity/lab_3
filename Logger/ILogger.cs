using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    interface ILogger : IDisposable
    {
        void Log(params string[] messages);
    }
}
