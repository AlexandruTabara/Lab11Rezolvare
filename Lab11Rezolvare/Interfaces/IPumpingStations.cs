using Vehicles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    // Pumping station interface to define common methods for all pumping stations
    public interface IPumpingStation
    {
        bool CanSupply(FuelType fuelType);
    }
}
