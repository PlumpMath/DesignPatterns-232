using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioural.Command
{
    public class Invoker
    {
        private Command _command;

        public Invoker()
        {
        }

        public Command Command
        {
            set
            {
                _command = value;
            }
        }

        public void ExecuteCommand()
        {
            if (_command!=null)
            {
                _command.Execute();
            }
        }
    }
}
