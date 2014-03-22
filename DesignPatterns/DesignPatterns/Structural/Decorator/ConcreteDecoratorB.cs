using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            Component.Operation();
            AddedBehaviour();
        }

        public void AddedBehaviour()
        {
            Console.WriteLine("AddedBehaviour ConcreteDecoratorB");
        }
    }
}
