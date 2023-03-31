using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            Task<double> task1 = Task.Run(() =>
            {
                Thread.Sleep(1000); // замедление выполнения задачи для демонстрации
                return (Math.Sqrt(2 * b + 2 * Math.Sqrt(Math.Pow(b, 2) - 4))) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
            });

            Task<double> task2 = Task.Run(() =>
            {
                Thread.Sleep(1000); // замедление выполнения задачи для демонстрации
                return 1 / (Math.Sqrt(b + 2));
            });

            Task.WaitAll(task1, task2); // ожидание выполнения всех задач

            Console.WriteLine($"z1 = {task1.Result}");
            Console.WriteLine($"z2 = {task2.Result}");

            Task<double> anyTask = Task.WhenAny(task1, task2).Result; // ожидание выполнения хотя бы одной задачи

            Console.WriteLine($"Первая выполненная задача: {anyTask.Result}");
        }
    }
}
