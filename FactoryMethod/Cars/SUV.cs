namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 1 (SUV)
/// </summary>
public class SUV : ICar
{
    public void GetCarType()
    {
        Console.WriteLine("This is an SUV.");
    }
}
