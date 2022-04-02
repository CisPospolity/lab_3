using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            foreach(string message in messages)
            {
                writer.WriteLine(message);
                writer.Flush();
            }
        }

        public abstract void Dispose();
    }
}
