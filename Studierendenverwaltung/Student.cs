namespace Studierendenverwaltung;

public class Student
{
    //Properties
    public string Name { get; set; }
    public int Matrikelnummer { get; set; }
    public int Age { get; set; }
    public double[] Grades { get; set; }

    //Methods
    public void addGrade()
    {
        Console.WriteLine("Enter the grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());
        if (grade < 1 || grade > 6)
        {
            Console.WriteLine("The grade has to be between 1 and 6.");
        }
        else
        {
            int index = Grades.Length + 1;
            Grades[index] = grade;
            Console.WriteLine("Grade added.");
        }
    }
    public double getAverage()
    {
        double sum = 0;
        foreach (double grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }
    public void showInfo()
    {
        Console.WriteLine("Name: " + Name + "\nMatrikelnummer: " + Matrikelnummer + "\nAlter: " + Age + "\nDurchschnittsnote: " + getAverage());
    }

    //Constructor
    public Student(string name, int matrikelnummer, int age, double[] grades)
    {
        Name = name;
        Matrikelnummer = matrikelnummer;
        Age = age;
        Grades = grades;
    }
}