using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Abstraction
    {
        protected Implementor _implementor;

        public Implementor Implementor 
        {
            set { _implementor = value; }
        }

        public virtual void Operation() { }
    }
}
