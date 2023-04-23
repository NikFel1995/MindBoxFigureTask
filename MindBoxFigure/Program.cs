namespace MindBoxFigure
{
    internal class Program
    {
        private static void Main()
        {
            IShape[] shapes = new IShape[] { new Triangle(3, 4, 5), new Circle(2), new Triangle(5, 8, 6) };

            foreach (var shape in shapes)
            {
                if (shape is Triangle)
                    Console.WriteLine($"{((Triangle)shape).triangleType} triangle");

                Console.WriteLine($"Area of figure is {Math.Round(shape.Square(), 2)}");
            }

            Console.ReadKey(); // Delay
        }
    }
}