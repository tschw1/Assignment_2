namespace Studierendenverwaltung;

class  Program
{
    static void Main(string[] args)
    {
        Student Toni = new Student("Toni", 123456, 19, [1,2,4]);
        Toni.showInfo();
    }
}