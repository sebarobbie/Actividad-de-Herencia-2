using System;

// Clase base
public class Person
{
    protected string name;

    public Person(string name)
    {
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
    }
}

// Clase derivada
public class Employee : Person
{
    private string company;

    public Employee(string name, string company) : base(name)
    {
        this.company = company;
    }

    public void DisplayCompany()
    {
        Console.WriteLine("Company: " + company);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee("John", "XYZ Inc.");
        emp.Display();        // Método heredado
        emp.DisplayCompany(); // Método propio de la clase Employee
    }
}
