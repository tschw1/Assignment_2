namespace Tiere;

public abstract class Animal
{
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }

    //Methods
    public abstract void makeSound();

    //Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Cat : Animal
{
    //Properties
    public string Color { get; set; }
    public string Origin { get; set; }

    //Methods
    public override void makeSound()
    {
        Console.WriteLine("Miau");
    }
    public void catchMouse()
    {
        Console.WriteLine("Catching mouse");
    }

    //Constructor
    public Cat(string name, int age, string color, string origin) : base(name, age)
    {
        Color = color;
        Origin = origin;
    }
}

public class Dog : Animal
{
    //Properties
    public string Breed { get; set; }
    public string Gender { get; set; }

    //Methods
    public override void makeSound()
    {
        Console.WriteLine("Woof");
    }
    public void returnSticks()
    {
        Console.WriteLine("Getting the stick");
    }

    //Constructor
    public Dog(string name, int age, string breed, string gender) : base(name, age)
    {
        Breed = breed;
        Gender = gender;
    }
}