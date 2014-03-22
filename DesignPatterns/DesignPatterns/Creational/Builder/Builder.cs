using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public abstract class AbstractBuilder
    {
        protected Product _product = new Product();
    
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public virtual Product GetResult()
        {
            throw new System.NotImplementedException();
}
    }
}
