using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class Composite : Component
    {
        protected List<Component> _components = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            _components.Add(component);
        }

        public override void Remove(Component component)
        {
            _components.Remove(component);
        }

        public override void Display(int depth)
        {            
            Console.WriteLine(new String('-', depth) + Name);

            // Recursively display child nodes
            foreach (Component component in _components)
            {
                component.Display(depth+2);
            }
        }
    }
}
