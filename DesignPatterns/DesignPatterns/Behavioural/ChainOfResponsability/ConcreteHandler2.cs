using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioural.ChainOfResponsability
{
    public class ConcreteHandler2: Handler
    {
        public ConcreteHandler2(Handler handler) : base(handler) { }

        public override void HandleRequest()
        {            
            Console.WriteLine("ConcreteHandler2 executed.");

            if (_successor != null)
            {
                _successor.HandleRequest();
            }
        }
    }
}
