using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос пользователю ввести два целых числа A и B (A < B).
        Console.WriteLine("Введите два целых числа A и B (A < B):");
        int a = int.Parse(Console.ReadLine()); // Считывание первого числа из консоли.
        int b = int.Parse(Console.ReadLine()); // Считывание второго числа из консоли.

        int sum = 0; // Объявление переменной для хранения суммы.
        // Цикл, который перебирает все целые числа от A до B включительно и складывает их.
        for (int i = a; i <= b; i++)
        {
            sum += i;
        }

        // Вывод результата на консоль.
        Console.WriteLine($"Сумма от {a} до {b} равна {sum}.");
    }
}