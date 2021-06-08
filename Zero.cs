using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method body omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips pass. Yeeeeeoooooowwww!");
        }

        // Add to the public method defined in Vehicle.cs
        public override void Turn(string Direction)
        {
            Console.WriteLine($"The Zero zooms {Direction} passing the cafe.");
        }

        // Override the public method defined in Vehicle.cs
        public override void Stop()
        {
            Console.WriteLine($"The Zero gently stops on the street corner.");
        }
    }
}