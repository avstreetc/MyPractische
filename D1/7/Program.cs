using System;

class a7
{
    static void Main()
    {
        Console.Write("Количество секунд, прошедших с начала суток: ");
        int seconds = int.Parse(Console.ReadLine());

        int hours = seconds / 3600;  // находим количество полных часов
        Console.WriteLine("С начала суток прошло {0} часов", hours);
    }
}