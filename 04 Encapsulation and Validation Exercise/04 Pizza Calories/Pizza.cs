using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pizza
{
    private string name { get; set; }
    private Dough myDough { get; set; }
    private List<Topping> myToppings { get; set; }

    public Pizza(string name, Dough myDough)
    {
        this.Name = name;
        this.MyDough = myDough;
        this.myToppings = new List<Topping>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == string.Empty || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }

    public Dough MyDough
    {
        get
        {
            return this.myDough;
        }
        set
        {
            this.myDough = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        if (this.myToppings.Count > 10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
        this.myToppings.Add(topping);
    }

    public decimal TotalCalories()
    {
        decimal totalCal = this.myDough.Calories();
        foreach (var item in this.myToppings)
        {
            totalCal += item.Calories();
        }
        return totalCal;
    }
}
