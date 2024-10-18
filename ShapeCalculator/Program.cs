namespace ShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(7);
            Console.WriteLine("Circle area: " + circle.GetArea());
            Console.WriteLine("");
            Circle sphere = new Circle(5);
            Console.WriteLine("Sphere area " + circle.GetArea());
            Console.WriteLine("Sphere surface area " + circle.GetCircumference());
            Console.WriteLine("Sphere volume " + circle.GetVolume());

            Console.WriteLine("*********TRIANGLE***********");
            Triangle triangle = new Triangle(9, 6, 13);
            Console.WriteLine("Triangle area: " + triangle.GetArea());
            Console.WriteLine("Tringle circumference: " + triangle.GetCircumference());
        }
    }
}
