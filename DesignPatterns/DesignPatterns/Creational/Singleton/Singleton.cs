using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        private static object syncLock = new object();

        protected Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncLock)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
    }
}
