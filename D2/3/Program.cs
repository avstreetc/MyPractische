using System;

namespace a3
{

    class Rectangle
    {
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        // свойства для получения и установки координат и размеров прямоугольника
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public int Width
        {
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        // метод для смещения прямоугольника на заданные координаты
        public void Offset(int x, int y)
        {
            X += x;
            Y += y;
        }

        // метод для нахождения пересечения двух прямоугольников
        public static Rectangle Intersect(Rectangle a, Rectangle b)
        {
            // находим координаты начала и конца пересечения по осям X и Y
            int maxStartX = Math.Max(a.X, b.X);
            int minEndX = Math.Min(a.X + a.Width, b.X + b.Width);
            int MaxStartY = Math.Max(a.Y, b.Y);
            int minEndY = Math.Min(a.Y + a.Height, b.Y + b.Height);

            // проверяем, существует ли пересечение
            if (minEndX >= maxStartX && minEndY >= MaxStartY)
            {
                // создаем и возвращаем новый прямоугольник, представляющий пересечение
                return new Rectangle(maxStartX, MaxStartY, minEndX - maxStartX, minEndY - MaxStartY);
            }
            // если пересечения нет
            return null;
        }

        // метод для нахождения минимального прямоугольника,
        // содержащего два заданных прямоугольника
        public static Rectangle Union(Rectangle a, Rectangle b)
        {
            // Находим координаты начала и
            // конца нового прямоугольника по осям X и Y
            int minStartX = Math.Min(a.X, b.X);
            int maxEndX = Math.Max(a.X + a.Width, b.X + b.Width);
            int minStartY = Math.Min(a.Y, b.Y);
            int MaxEndY = Math.Max(a.Y + a.Height, b.Y + b.Height);

            // созд и возвр новый прямоугольник,
            // объединение двух прямоугольников
            return new Rectangle(minStartX, minStartY, maxEndX - minStartX, MaxEndY - minStartY);
        }


        // методик для вывода информации о прямоугольнике в виде строки
        public override string ToString()
        {
            return String.Format("X:{0} Y:{1} W:{2} H:{3}", X, Y, Width, Height);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // прямоугольник r1 с координатами (0, 0) и размерами 10x10
            Rectangle r1 = new Rectangle(0, 0, 10, 10);

            Console.WriteLine("Исходный прямоугольник: " + r1);

            Console.Write("Смещённый прямоугольник: ");

            // Смещение прямоугольника r1 на 5 по оси X
            r1.Offset(5, 0);
            Console.WriteLine(r1);

            Rectangle r2 = new Rectangle(2, 2, 20, 20);
            Console.WriteLine("Пересечение прямоугольников: " + Rectangle.Intersect(r1, r2));
            Console.WriteLine("Объединение прямоугольников: " + Rectangle.Union(r1, r2));
        }
    }
}