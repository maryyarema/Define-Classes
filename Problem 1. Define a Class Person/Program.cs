using System;

Person[] people =
{
    new("Вася", 80),
    new("Рома", 45),
    new ("Михайло",30)

};

foreach (Person person in people)
{
    Console.WriteLine(person.DisplayInfo());
}

sealed class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name
    {
        get => name;
        set
        {
            name = value;
        }
    }
    public int Age
    {
        get => age;
        set
        {
            age = value;
        }
    }

    public string DisplayInfo()
    {
        return $"{Name}  {Age} ";
    }
}
