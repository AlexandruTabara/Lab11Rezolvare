using System;
using Interfaces;
using Vehicles;
using PumpStations;

namespace Lab11Rezolvare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate pumping stations
            ClassicPumpingStation classicStation = new ClassicPumpingStation();
            HybridPumpingStation hybridStation = new HybridPumpingStation();

            // Create new vehicles
            PetrolVehicle petrolVehicle = new PetrolVehicle("Audi", 123);
            DieselVehicle dieselVehicle = new DieselVehicle("BMW", 456);
            LpgVehicle lpgVehicle = new LpgVehicle("Mercedes", 789);
            ElectricVehicle electricVehicle = new ElectricVehicle("Tesla", 101);
            PlugInHybridVehicle hybridVehicle = new PlugInHybridVehicle("Toyota", 112);

            // Fuel vehicles
            classicStation.SupplyFuel(petrolVehicle, FuelType.Petrol, 50);
            classicStation.SupplyFuel(dieselVehicle, FuelType.Diesel, 40);
            classicStation.SupplyFuel(lpgVehicle, FuelType.LPG, 30);

            hybridStation.SupplyFuel(electricVehicle, FuelType.Electric, 20);
            hybridStation.SupplyFuel(hybridVehicle, FuelType.Petrol, 25);
            hybridStation.SupplyFuel(hybridVehicle, FuelType.Electric, 10);

            Console.ReadLine();
        }
    }
}

