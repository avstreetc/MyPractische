class a3
{
    // Метод для вычисления суммы A + A¹ + A² + A³ + ... + AN
    static void Sum(int A, int N)
    {
        int sum = 0;
        for (int i = 0; i <= N; i++)
        {
            sum += (int)Math.Pow(A, i); // Вычисляем A в степени i и добавляем к сумме
            Console.WriteLine($"Сумма: {sum}"); // Выводим текущее значение суммы
            Thread.Sleep(500); // Приостанавливаем выполнение потока на 0,5 секунды
        }
    }

    // Метод для вычисления произведения A * A¹ * A² * A³ * ... * AN
    static void Product(int A, int N)
    {
        int product = 1;
        for (int i = 1; i <= N; i++)
        {
            product *= (int)Math.Pow(A, i); // Вычисляем A в степени i и добавляем к произведению
            Console.WriteLine($"Произведение: {product}"); // Выводим текущее значение произведения
            Thread.Sleep(500); // Приостанавливаем выполнение потока на 0,5 секунды
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Введите A:");
        int A = int.Parse(Console.ReadLine()); 

        Console.Write("Введите N:");
        int N = int.Parse(Console.ReadLine()); 

        // Создаем два потока для выполнения методов Sum и Product
        Thread t1 = new Thread(() => Sum(A, N));
        Thread t2 = new Thread(() => Product(A, N));

        t1.Start(); // Запускаем первый поток
        t2.Start(); // Запускаем второй поток

        // Ожидаем завершения работы потоков
        t1.Join();
        t2.Join();

        Console.WriteLine("Работа потоков завершена.");

    }
}
