using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition ommited
        }
        
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram growls by you. RRrrrrrummbbble!");
        }

        // Add to the public method defined in Vehicle.cs
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The Ram turns {Direction} in the field.");
        }

        // Override the public method defined in Vehicle.cs
        public override void Stop()
        {
            Console.WriteLine($"The Ram barrels to a stop.");
        }
    }
}
