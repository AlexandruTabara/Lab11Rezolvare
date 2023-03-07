using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Vehicles
{
    // Define the different vehicle types that implement the IVehicle interface
    public class PetrolVehicle : IVehicle
    {
        public string Model { get; }
        public int Id { get; }

        public PetrolVehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }

        public string GetDescription()
        {
            return $"Petrol vehicle {Model} (ID: {Id})";
        }
    }

    public class DieselVehicle : IVehicle
    {
        public string Model { get; }
        public int Id { get; }

        public DieselVehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }

        public DieselVehicle(string v1, string v2)
        {
        }

        public string GetDescription()
        {
            return $"Diesel vehicle {Model} (ID: {Id})";
        }
    }

    public class LpgVehicle : IVehicle
    {
        public string Model { get; }
        public int Id { get; }

        public LpgVehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }

        public string GetDescription()
        {
            return $"LPG vehicle {Model} (ID: {Id})";
        }


    }
    public class ElectricVehicle : IVehicle
    {
        public string Model { get; }
        public int Id { get; }

        public ElectricVehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }

        public string GetDescription()
        {
            return $"Electric vehicle {Model} (ID: {Id})";
        }
    }
    public class PlugInHybridVehicle : IVehicle
    {
        public string Model { get; }
        public int Id { get; }

        public PlugInHybridVehicle(string model, int id)
        {
            Model = model;
            Id = id;
        }

        public string GetDescription()
        {
            return $"Hybrid vehicle {Model} (ID: {Id})";
        }
    }
    public enum FuelType
    {
        Petrol,
        Diesel,
        LPG,
        Electric,
        None
    }
}    
