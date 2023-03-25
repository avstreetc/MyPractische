// Создание 3-х потоков
Thread t1 = new Thread(() => WriteNumFromTo("Первый поток", 1, 9)); // Первый поток
Thread t2 = new Thread(() => WriteNumFromTo("Второй поток", 10, 19)); // Второй поток
Thread t3 = new Thread(() => WriteNumFromTo("Третий поток", 20, 29)); // Третий поток

t1.Priority = ThreadPriority.Highest;
t2.Priority = ThreadPriority.BelowNormal;
t3.Priority = ThreadPriority.Lowest;

t1.Start();
Thread.Sleep(5000);
t2.Start();
Thread.Sleep(5000);
t3.Start();

static void WriteNumFromTo(string mes, int from, int to)
{
    for (int i = from; i <= to; i++)
    {
        Console.WriteLine($"{mes}: {i}");
    }
}