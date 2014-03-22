using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioural.ChainOfResponsability
{
    public class ConcreteHandler1: Handler
    {
        public ConcreteHandler1(Handler handler) : base(handler) { }

        public override void HandleRequest()
        {
            Console.WriteLine("ConcreteHandler1 executed.");
           
            if (_successor != null)
            {
                _successor.HandleRequest();
            }
        }
    }
}
