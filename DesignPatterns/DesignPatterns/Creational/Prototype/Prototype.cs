using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            _id = id;
        }

        public string Id
        {
            get { return _id; }
            protected set { _id = value; } 
        }

        public abstract Prototype Clone();
    }
}
