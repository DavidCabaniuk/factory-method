﻿using FactoryMethod.Cars;

namespace FactoryMethod.Factory;

/// <summary>
/// Concrete Creator 2 - Saloon Factory
/// </summary>
public class SaloonFactory : CarFactory
{
    /// <summary>
    /// Create a Saloon car
    /// </summary>
    public override ICar CreateCar()
    {
        return new Saloon();
    }
}