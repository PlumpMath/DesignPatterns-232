using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class Implementor1 : Implementor
    {
        public override void OperationImp()
        {
            Console.WriteLine("Concrete Implementor1 Operation");
        }
    }
}
