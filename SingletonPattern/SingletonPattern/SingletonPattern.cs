using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class SingletonPattern
    {
        private static SingletonPattern instance = null;

        protected SingletonPattern() {
            
        }

        public static SingletonPattern getInstance()
        {
            if (instance == null)
            {
                instance = new SingletonPattern();
                Console.WriteLine("My name is Andrei and this is the first and only instance of SingletonPattern class");
            }
            else
                Console.WriteLine("No more instances of SingletonPattern class");
               
            return instance;
        }
    }
}
