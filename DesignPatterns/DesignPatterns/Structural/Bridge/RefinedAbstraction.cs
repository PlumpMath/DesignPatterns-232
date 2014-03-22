using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {

        public override void Operation()
        {
            _implementor.OperationImp();
        }
    }
}
