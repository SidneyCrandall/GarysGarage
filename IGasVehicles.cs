using System; 

using System.Collections.Generic;

namespace Garage
{
    public interface IGasVehicles
    {
        void RefuelTank();
        int CurrentTankPercentage { get; set; }
        double FuelCapacity { get; set; }
    }
}