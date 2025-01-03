﻿// Client Code - Using Factory Methods to create cars
using FactoryMethod.Cars;
using FactoryMethod.Factory;

Console.WriteLine("Lets build some cars...");

CarFactory suvFactory = new SUVFactory();
ICar suv = suvFactory.CreateCar();
suv.GetCarType();  // Output: This is an SUV.

CarFactory saloonFactory = new SaloonFactory();
ICar saloon = saloonFactory.CreateCar();
saloon.GetCarType();  // Output: This is a Saloon.

CarFactory truckFactory = new TruckFactory();
ICar truck = truckFactory.CreateCar();
truck.GetCarType();  // Output: This is a Truck.
