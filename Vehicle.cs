using System;

namespace Garage
{
    public class Vehicle
    {
        // Properties shared by all vehicles that will be defined later in the Program.cs
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        // Public method that will be overwritten or enhanced later. 
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        // Public method that tells how the vehicle should turn
        public virtual void Turn(string Direction)
        {
            Console.WriteLine($"The vehicle turns {Direction} towards destiny.");
        }

        // Public method that tells how the car stops
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gentle comes to a complete stop.");
        }
    }
}