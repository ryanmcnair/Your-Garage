using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage.Watercrafts
{
    class Ferry : Watercraft
    {
        public string FerryType { get; set; }

        public Ferry(string color, int fuelCapacity, int passengerOccupancy, string ferryType)
        {
            Color = color;
            FuelCapacity = fuelCapacity;
            PassengerOccupancy = passengerOccupancy;
            FerryType = ferryType;
        }
        
    }
}
