using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Common;

namespace DesignPatterns.Behavioural.ChainOfResponsability
{
    public class Client : IClient
    {
        public void Run()
        {
            ConcreteHandler2 handler2 = new ConcreteHandler2(null);
            ConcreteHandler1 handler1 = new ConcreteHandler1(handler2);

            handler1.HandleRequest();

            Console.ReadKey();
        }
    }
}
