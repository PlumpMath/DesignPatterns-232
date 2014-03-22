using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Structural.Bridge
{
    public class Client : IClient
    {
        public void Run()
        {
            Abstraction abstraction = new RefinedAbstraction();

            // Set implementation and call
            abstraction.Implementor = new Implementor1();
            abstraction.Operation();

            // Change implemention and call
            abstraction.Implementor = new Implementor2();
            abstraction.Operation();
            
            // Wait for user
            Console.ReadKey();
        }
    }
}
