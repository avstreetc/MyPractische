using System.Diagnostics;

class a2
{
    static void Main(string[] args)
    {
        // Создание 2-х потоков
        Thread t1 = new Thread(SumNumbers);
        Thread t2 = new Thread(SumNumbers);

        Stopwatch stopwatch = new Stopwatch();
        Stopwatch.Start();

        // Запуск потоков
        t1.Start();
        t2.Start();

        // Ожидание завершения работы потоков
        t1.Join();
        t2.Join();
    }

    static void SumNumbers()
    {
        
        int sum = 0;

        // Вычисление суммы чисел от 1 до 10
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
            Thread.Sleep(100);
        }
        // Вывод затраченного времени на выполнение потока
        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: " +
                          $"сумма чисел от 1 до 10 равна {sum}. " +
                          $"Время выполнения потока: {Stopwatch.ElapsedMilliseconds} мс.");
    }

    // Создание объекта Stopwatch для замера времени выполнения потока
    static readonly Stopwatch Stopwatch = new Stopwatch();
}