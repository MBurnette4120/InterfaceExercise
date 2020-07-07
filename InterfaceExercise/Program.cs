using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var truck = new Truck();
            var vehicles = new List<IVehicle>() { car, truck };

            car.PaintColor = "Black";

            var nissan = new Car();
            nissan.PaintColor = "White";
            nissan.HasSunroof = true;
            nissan.NumDoors = 4;
            nissan.HasRadio = true;



            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
                

            }

            Console.WriteLine("________________________________________________________________________");

            var chevrolet = new SUV();
            var fordexpedition = new SUV();
            var fordexplorer = new SUV();
            var acuraMDX = new SUV();

            var sportUtilities = new List<IVehicle>() { chevrolet, fordexpedition, fordexplorer, acuraMDX };

            foreach (var vehicle1 in sportUtilities)
            {
                vehicle1.Drive();
                vehicle1.ChangeGears(true);
                vehicle1.Park();
                vehicle1.Reverse();
            }

            var listOfSuv = new List<IVehicle>() { chevrolet, fordexpedition, fordexplorer, acuraMDX };

            foreach (var sportUtility in listOfSuv)
            {
                sportUtility.Drive();
                sportUtility.Reverse();

            }
            Console.WriteLine($"This is the list of cars:");
            Console.WriteLine($"{sportUtilities}");





            

            
            
            
            
        }
    }
}
