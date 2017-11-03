using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Box
{
    //length, width and height
    private decimal length { get; set; }
    private decimal width { get; set; }
    private decimal height { get; set; }

    public Box(decimal length, decimal width, decimal height)
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public decimal Length
    {
        get
        {
            return this.length;
        }
        set
        {
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
            this.height = value;
        }
    }
    /*
    Volume = lwh
    Lateral Surface Area = 2lh + 2wh
    Surface Area = 2lw + 2lh + 2wh
    */

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
