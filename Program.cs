using System;

using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Creating properties for the vehicles
            // added Zero FX due to new code in exercise
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            // Interfaces added for exercise
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fxs, fx, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/
            Cessna mx410 = new Cessna();
            Ram dodge22 = new Ram();

            List<IGasVehicles> gasVehicles = new List<IGasVehicles>() 
            {
                dodge22, mx410
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGasVehicles gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            // Giving the vehicles color
            fxs.MainColor = "Red";
            modelS.MainColor = "Slate Gray";
            mx410.MainColor = "Black";
            dodge22.MainColor = "Blue";

            // Defining the property of MaxiumOccupancy
            fxs.MaximumOccupancy = 1;
            modelS.MaximumOccupancy = 4;
            mx410.MaximumOccupancy = 2;
            dodge22.MaximumOccupancy = 2;

            // Defining the properties belonging to the cars. (Electric)
            fxs.BatteryKWh = 56.3;
            modelS.BatteryKWh = 44.3;

            // Defining the fuel Tank.
            mx410.FuelCapacity = 12.4;
            dodge22.FuelCapacity = 8.5;
            
            // Invoking of Zero methods, defined in each cars public class.
            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();

            // Invoking of Tesla methods and properties.
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();
 
            // Invoking the Cessna methods and properties.
            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            Console.WriteLine();

            // Invoking Ram methods and properties.
            dodge22.Drive();
            dodge22.Turn("right");
            dodge22.Stop();
            Console.WriteLine();

        }
    }
}
