using System;

namespace FabricPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManufacturer bmw = new EngineCarDeveloper("BMW");
            Car engineCar = bmw.Create();

            CarManufacturer tesla = new ElectricCarDeveloper("TESLA");
            Car electricCAr = tesla.Create();

            Console.ReadKey();         

        }
    }
}
