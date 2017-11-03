using System;


class StartUp
{
    static void Main()
    {
        int rotation = int.Parse(Console.ReadLine());
        Team team = new Team("Autobots");

        for (int i = 0; i < rotation; i++)
        {
            var input = Console.ReadLine().Split();
            string firstName = input[0];
            string lastName = input[1];
            int age = int.Parse(input[2]);
            double salary = double.Parse(input[3]);

            Person person = new Person(firstName, lastName, age, salary);

            team.AddPlayer(person);
        }

        Console.WriteLine($"First team has {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players");
    }
}