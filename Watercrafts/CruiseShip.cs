using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Watercrafts
{
    class CruiseShip : Watercraft
    {
        public bool IsThereCatering { get; set; }

        public CruiseShip(string color, int fuelCapacity, int passengerOccupancy, bool isThereCatering)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            IsThereCatering = isThereCatering;
        }

    }
}
