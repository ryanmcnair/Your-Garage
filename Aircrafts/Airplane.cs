using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Aircrafts
{
    class Airplane : Aircraft
    {
        public string PlaneType { get; set; }

        public Airplane(string color, int fuelCapacity, int passengerOccupancy, string planeType)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            PlaneType = planeType;
        }
    }
}
