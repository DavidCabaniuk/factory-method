namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 2 (Saloon)
/// </summary>
public class Saloon : Car
{
    public override void GetCarType()
    {
        Console.WriteLine("This is a Saloon.");
    }
}