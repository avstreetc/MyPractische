using System;

// Объявляем тип делегата, который ссылается на метод
delegate double CalcFigure(double R);

class a1
{
    static void Main(string[] args)
    {
        // Создаем экземпляр объекта делегата и передаем ему ссылки на методы вычисления
        CalcFigure CF = GetLength;
        CF += GetArea;
        CF += GetVolume;

        /*double radius = 5.0*/;
        Console.Write("Введите радиус: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Вызываем методы через делегат, передавая в них радиус и выводим результаты на экран
        Console.WriteLine("Радиус: {0}", radius);
        Console.WriteLine("Длина окружности: {0}", CF(radius));
        Console.WriteLine("Площадь круга: {0}", CF(radius));
        Console.WriteLine("Объем шара: {0}", CF(radius));
    }

    // Метод вычисления длины окружности
    static double GetLength(double R)
    {
        return 2.0 * Math.PI * R;
    }

    // Метод вычисления площади круга
    static double GetArea(double R)
    {
        return Math.PI * R * R;
    }

    // Метод вычисления объема шара
    static double GetVolume(double R)
    {
        return 4.0 / 3.0 * Math.PI * R * R * R;
    }
}
