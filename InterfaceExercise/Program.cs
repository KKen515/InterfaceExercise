using System;
using System.Collections.Generic;
using System.Threading;

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


            var vehiclesListRed = new List<IVehicle>() { carOne, truckOne, SUVOne };
            var vehiclesListGreen = new List<IVehicle>() {truckOne, SUVOne };
            var vehiclesListBlue = new List<IVehicle>() { SUVOne };

            
            foreach (var vehicle in vehiclesListRed)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model}, made in {vehicle.Year}.");
                Thread.Sleep(2000);
                break;
            }

            
            foreach (var vehicle in vehiclesListGreen)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model}, made in {vehicle.Year}.");
                Thread.Sleep(2000);
                break;
            }

            
            foreach (var vehicle in vehiclesListBlue)
            {

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"This is a {vehicle.Make} {vehicle.Model}, made in {vehicle.Year}.");
                Thread.Sleep(2000);
                break;
            }


        }
    }
}
