using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public Facade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            _one.Method1();
            _two.Method2();
            _four.Method4();    
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            _two.Method2();
            _three.Method3();
        }
    }
}
