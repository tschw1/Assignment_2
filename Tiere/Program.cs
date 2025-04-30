namespace Tiere;

class Program
{
    static void Main(string[] args)
    {
        Dog Kylo = new Dog("Kylo", 5, "Pug", "Male");
        Cat Kitty = new Cat("Kitty", 3, "orange", "Italy");
        Kylo.makeSound();
        Kylo.returnSticks();
        Kitty.makeSound();
        Kitty.catchMouse();
    }
}