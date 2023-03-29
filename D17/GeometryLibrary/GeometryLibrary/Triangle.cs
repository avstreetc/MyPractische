using System;

namespace GeometryLibrary
{
    public class Triangle
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Метод для проверки существования треугольника
        public bool IsValid()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }

        // Метод для вычисления периметра
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        // Метод для вычисления площади
        public double GetArea()
        {
            double s = GetPerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        // Метод для определения вида треугольника
        public string GetTriangleType()
        {
            if (!IsValid())
            {
                return "Треугольник не существует";
            }
            else if (SideA == SideB && SideB == SideC)
            {
                return "Равносторонний треугольник";
            }
            else if (SideA == SideB || SideA == SideC || SideB == SideC)
            {
                return "Равнобедренный треугольник";
            }
            else
            {
                return "Разносторонний треугольник";
            }
        }
    }
}