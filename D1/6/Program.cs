using System;

class a6
{
    static void Main()
    {
        double A = 0.0;  // начало отрезка
        double B = 1.0;  // конец отрезка
        int M = 20;      // количество точек на отрезке
        double H = (B - A) / M;  // шаг между точками на отрезке

        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());  // считываем значение x

        for (int i = 0; i <= M; i++)
        {
            double y = Math.Atan(x);  // вычисляем значение функции y = arctan(x)
            Console.WriteLine("y({0:F2}) = {1:F2}", x, y);  // выводим значение функции y
            x += H;  // увеличиваем x на шаг H
        }
    }
}