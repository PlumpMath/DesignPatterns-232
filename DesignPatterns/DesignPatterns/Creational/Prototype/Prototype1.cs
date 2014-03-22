using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class Prototype1 : Prototype
    {
        public Prototype1(string id) : base(id) { }


        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
