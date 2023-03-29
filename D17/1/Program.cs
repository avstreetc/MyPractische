using GeometryLibrary;


namespace GeometryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем треугольник
            Console.WriteLine("Введите стороны треугольника:");
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(sideA, sideB, sideC);
   
            // Выводим информацию о треугольнике
            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
            Console.WriteLine($"Треугольник {triangle.GetTriangleType()}");
            Console.WriteLine();
            // Создаем прямоугольник
            Console.WriteLine("Введите стороны прямоугольника:");
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(Width, Height);

            // Выводим информацию о прямоугольнике
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");
        }
    }
}