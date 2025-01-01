namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 3 (Truck)
/// </summary>
public class Truck : ICar
{
    public void GetCarType()
    {
        Console.WriteLine("This is a Truck.");
    }
}