using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Cars
{
    class DumpTruck : Car
    {
        public string ConstructionMaterial { get; set; }

        public DumpTruck(string color, int fuelCapacity, int passengerOccupancy, string constructionMaterial)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            ConstructionMaterial = constructionMaterial;
        }
    }
}
