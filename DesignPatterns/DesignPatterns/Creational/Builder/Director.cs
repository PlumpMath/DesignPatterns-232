using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Director
    {    
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
