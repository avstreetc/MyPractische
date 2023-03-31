using System;
using System.Threading.Tasks;

namespace ParallelForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -10, b = 1; // Границы отрезка
            int N = 11; // Количество точек

            double h = (b - a) / N; 

            // Вычисление значения функции в каждой точке на отрезке [a,b]
            Parallel.For(0, N, i =>
            {
                double x = a + i * h; // Вычисление аргумента функции в i-ой точке
                double y = Math.Atan(x); // Вычисление значения функции в i-ой точке
                Console.WriteLine("arctan({0:f2}) = {1:f2}", x, y); // Вывод результата на консоль
            });

        }
    }
}

