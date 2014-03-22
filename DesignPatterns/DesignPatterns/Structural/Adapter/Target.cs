using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public abstract class Target
    {
        protected Adaptee _adaptee = new Adaptee();

        public Target()
        {            
        }
    
        public abstract void Request();
    }
}
