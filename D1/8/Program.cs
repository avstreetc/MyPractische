using System;

class a8
{
    static void Main()
    {
        Console.Write("Первое целое число: ");
        int num1 = int.Parse(Console.ReadLine());  // считываем первое число

        Console.Write("Второе целое число: ");
        int num2 = int.Parse(Console.ReadLine());  // считываем второе число

        Console.Write("Третье целое число: ");
        int num3 = int.Parse(Console.ReadLine());  // считываем третье число

        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Среди трех данных целых чисел есть хотя бы одна пара совпадающих");
        }
        else
        {
            Console.WriteLine("Среди данных целых чисел нет совпадающих пар");
        }
    }
}