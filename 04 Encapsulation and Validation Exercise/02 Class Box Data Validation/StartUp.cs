using System;
using System.Linq;
using System.Reflection;

class StartUp
{
    static void Main()
    {
        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        try
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            Box currentBox = new Box(length, width, height);
            Console.WriteLine("Surface Area - {0:f2}", currentBox.SurfaceArea());
            Console.WriteLine("Lateral Surface Area - {0:f2}", currentBox.LateralSurfaceArea());
            Console.WriteLine("Volume - {0:f2}", currentBox.Volume());
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}