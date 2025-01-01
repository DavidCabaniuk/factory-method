using FactoryMethod.Cars;

namespace FactoryMethod.Factory;

public abstract class CarFactory
{
    /// <summary>
    /// Factory Method - Returns the product
    /// </summary>
    public abstract Car CreateCar();
}
