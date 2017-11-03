using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StartUp
{
    static void Main()
    {
        try
        {
            string[] nameOfThePizza = Console.ReadLine().Split();

            string[] nameOfTheDough = Console.ReadLine().Split();

            Dough dough = new Dough(nameOfTheDough[1], nameOfTheDough[2], decimal.Parse(nameOfTheDough[3]));

            Pizza currentPizza = new Pizza(nameOfThePizza[1], dough);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] currentTopping = input.Split();
                Topping topping = new Topping(currentTopping[1], decimal.Parse(currentTopping[2]));
                currentPizza.AddTopping(topping);
            }

            Console.WriteLine($"{currentPizza.Name} - {currentPizza.TotalCalories():f2} Calories.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}