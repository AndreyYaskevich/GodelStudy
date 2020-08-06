using System;
using System.Collections.Generic;
using System.Text;

namespace FabricPattern
{
    class ElectricCarDeveloper: CarManufacturer
    {
        public ElectricCarDeveloper(string n) : base(n) { }

        public override Car Create()
        {
            return new ElectricCar();
        }
    }
}
