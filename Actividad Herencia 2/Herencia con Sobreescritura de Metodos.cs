using System;

// Clase base
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Clase derivada
public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Circle();
        shape.Draw(); // Llama al método sobreescrito en la clase derivada
    }
}
