using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla smoothly glides down the highway. MMmmmmmm!");
        }

        // Add to the public method defined in Vehicle.cs
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The Tesla can turn {Direction} by itself.");
        }

        // Override the public method defined in Vehicle.cs
        public override void Stop()
        {
            Console.WriteLine($"The Tesla stops itself moments from disaster.");
        }
    }
}