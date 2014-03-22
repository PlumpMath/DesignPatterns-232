using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        private int addedState = 0;
    
        public override void Operation()
        {
            Component.Operation();
            if (addedState == 0)
            {
                //new logic
            }
            Console.WriteLine("ConcreteDecoratorA operation");
        }
    }

}
