using System;

namespace SingletonPattern
{
    class Program
    {
       
        static void Main(string[] args)
        {
            SingletonPattern s1 = SingletonPattern.getInstance();
            SingletonPattern s2 = SingletonPattern.getInstance();

            Console.ReadKey();
        }
    }
}
