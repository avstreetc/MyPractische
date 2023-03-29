using System;

namespace GeometryLibrary
{
    public class Rectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Метод для вычисления периметра
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        // Метод для вычисления площади
        public double GetArea()
        {
            return Width * Height;
        }
    }
}