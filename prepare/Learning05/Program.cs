using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Green", 3);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Red", 3, 4);
        shapes.Add(rectangle);
        Circle circle = new Circle("Blue", 3);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}