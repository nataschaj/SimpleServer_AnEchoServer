using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
    //In the PlainServer Create a class 'Server' with a method 'Start'.
    class Server
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);

        }
    }
}
