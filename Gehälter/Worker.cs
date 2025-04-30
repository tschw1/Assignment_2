namespace Gehälter;

public abstract class Worker
{
    //Properties
    public string Name { get; set; }
    public string Department { get; set; }

    //Method
    public abstract double calculateSalary();

    //Constructor
    public Worker(string name, string department)
    {
        Name = name;
        Department = department;
    }
}

public class PermanentEmployee : Worker
{
    //Properties
    public double Salary { get; set; }

    //Methods
    public override double calculateSalary()
    {
        return Salary;
    }

    //Constructor
    public PermanentEmployee(string name, string department, double salary) : base(name, department)
    {
        Salary = salary;
    }
}

public class HourlyWageWorker : Worker
{
    //Properties
    public double HourlyWage { get; set; }

    //Methods
    private double HoursWorked()
    {
        Console.WriteLine($"Enter the hours {Name} worked: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());
        return hoursWorked;
    }
    public override double calculateSalary()
    {
        return HourlyWage * HoursWorked();
    }

    //Constructor
    public HourlyWageWorker(string name, string department, double hourlyWage) : base(name, department)
    {
        HourlyWage = hourlyWage;
    }
}