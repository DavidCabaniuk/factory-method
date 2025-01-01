namespace FactoryMethod.Cars;

/// <summary>
/// Concrete product 3 (Truck)
/// </summary>
public class Truck : Car
{
    public override void GetCarType()
    {
        Console.WriteLine("This is a Truck.");
    }
}