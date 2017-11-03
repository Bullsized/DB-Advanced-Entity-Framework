using System;

public class Topping
{
    private string classes;
    private decimal weight;

    private const int baseCalories = 2;

    public Topping(string classes, decimal weight)
    {
        this.Classes = classes;       //MAKE SURE IT FIRST CAPITAL AND THEN LOWER ~
        this.Weight = weight;         //MAKE SURE IT FIRST CAPITAL AND THEN LOWER ~
    }

    private string Classes
    {
        get
        {
            return this.classes;
        }
        set
        {
            if (value.ToLower() != "meat" && 
                value.ToLower() != "veggies" &&
                value.ToLower() != "cheese" && 
                value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.classes = value;
        }
    }

    private decimal Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            if (value <1 || value > 50)
            {
                throw new ArgumentException($"{this.Classes} weight should be in the range[1..50].");
            }
            this.weight = value;
        }
    }

    public decimal Calories()
    {
        decimal totalCal = baseCalories * this.Weight;
        switch (this.Classes.ToLower())
        {
            case "meat": totalCal *= 1.2m; break;
            case "veggies": totalCal *= 0.8m; break;
            case "cheese": totalCal *= 1.1m; break;
            case "sauce": totalCal *= 0.9m; break;
        }
        return totalCal;
    }
}