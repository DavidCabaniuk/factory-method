namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 2 (Saloon)
/// </summary>
public class Saloon : ICar
{
    public void GetCarType()
    {
        Console.WriteLine("This is a Saloon.");
    }
}