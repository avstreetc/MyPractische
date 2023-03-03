using System;

class a5
{
    static void Main(string[] args)
    {
        Console.Write("Введите целое число K (1<=K<=100): ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Введите целое число N (1<=N<=100): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        { // Запускаем цикл, который выполнится N раз
            Console.Write(k + " "); // Выводим число K
        }
    }
}