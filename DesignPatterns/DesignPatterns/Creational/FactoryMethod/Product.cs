using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Product
    {
        public void Show()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
