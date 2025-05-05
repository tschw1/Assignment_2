namespace Gehaelter;

class Program
{
    static void Main(string[] args)
    {
        Worker Peter = new PermanentEmployee("Peter", "IT", 10000);
        Worker Marie = new HourlyWageWorker("Marie", "IT", 15);
        Console.WriteLine(Peter.CalculateSalary());
        Console.WriteLine(Marie.CalculateSalary());
    }
}