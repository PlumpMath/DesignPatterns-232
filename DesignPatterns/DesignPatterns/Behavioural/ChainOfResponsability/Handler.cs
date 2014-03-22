using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioural.ChainOfResponsability
{
    public abstract class Handler
    {
        protected Handler _successor;

        public Handler(Handler successor)
        {
            _successor = successor;
        }
    
        public abstract void HandleRequest();
    }
}
