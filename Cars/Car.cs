using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Car : Vehicle
    {
       
        public void Driving()
        {
            Console.WriteLine($"The {Color} car can transport {PassengerOccupancy} people");
        }

        public void Braking()
        {
            Console.WriteLine($"The {Color} is braking");
        }
    }
}
