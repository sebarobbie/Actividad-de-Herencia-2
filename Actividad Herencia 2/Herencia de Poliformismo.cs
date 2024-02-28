using System;

// Clase base
public class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("Vehicle is moving.");
    }
}

// Clase derivada
public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving on the road.");
    }
}

// Otra clase derivada
public class Boat : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Boat is moving on water.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Car();
        Vehicle vehicle2 = new Boat();

        vehicle1.Move(); // Polimorfismo: llama al método de la clase derivada Car
        vehicle2.Move(); // Polimorfismo: llama al método de la clase derivada Boat
    }
}
