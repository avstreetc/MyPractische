using System;

class a1
{
    static void Main(string[] args)
    {
        // массив с 3 отрицательно
        double[] arr = { -1, 4, 5, -7, 9, -5 };

        int count = 0;

        foreach (double num in arr)
        {
            if (num < 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество отрицательных элементов: " + count);
    }
}