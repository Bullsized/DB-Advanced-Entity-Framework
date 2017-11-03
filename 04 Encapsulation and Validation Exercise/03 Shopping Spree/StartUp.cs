using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StartUp
{
    static void Main()
    {
        List<Person> personList = new List<Person>();

        List<Product> productList = new List<Product>();

        string[] personInput = Console.ReadLine().Split(';').ToArray();

        for (int i = 0; i < personInput.Length; i++)
        {
            string[] splitNameAndMoney = personInput[i].Split('=');
            string currentName = splitNameAndMoney[0];
            decimal currentMoney = decimal.Parse(splitNameAndMoney[1]);
            if (currentMoney < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            Person currentPerson = new Person(currentName, currentMoney, new List<Product>());
            personList.Add(currentPerson);
        }

        string[] productInput = Console.ReadLine().Split(';');
        for (int i = 0; i < productInput.Length; i++)
        {
            if (productInput[i].Length > 1)
            {
                string[] splitProductAndMoney = productInput[i].Split('=');
                string currentProduct = splitProductAndMoney[0];
                decimal currentPrice = decimal.Parse(splitProductAndMoney[1]);
                if (currentPrice < 0)
                {
                    throw new ArgumentException("Price cannot be zero or negative");
                }
                Product currentProd = new Product(currentProduct, currentPrice);
                productList.Add(currentProd);
            }
        }

        string command;

        while ((command = Console.ReadLine()) != "END")
        {
            string[] order = command.Split();
            var person = personList.First(p => p.Name == order[0]);
            var product = productList.First(p => p.Name == order[1]);
            try
            {
                person.BuyProduct(product);
                Console.WriteLine($"{person.Name} bought {product.Name}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        foreach (Person person in personList)
        {
            if (person.BagOfProducts.Count >= 1)
            {
                Console.WriteLine(person.Name + " - " + string.Join(", ", person.BagOfProducts));
            }
            else
            {
                Console.WriteLine(person.Name + " - Nothing bought");
            }
        }
    }
}