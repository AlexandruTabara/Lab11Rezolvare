using Interfaces;
using Vehicles;
using System;
using System.Collections.Generic;
using System.Text;
using PumpStations;

namespace PumpStations
{      // Classic pumping station class
    public class ClassicPumpingStation : IPumpingStation
    {
        public bool CanSupply(FuelType fuelType)
        {
            return fuelType == FuelType.Petrol || fuelType == FuelType.Diesel || fuelType == FuelType.LPG;
        }

        public void SupplyFuel(IVehicle vehicle, FuelType fuelType, int quantity)
        {
            string fuel = fuelType.ToString();
            Console.WriteLine($"Filling up {vehicle.GetDescription()} with {quantity} liters of {fuel} fuel.");
        }
    }

}
