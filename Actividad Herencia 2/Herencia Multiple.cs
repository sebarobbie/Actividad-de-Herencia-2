using System;

// Interface 1
public interface IWalkable
{
    void Walk();
}

// Interface 2
public interface ISwimmable
{
    void Swim();
}

// Clase que implementa ambas interfaces
public class Frog : IWalkable, ISwimmable
{
    public void Walk()
    {
        Console.WriteLine("Frog is walking.");
    }

    public void Swim()
    {
        Console.WriteLine("Frog is swimming.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Frog frog = new Frog();
        frog.Walk(); // Método de la interfaz IWalkable
        frog.Swim(); // Método de la interfaz ISwimmable
    }
}
