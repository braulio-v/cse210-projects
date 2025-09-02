using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square first = new Square(45, "amarillo");


        string color1 = first.GetColor();
        double area1 = first.GetArea();

        Console.WriteLine(color1);
        Console.WriteLine(area1);

        Rectangle second = new Rectangle(4,5,"Blue");

        Circle third = new Circle(6,"Green");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(first);
        shapes.Add(second);
        shapes.Add(third);

        foreach (Shape list in shapes)
        {
            string color = list.GetColor();

            double area = list.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}