using System;

namespace FabricPattern
{
    class Program
    {
        public class CarFactory {
            public ICar MakeCar(string Name)
            {
                if (Name == "Tesla") return new ElectricCar();

                return new EngineCar();
            }
        }

        public interface ICar
        {
            void CreateCar();
        }

        public class EngineCar : ICar
        {
            public EngineCar()
            {
                CreateCar();
            }
            public void CreateCar()
            {
                Console.WriteLine("Created Car with internal combustion engine");
            }   
        }

        public class ElectricCar : ICar
        {
            public ElectricCar()
            {
                CreateCar();
            }

            public void CreateCar()
            {
                Console.WriteLine("Create Car with electric engine");
            }
        }


        static void Main(string[] args)
        {

            CarFactory factory = new CarFactory();

            factory.MakeCar("Tesla");

            factory.MakeCar("mercedes");

            Console.ReadKey();         

        }
    }
}
