using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class Prototype2 : Prototype
    {
        public Prototype2(string id) : base(id) { }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
