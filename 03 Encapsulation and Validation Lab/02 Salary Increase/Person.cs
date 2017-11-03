using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
    private string firstName { get; set; }
    private string lastName { get; set; }
    private int age { get; set; }
    private double salary { get; set; }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
    }

    public string LastName
    {
        get { return this.lastName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public double Salary
    {
        get { return this.salary; }
        private set { this.salary = value; }
    }

    public void SalaryBonus(double bonus)
    {
        if (this.Age < 30)
        {
            bonus /= 2;
        }
        this.Salary += this.Salary * bonus / 100;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} gets {salary:f2} leva";
    }
}