using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Watercraft : Vehicle
    {

        public void Driving()
        {
            Console.WriteLine($"The {Color} watercraft is carrying {PassengerOccupancy} passengers");
        }
    }
}
