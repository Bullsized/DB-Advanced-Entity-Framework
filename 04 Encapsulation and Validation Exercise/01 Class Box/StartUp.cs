using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class StartUp
{
    static void Main()
    {
        Box currentBox = new Box(decimal.Parse(Console.ReadLine()),
                                 decimal.Parse(Console.ReadLine()),
                                 decimal.Parse(Console.ReadLine()));

        Type boxType = typeof(Box);
        FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        Console.WriteLine(fields.Count());

        Console.WriteLine("Surface Area - {0:f2}", currentBox.SurfaceArea());
        Console.WriteLine("Lateral Surface Area - {0:f2}", currentBox.LateralSurfaceArea());
        Console.WriteLine("Volume - {0:f2}", currentBox.Volume());
    }
}