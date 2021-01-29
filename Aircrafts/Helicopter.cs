using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Aircrafts
{
    class Helicopter : Aircraft
    {
        public int NumberOfBlades { get; set; }

        public Helicopter(string color, int fuelCapacity, int passengerOccupancy, int numberOfBlades)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            NumberOfBlades = numberOfBlades;
        }
    }
}
