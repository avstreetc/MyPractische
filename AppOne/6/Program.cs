using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6
{
    class Claass
    {
        static void Main()
        {
            // Читаем значение N 123
            Console.Write("Введите трёхзначное число: ");
            int n = int.Parse(Console.ReadLine());

            //из лабы
            //// Валидация oт 100 до 1000
            //if (n < 100 || n > 999)
            //{
            //    Console.WriteLine("Число N должно быть от 100 до 1000");
            //    return;
            //}

            //// Число десятков не равно нулю
            //if (n / 10 % 10 == 0)
            //{
            //    Console.WriteLine("Число десятков в N не должно быть равно нулю");
            //    return;
            //}

            int first = n / 100;  // 1
            int second = (n % 100) / 10; //2
            int third = n % 10; //3

            Console.WriteLine($"Число: {third}{second}{first}");
        }
    }
}