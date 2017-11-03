using System;

public class Person
{
    private const int MinimumNameLength = 3;
    private const double MinimumSalary = 460;

    private string firstName { get; set; }
    private string lastName { get; set; }
    private int age { get; set; }
    private double salary { get; set; }

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        set
        {
            if (value.Length <= MinimumNameLength)
            {
                throw new ArgumentException($"First name cannot be less than {MinimumNameLength} symbols");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        set
        {
            if (value.Length <= MinimumNameLength)
            {
                throw new ArgumentException($"Last name cannot be less than {MinimumNameLength} symbols");
            }

            this.lastName = value;
        }
    }

    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }

            this.age = value;
        }
    }

    public double Salary
    {
        get
        {
            return this.salary;
        }
        set
        {
            if (value < MinimumSalary)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva");
            }

            this.salary = value;
        }
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