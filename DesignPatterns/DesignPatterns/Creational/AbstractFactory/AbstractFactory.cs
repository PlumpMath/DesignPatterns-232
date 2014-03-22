using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();

        public abstract AbstractProductB CreateProductB();
    }
}
