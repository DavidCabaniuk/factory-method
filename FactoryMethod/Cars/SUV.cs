namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 1 (SUV)
/// </summary>
public class SUV : Car
{
    public override void GetCarType()
    {
        Console.WriteLine("This is an SUV.");
    }
}
