using System;

//primero creamos una clase abstracta llamada shape, para que almacene el ancho y el alto de la figura
public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    public Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalculateSurface();
}
//creamos la clase rectangle de manera que herede de la clase shape para que utilice los valores alto y ancho
public class Rectangle : Shape
{
    public Rectangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}
//seguimos el miskmo proceso con la clase triangle
public class Triangle : Shape
{
    public Triangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}

public class Circle : Shape
{
    public Circle(double radio) : base(radio, radio) { }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Ancho, 2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ejemplo de uso
        Shape[] shapes = new Shape[]
        {
            new Rectangle(4, 5),
            new Triangle(4, 5),
            new Circle(3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Área de {shape.GetType().Name}: {shape.CalculateSurface()}");
        }
    }
}
