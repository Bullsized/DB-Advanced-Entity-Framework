using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    static void Main()
    {
        int limit = int.Parse(Console.ReadLine());

        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < limit; i++)
        {
            string[] input = Console.ReadLine().Split();
            Employee currentEmployee = new Employee(input[0], decimal.Parse(input[1]), input[2], input[3], "n/a", -1);

            if (input.Length == 5)
            {
                CheckFifthIndex(input, currentEmployee);
            }
            else if (input.Length == 6)
            {
                currentEmployee.Email = input[4];
                currentEmployee.Age = int.Parse(input[5]);
            }

            employees.Add(currentEmployee);
        }
        //props to hammer4 for the following two rows:
        var bestPaidDept = employees.GroupBy(e => e.Department).Select(g => new { Department = g.Key, Avg = g.Average(e => e.Salary) }).ToList().OrderByDescending(d => d.Avg).ToList()[0].Department;

        Console.WriteLine($"Highest Average Salary: {bestPaidDept}");
        employees.Where(e => e.Department == bestPaidDept).OrderByDescending(e => e.Salary).ToList().ForEach(e => Console.WriteLine(e));

    }

    private static void CheckFifthIndex(string[] input, Employee currentEmployee)
    {
        if (input[4].Contains("@"))
        {
            currentEmployee.Email = input[4];
        }
        else
        {
            currentEmployee.Age = int.Parse(input[4]);
        }
    }
}