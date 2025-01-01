using FactoryMethod.Cars;

namespace FactoryMethod.Factory;

/// <summary>
/// Creator (CarFactory) - Abstract class with factory method
/// </summary>
public abstract class CarFactory
{
    /// <summary>
    /// Factory Method - Returns the product
    /// </summary>
    public abstract Car CreateCar();
}
