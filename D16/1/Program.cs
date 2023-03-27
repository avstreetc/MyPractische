using System;
using System.IO;


class a1
{
    static void Main()
    {
        string filePath = @"./f.txt"; // путь к файлу g
        int evenNumbersCount = 0; // количество четных чисел

        // проверяем существование файла
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден");
            return;
        }

        // считываем содержимое файла
        string fileContent = File.ReadAllText(filePath);

        // разбиваем содержимое на компоненты, используя пробел в качестве разделителя
        string[] components = fileContent.Split(' ');

        // проходим по всем компонентам
        foreach (string component in components)
        {
            if (int.TryParse(component, out int number)) // проверяем, является ли компонент числом
            {
                if (number % 2 == 0) // проверяем, является ли число четным
                {
                    evenNumbersCount++; // увеличиваем счетчик четных чисел
                }
            }
        }

        Console.WriteLine($"Количество четных чисел: {evenNumbersCount}");
    }
}
