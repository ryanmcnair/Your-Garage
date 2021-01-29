using System;
using System.Collections.Generic;
using Your_Garage.Aircrafts;
using Your_Garage.Cars;
using Your_Garage.Watercrafts;

namespace Your_Garage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            // With a single `foreach`, have each vehicle Fly()
            var airCrafts = new List<Aircraft> { new Airplane("pink", 3, 8, "Propeller"), new Helicopter("red", 8, 100, 500) };
            foreach (var airCraft in airCrafts)
            {
                airCraft.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            // With a single `foreach`, have each road vehicle Drive()
            var roadVehicles = new List<Car> { new DumpTruck("blue", 100, 50, "rocks"), new ElectricCar("grey", 5, 4, true) };
            foreach (var car in roadVehicles)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            // With a single `foreach`, have each water vehicle Drive()
            var waterVehicles = new List<Watercraft> { new CruiseShip("neon", 10, 5000, true), new Ferry("orange", 1000, 12, "car") };
            foreach (var boat in waterVehicles)
            {
                boat.Driving();
            }
        }
    }
}
