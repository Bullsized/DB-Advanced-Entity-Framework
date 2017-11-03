using System;
using System.Collections.Generic;

public class Person
{
    //Each person should have a name, money and a bag of products. 
    private string name { get; set; }
    private decimal money { get; set; }
    private List<Product> bagOfProducts;

    public Person(string name, decimal money, List<Product> bagOfProducts)
    {
        this.name = name;
        this.money = money;
        this.bagOfProducts = new List<Product>();
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

    public decimal Money
    {
        get
        {
            return this.money;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<Product> BagOfProducts
    {
        get
        {
            return this.bagOfProducts;
        }
    }

    public void BuyProduct(Product product)
    {
        if (product.Price <= this.money)
        {
            this.money -= product.Price;
            this.bagOfProducts.Add(product);
        }
        else
        {
            throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
        }
    }

    public override string ToString()
    {
        if (this.bagOfProducts.Count > 0)
        {
            return $"{this.Name} - {string.Join(", ", this.bagOfProducts)}";
        }
        else
        {
            return $"{this.Name} - Nothing bought";
        }
    }
}
