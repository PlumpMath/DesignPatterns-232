using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Creator1 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product1();
        }

        public override void AnOperation()
        {
            
        }
    }
}
