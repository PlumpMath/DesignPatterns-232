using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Add(Component component)
        {
            throw new NotImplementedException("Cannot add to a leaf");
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {            
            Console.WriteLine(new String('-', depth) + Name);
        }
    }
}
