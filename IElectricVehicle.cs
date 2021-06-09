using System;

using System.Collections.Generic;

namespace Garage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }
        int CurrentChargePercentage { get; set; }
        void ChargeBattery(); 
    }
}