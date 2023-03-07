using System;
using System.Linq.Expressions;

class OutOfRangeException : Exception
{
    public OutOfRangeException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());

            double result;
            if (x >= 1)
            {
                result = 5 * x + 2;
                Console.WriteLine($"Результат: {result}");
            }
            else if (x > -1 && x < 1)
            {
                // Проверка условий выхода за диапазон
                if (x == 0)
                {
                    throw new DivideByZeroException("Знаменатель равен нулю.");
                }

                double numerator = Math.Cos(x); //по приколу нужно соединить
                result = numerator / x;
                Console.WriteLine($"Результат: {result}");
            }
# Catch;

        }
    }
}