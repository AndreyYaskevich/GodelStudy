using System;
using System.Collections.Generic;
using System.Text;

namespace FabricPattern
{
    class EngineCarDeveloper : CarManufacturer
    {
        public EngineCarDeveloper(string n) : base(n) { }

        public override Car Create()
        {
            return new EngineCar();
        }
    }
}
