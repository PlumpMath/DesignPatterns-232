using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Structural.Adapter
{
    public class Client : IClient
    {
        public void Run()
        {            
            Target target = new Adapter();

            target.Request();
        }
    }
}
