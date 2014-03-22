using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Structural.Proxy
{
    public class Client : IClient
    {
        public void Run()
        {
            Proxy proxy = new Proxy();

            proxy.Request();

            Console.ReadKey();
        }
    }
}
