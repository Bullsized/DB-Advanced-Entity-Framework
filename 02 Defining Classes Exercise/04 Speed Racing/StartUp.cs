using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    public static void Main()
    {
        List<Car> listOfCars = new List<Car>();

        int rotation = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotation; i++)
        {
            string[] carTemplate = Console.ReadLine().Split().ToArray();
            string carModel = carTemplate[0];
            decimal fuelAmount = decimal.Parse(carTemplate[1]);
            decimal fuelConsumption = decimal.Parse(carTemplate[2]);

            Car currentCar = new Car(carModel, fuelAmount, fuelConsumption, 0m);
            listOfCars.Add(currentCar);
        }

        string letsDrive;
        while ((letsDrive = Console.ReadLine()) != "End")
        {
            string[] driveTemplate = letsDrive.Split().ToArray();
            string particularCar = driveTemplate[1];
            decimal amountOfKM = decimal.Parse(driveTemplate[2]);
            listOfCars.First(a => a.Model == particularCar).Drive(amountOfKM);
        }

        foreach (Car car in listOfCars)
        {
            Console.WriteLine("{0} {1:f2} {2}", car.Model, car.FuelAmount, car.DistanceTravelled);
        }
    }
}
