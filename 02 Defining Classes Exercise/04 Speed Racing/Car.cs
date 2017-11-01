using System;

public class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumption { get; set; }
    public decimal DistanceTravelled { get; set; }

    //ctrl + .   brings up the whole constructor creating setup, ez pz

    public Car(string model, decimal fuelAmount, decimal fuelConsumption, decimal distanceTravelled)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTravelled = distanceTravelled;
    }

    public void Drive(decimal amountOfKM)
    {
        if (this.FuelConsumption * amountOfKM < this.FuelAmount)
        {
            this.FuelAmount -= this.FuelConsumption * amountOfKM;
            this.DistanceTravelled += amountOfKM;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}