using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        List<Person> peopleAboveThirty = new List<Person>();

        int rotation = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotation; i++)
        {
            string[] inputParams = Console.ReadLine().Split(' ').ToArray();
            string name = inputParams[0];
            int age = int.Parse(inputParams[1]);

            Person currentPerson = new Person(name, age);

            peopleAboveThirty.Add(currentPerson);
        }

        foreach (Person person in peopleAboveThirty.Where(p => p.Age > 30).OrderBy(p => p.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}
