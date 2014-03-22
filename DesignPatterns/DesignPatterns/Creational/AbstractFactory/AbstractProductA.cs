using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractProductA
    {
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
