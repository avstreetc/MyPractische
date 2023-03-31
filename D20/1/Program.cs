using System;
using System.Threading.Tasks;

namespace ParallelProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            Task<int> task1 = Task.Run(() => GetNumberWithMovedDigit(number));
            Task<int> task2 = Task.Factory.StartNew(() => GetNumberWithSwappedDigits(number));
            Task<int> task3 = new Task<int>(() => GetProductOfDigits(number));
            task3.Start();

            Task.WaitAll(task1, task2, task3);

            Console.WriteLine($"Число со сдвинутой цифрой: {task1.Result}");
            Console.WriteLine($"Число с переставленными цифрами: {task2.Result}");
            Console.WriteLine($"Произведение цифр: {task3.Result}");
        }

        static int GetNumberWithMovedDigit(int number)
        {
            int lastDigit = number % 10;
            number /= 10;
            int firstDigits = number / 10;

            return lastDigit * 100 + firstDigits * 10 + number % 10;
        }

        static int GetNumberWithSwappedDigits(int number)
        {
            int lastDigit = number % 10;
            number /= 10;
            int middleDigit = number % 10;
            number /= 10;

            return lastDigit * 100 + middleDigit * 10 + number;
        }

        static int GetProductOfDigits(int number)
        {
            int product = 1;
            while (number > 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
    }
}
