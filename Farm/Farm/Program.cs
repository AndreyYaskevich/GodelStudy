using System;

namespace Farm
{
    

    class Program
    {
        public class Farm
        {
            public IChicken CreateChicken(string sex)
            {
                if (sex == "male") return new Rooster();

                return new Hen();
            }
        }

        public class Rooster : IChicken
        {
            public Rooster()
            {
                Action();
            }
            public void Action()
            {
                Console.WriteLine("I got into a fight with everyone on the farm");
            }
        }

        public class Hen : IChicken
        {
            public Hen()
            {
                Action();
            }

            public void Action()
            {
                Console.WriteLine("Ok, i laid an egg");
            }
        }

        public interface IChicken
        {
            void Action();
        }

        static void Main(string[] args)
        {
            Farm farm = new Farm();

            farm.CreateChicken("male");

            Console.ReadKey();
        }
    }
}
