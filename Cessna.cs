using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        // Unique property that is not defined across all types of vehicles
        public double FuelCapacity { get; set; }

        // Proprty that is unique to the Cessna 
        public void RefuelTank()
        {
            // method definition omitted
        }

        // used in order to over write and enhance the Drive() method. 
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna soars through the air. Zoooooom!");
        }
        
        // Add to the public method defined in Vehicle.cs
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The Cessna tilts {Direction}. ");
        }

        // Override the public method defined in Vehicle.cs
        public override void Stop()
        {
            Console.WriteLine($"The Cessna careens to stop on the runway.");
        }
    }
}