using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    public class Proxy : Subject
    {
        private RealSubject _subject;
        public Proxy ()
        {
        }

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_subject == null)
            {
                _subject = new RealSubject();
            }
            //do other things. Check security
            _subject.Request();
        }
    }
}
