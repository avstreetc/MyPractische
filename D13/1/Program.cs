using System;

class Program
{
    // объявление делегата
    delegate double MyDelegate(double x);

    static void Main(string[] args)
    {
        try
        {
            // создаём экземпляр делегата
            MyDelegate myDelegate = Method1;
            myDelegate += Method2;
            myDelegate += Method3;

            // вызываем все три метода при помощи делегата
            Console.WriteLine("Результаты методов:");
            foreach (MyDelegate method in myDelegate.GetInvocationList())
            {
                try
                {
                    double result = method(2);
                    Console.WriteLine($"{method.Method.Name}: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении метода {method.Method.Name}: {ex.Message}");
                }
            }

            // вызываем метод с делегатом в качестве параметра
            DoSomething(myDelegate, 2);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    // методы для подсчета значений трех разных функций
    static double Method1(double x)
    {
        return x * x;
    }

    static double Method2(double x)
    {
        return Math.Pow(x,2);
    }

    static double Method3(double x)
    {
        return Math.Exp(x);
    }

    // метод, который использует делегат в качестве параметра
    static void DoSomething(MyDelegate myDelegate, double x)
    {
        try
        {
            foreach (MyDelegate method in myDelegate.GetInvocationList())
            {
                double result = method(x);
                Console.WriteLine($"Результат метода: {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при выполнении метода DoSomething: {ex.Message}");
        }
    }
}

