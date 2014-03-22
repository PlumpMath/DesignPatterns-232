using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioural.Command
{
    public class ConcreteCommand : Command
    {
        private int state;
        private Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }
    
        public override void Execute()
        {
            if (_receiver!=null)
                _receiver.Action();
        }
    }
}
