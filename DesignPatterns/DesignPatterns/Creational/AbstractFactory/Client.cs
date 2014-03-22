using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Common;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Client : IClient
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }
    
        public void Run()
        {
            Console.WriteLine(_abstractProductA.ToString());
            Console.WriteLine(_abstractProductB.ToString());
        }
    }
}
