using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;

        public SocketLogger(string host, int port)
        {
            clientSocket = new ClientSocket(host, port);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Log(params string[] messages)
        {
            foreach (string message in messages) {
                using (clientSocket)
                {
                    byte[] requestBytes = Encoding.UTF8.GetBytes(message);
                    clientSocket.Send(requestBytes);

                    byte[] responseBuffer = new byte[1024];
                    int responseSize = clientSocket.Receive(responseBuffer);

                    string responseText = Encoding.UTF8.GetString(responseBuffer, 0, responseSize);
                    clientSocket.Close();
                }
            }
        }
    }
}
