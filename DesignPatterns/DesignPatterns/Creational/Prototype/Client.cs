using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DesignPatterns.Common;

namespace DesignPatterns.Creational.Prototype
{
    public class Client: IClient
    {
        private Dictionary<string, Prototype> _prototypes = new Dictionary<string,Prototype>();
    
        public Prototype this[string key]
        {
            get { return _prototypes[key]; }
            set { _prototypes.Add(key, value); }
        }

        public void Run()
        {           
            //defaults
            this["one"] = new Prototype1("one");
            this["two"] = new Prototype2("two");

            //user defined
            this["three"] = new Prototype1("three");

            Prototype1 clonedPrototype1 = (Prototype1) this["one"].Clone();
            Console.WriteLine("Cloned: {0}", clonedPrototype1.Id);

            Prototype2 clonedPrototype2 = (Prototype2) this["two"].Clone();
            Console.WriteLine("Cloned: {0}", clonedPrototype2.Id);

            Console.ReadKey();
        }
    }
}
