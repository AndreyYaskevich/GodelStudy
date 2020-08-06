using System;
using System.Collections.Generic;
using System.Text;

namespace FabricPattern
{
    abstract class CarManufacturer
    {
        public string CarBrand { get; set; }

        public CarManufacturer(string CarBrand)
        {
            this.CarBrand = CarBrand;
        }

        abstract public Car Create();

    }
}
