using System;

class a1
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        double y;
        if (x < 0.1)
        {
            y = Math.Sqrt(Math.Abs(2 * x * x + Math.Sin(x) + 1));
            Console.WriteLine("Значение функции y({0}) = {1}", x, y);
        }
        if (x == 0.1)
        {
            y = 2 * x + Math.Exp(x);
            Console.WriteLine("Значение функции y({0}) = {1}", x, y);
        }
        //else
        //{
        //    Console.WriteLine("Не входит в диапазон");
        //}        
    }
}