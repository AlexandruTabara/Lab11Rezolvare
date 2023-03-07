using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Vehicles;

namespace PumpStations
{
    public class HybridPumpingStation : IPumpingStation
    {
        public bool CanSupply(FuelType fuelType)
        {
            return true;
        }

        public void SupplyFuel(IVehicle vehicle, FuelType fuelType, int quantity)
        {
            string fuel = fuelType.ToString();
            Console.WriteLine($"Filling up {vehicle.GetDescription()} with {quantity}  liters of {fuel} fuel.");
        } 
    } 
}

