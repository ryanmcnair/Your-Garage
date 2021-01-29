using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Aircraft : Vehicle
    {

        public void Flying()
        {
            Console.WriteLine($"The {Color} aircraft is flying");
        }
        
        public void Landing()
        {
            Console.WriteLine($"The {Color} aircraft with {PassengerOccupancy} passengers is landing");
        }
    }
}
