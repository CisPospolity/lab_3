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
            DateTime time = DateTime.Now;
            writer.Write(time.ToString("yyyy-MM-ddTHH:mm:sszzz") + " ");
            foreach (string message in messages)
            {
                writer.Write(message + " ");
            }
            writer.Write("\n");

            writer.Flush();
        }

        public abstract void Dispose();
    }
}
