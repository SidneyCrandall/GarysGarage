using System; 

using System.Collections.Generic;

namespace Garage
{
    public interface IGas
    {
        void RefuelTank();
        int CurrentTankPercentage { get; set; }
    }
}