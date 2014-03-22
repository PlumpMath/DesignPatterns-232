using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Flyweight
{
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicState);
    }
}
