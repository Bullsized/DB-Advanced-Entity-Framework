using System;

public class Box
{
    //length, width and height
    private decimal length { get; set; }
    private decimal width { get; set; }
    private decimal height { get; set; }

    public Box(decimal length, decimal width, decimal height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public decimal Length
    {
        get
        {
            return this.length;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public decimal Width
    {
        get
        {
            return this.width;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            this.width = value;
        }
    }

    public decimal Height
    {
        get
        {
            return this.height;
        }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public decimal Volume()
    {
        return this.Length * this.Width * this.Height;
    }

    public decimal LateralSurfaceArea()
    {
        return (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
    }

    public decimal SurfaceArea()
    {
        return (2 * this.Length * this.Width) + (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
    }
}
