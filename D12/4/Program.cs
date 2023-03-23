using System;

    class Program
    {
        static void Main(string[] args)
        {

            // Создаем массив делегатов, которые будут возвращать случайное значение типа int
            Func<int>[] delegates = new Func<int>[]
            {
                () => new Random().Next(1,100),
                () => new Random().Next(1,100),
                () => new Random().Next(1,100),

            };

            // Создаем анонимный метод, который принимает массив делегатов и возвращает их среднее арифметическое
            Func<Func<int>[], double> average = delegate (Func<int>[] funcs)
            {
                double sum = 0;
                foreach (var func in funcs)
                {
                    sum += func();
                }

                // Вычисляем среднее арифметическое и возвращаем его
                return (double)sum / funcs.Length;
            };

            // Вызываем анонимный метод и выводим результат на консоль
            Console.WriteLine("Среднее арифметическое: " + average(delegates));
        }
    }
