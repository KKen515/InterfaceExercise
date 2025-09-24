using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            
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






            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
