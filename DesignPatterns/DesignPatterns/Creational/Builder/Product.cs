using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    public class Product
    {
        private List<string> _parts = new List<string>();
    
        public void Show()
        {
            foreach (String part in _parts)
                Console.WriteLine(part);
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }
    }
}
