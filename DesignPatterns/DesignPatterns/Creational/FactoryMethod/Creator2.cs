using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Creator2 : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product2();
        }

        public override void AnOperation()
        {

        }
    }
}
