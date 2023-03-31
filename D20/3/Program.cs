using System;
using System.Threading.Tasks;

namespace TaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            Task<int> task1 = new Task<int>(() =>
            {
                int reverseNumber = 0;
                while (number > 0)
                {
                    int remainder = number % 10;
                    reverseNumber = reverseNumber * 10 + remainder;
                    number /= 10;
                }
                return reverseNumber;
            });

            Task task2 = task1.ContinueWith((Task<int> t) =>
            {
                Console.WriteLine("Число, полученное при прочтении цифр справа налево: " + t.Result);
            });

            task1.Start();
            Task.WaitAll(task1, task2);
        }
    }
}
