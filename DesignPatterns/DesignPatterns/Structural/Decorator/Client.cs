using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Structural.Decorator
{
    public class Client : IClient
    {
        public void Run()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.Component = c;
            d2.Component = d1;
            d2.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}
