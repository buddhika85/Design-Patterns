using Builder.Builder;

namespace Builder.Director
{
    /// <summary>
    /// Builds a vehicle object with an instance of VehicleBuilder class,  but do not know which type of an vehicle it is  building
    /// </summary>
    class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
