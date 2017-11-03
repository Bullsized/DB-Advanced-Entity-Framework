using System;

public class Product
{
    //Each product should have name and price. The name cannot be an empty string. The price cannot be negative or zero. 
    private string name;
    private decimal price;

    public Product(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value == string.Empty || value.Length < 1)
            {
                throw new ArgumentException("The name cannot be an empty string.");
            }
            this.name = value;
        }
    }
    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("The price cannot be negative or zero.");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return this.name;
    }
}
