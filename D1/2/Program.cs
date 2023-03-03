using System;

class a2
{
    static void Main(string[] args)
    {
        Console.Write("Введите четырёхзначное число: ");
        int num = int.Parse(Console.ReadLine());

        int firstN = num / 1000;
        int secondN = (num / 100) % 10;

        if (firstN > secondN)
        {
            Console.WriteLine("Первая цифра больше второй");
        }
        else if (firstN < secondN)
        {
            Console.WriteLine("Вторая цифра больше первой");
        }
        else
        {
            Console.WriteLine("Первая и вторая цифры равны");
        }
    }
}