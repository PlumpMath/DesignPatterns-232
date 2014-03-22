using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicState);
        }
    }
}
