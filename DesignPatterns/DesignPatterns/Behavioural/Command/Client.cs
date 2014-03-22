using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Behavioural.Command
{
    public class Client : IClient
    {
        public void Run()
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker(); //can receive multiple commands

            // Set and execute command
            invoker.Command = command;
            invoker.ExecuteCommand();

            Console.ReadKey();
        }
    }
}
