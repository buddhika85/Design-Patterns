/// <summary>
/// Abstract factory - it can be an abstract clss or an interface
/// </summary>

namespace Abstract_Factory
{
    interface IContinentFactory
    {
        IPlantEater CreatePlantEater();
        IMeatEater CreateMeatEater();
    }
}
