using System;

class a2
{
    static void Main(string[] args)
    {
        int[] arr = {5, 2, 9, 15, 50, 96, 94, 100};

        // Сортируем массив
        //int [] SortArr = 
         Array.Sort(arr);

        // Находим максимальное значение в массиве
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        // Создаем новый массив где 1-максимальное чсло
        int[] newArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != max)
            {
                newArr[i] = 0;
            }
            else
            {
                newArr[i] = 1;
            }
        }

        // Выводим исходный массив и новый массив на экран
        Console.WriteLine("Исходный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        Console.WriteLine("Новый массив:");
        foreach (int num in newArr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\n");

        // Запрашиваем число k с клавиатуры
        Console.Write("Какое число найти в исх. массиве? k: ");
        int k = int.Parse(Console.ReadLine());

        // Ищем число k в отсортированном массиве методом бинарного поиска
        int index = Array.BinarySearch(arr, k);

        // Выводим результат на экран
        if (index >= 0)
        {
            Console.WriteLine("Число " + k + " найдено в массиве на позиции " + index);
        }
        else
        {
            Console.WriteLine("Число " + k + " не найдено в массиве");
        }
    }
}