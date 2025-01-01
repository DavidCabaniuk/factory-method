using FactoryMethod.Cars;

namespace FactoryMethod.Factory;

/// <summary>
/// Concrete Creator 3 - Truck Factory
/// </summary>
public class TruckFactory : CarFactory
{
    /// <summary>
    /// Create a Truck car
    /// </summary>
    public override ICar CreateCar()
    {
        return new Truck();
    }
}