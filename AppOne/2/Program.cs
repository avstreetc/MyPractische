using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class a2
{
    public static void Main()
    {
        int n, a, b, c; // объявление переменныx
        Console.Write("Введите трехзначное число: ");
        n = Convert.ToInt32(Console.ReadLine());

        // находим первую, вторую и третью цифры 
        c = n % 10; b = (n / 10) % 10; a = n / 100;

        int m = b * 100 + a * 10 + c;
        Console.WriteLine($"Получилось число: {m}");
    }
}