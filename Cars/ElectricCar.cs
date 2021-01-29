using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Cars
{
    class ElectricCar : Car
    {
        public bool IsElectric { get; set; }

        public ElectricCar(string color, int fuelCapacity, int passengerOccupancy, bool isElectric)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsElectric = isElectric;
        }
    }
}
