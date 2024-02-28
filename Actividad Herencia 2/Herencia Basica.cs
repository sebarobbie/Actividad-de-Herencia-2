using System;

// Clase base
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

// Clase derivada
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("The dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        myDog.Eat();  // Método heredado
        myDog.Bark(); // Método propio de la clase Dog
    }
}
