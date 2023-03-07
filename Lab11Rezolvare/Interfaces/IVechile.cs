using Vehicles;

namespace Interfaces
{ 
    //Define an interface for vechicles
    public interface IVehicle
    {
        string Model { get; }
        int Id { get; }
        string GetDescription();
    }
}
