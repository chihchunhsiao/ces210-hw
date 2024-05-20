using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("yellow", 50.0);

        // Console.WriteLine(square.GetColor());
        // Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle(10.0, 20.2, "blue");
        // Console.WriteLine(rectangle.GetColor());
        // Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle(10.0, "red");
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}.");
        }


    }
}