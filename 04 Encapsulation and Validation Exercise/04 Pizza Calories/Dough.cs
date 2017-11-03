using System;

public class Dough
{
    private string flourType { get; set; }
    //which can be white or wholegrain.
    private string bakingTechnique { get; set; }
    //which can be crispy, chewy or homemade.
    private decimal weight { get; set; }
    //A dough should have a weight in grams.

    public const int caloriesPerGram = 2;

    public Dough(string flourType, string bakingTechnique, decimal weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get
        {
            return this.flourType;
        }
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get
        {
            return this.bakingTechnique;
        }
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value;
        }
    }


    public decimal Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            if (value < 1 || 200 < value)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }

    public decimal Calories()
    {
        decimal totalCal = caloriesPerGram * this.Weight;

        switch (this.FlourType.ToLower())
        {
            case "white": totalCal *= 2; break;
            case "wholegrain": totalCal *= 1; break; //maybe this is useless
        }

        switch (this.BakingTechnique.ToLower())
        {
            case "crispy": totalCal *= 0.9m; break;
            case "chewy": totalCal *= 1.1m; break;
            case "homemade": totalCal *= 1; break; //maybe this is useless too
        }

        return totalCal;
    }
}
