using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class Adaptee
    {
        //comment
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
