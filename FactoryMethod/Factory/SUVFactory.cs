using FactoryMethod.Cars;

namespace FactoryMethod.Factory;

/// <summary>
/// Concrete Creator 1 - SUV Factory
/// </summary>
public class SUVFactory : CarFactory
{
    /// <summary>
    /// Create an SUV car
    /// </summary>
    public override Car CreateCar()
    {
        return new SUV();
    }
}