using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class Decorator : Component
    {
        public Component Component { get; set; }

        public override void Operation()
        {
            Component.Operation();
        }
    }
}
