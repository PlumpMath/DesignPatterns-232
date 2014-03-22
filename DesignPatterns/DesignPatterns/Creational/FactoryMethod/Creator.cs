using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Product FactoryMethod();

        public abstract void AnOperation();
    }
}
