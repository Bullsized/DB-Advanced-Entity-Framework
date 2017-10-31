class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    /*
     * 1.	The first should take no arguments and produce a person with name “No name” and age = 1. 
    2.	The second should accept only an integer number for the age and produce a person with name “No name” and age equal to the passed parameter.
    3.	The third one should accept a string for the name and an integer for the age and should produce a person with the given name and age.
    */
    public Person()
    {
        this.Name = "No name";
        this.Age = 1;
    }

    public Person(int age)
    {
        this.Name = "No name";
        this.Age = age;
    }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}