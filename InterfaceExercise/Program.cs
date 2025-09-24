using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Toyota";
            carOne.Model = "Corolla";
            carOne.Year = 2005;
            carOne.Motto = "Let's go places";
            carOne.Headquarters = "Toyota City, Aichi, Japan.";
            carOne.RideColor = "Black";
            carOne.HasSeatbelts = true;
            carOne.NumberofWheels = "4";
            
            var truckOne = new Truck();
            truckOne.Make = "Ford";
            truckOne.Model = "Maverick";
            truckOne.Year = 1970;
            truckOne.Motto = "Built Ford Tough";
            truckOne.Headquarters = "Dearborn, Michigan";
            truckOne.RideColor = "Navy Blue";
            truckOne.HasCargoBed = true;
            truckOne.CarSeatsNumber = 5;
            
            var SUVOne = new SUV();
            SUVOne.Make = "Fisker";
            SUVOne.Model = "Ocean";
            SUVOne.Year = 2024;
            SUVOne.Motto = "The World's Most Emotional and Sustainable Vehicles";
            SUVOne.Headquarters = "Manhattan Beach in Los Angeles County, California";
            SUVOne.RideColor = "Ocean Blue";
            SUVOne.LicensePlate = "Miscellaneous Combination";
            SUVOne.Mileage = 300;


            var VehiclesList = new List<IVehicle>() {carOne, truckOne, SUVOne};

            foreach (var vehicle in VehiclesList)
            {
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model}, made in {vehicle.Year}.");
            }
            
        }
    }
}
