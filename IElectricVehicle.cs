using System;

using System.Collections.Generic;

namespace Garage
{
    public interface IElectric
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery(); 
    }
}