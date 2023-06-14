using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> Shapes = new List<Shape>();

        Square square = new Square("blue", 5);
        Shapes.Add(square);

        Rectangle rect = new Rectangle("Red", 4, 5);
        Shapes.Add(rect);

        Circle cir = new Circle("Purple", 4);
        Shapes.Add(cir);

        foreach (Shape shape in Shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area:F2}");
        }
    }
    
}