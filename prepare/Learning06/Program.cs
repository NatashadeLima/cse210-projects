
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criação de instâncias das formas
        Shape square = new Square("Red", 5);
        Shape rectangle = new Rectangle("Blue", 4, 6);
        Shape circle = new Circle("Green", 3);

        // Lista para armazenar as formas
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };

        // Iterar pela lista e exibir informações
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea():F2}");
        }
    }
}
