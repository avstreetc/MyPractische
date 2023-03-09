using System;

class a3
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 10)
        {
            Console.WriteLine("Ошибка: N должно быть меньше 10");
            return;
        }

        Console.Write("Диапозон от, a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Диапозон до, b: ");
        int b = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Random random = new Random();

        // Заполняем матрицу случайными числами из диапазона [a, b]
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = random.Next(a, b + 1);
            }
        }

        // Выводим исходную матрицу на экран
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }

        // Вычисляем сумму четных элементов матрицы
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    sum += matrix[i, j];
                }
            }
        }
        Console.WriteLine("Сумма четных элементов матрицы: {0}", sum);

        // Вычисляем количество положительных элементов каждого столбца матрицы
        for (int j = 0; j < n; j++)
        {
            int positiveCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, j] > 0)
                {
                    positiveCount++;
                }
            }
            Console.WriteLine("Количество положительных элементов в столбце {0}: {1}", j, positiveCount);
        }
    }
}