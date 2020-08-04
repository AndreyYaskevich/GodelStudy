using System;

namespace IsPalindrome
{
    class Program
    {
        
        static bool IsPalyndrome (string word)
        {
            char[] symbol = word.ToLower().ToCharArray();
            
            for (int i=0; i<symbol.Length/2; i++)
            {
                if (symbol[i] == symbol[symbol.Length - 1]) return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            Console.WriteLine(IsPalyndrome(word));

            Console.ReadKey();

        }
    }
}
