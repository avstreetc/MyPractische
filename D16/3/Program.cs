using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class a3
{
    static void Main(string[] args)
    {
        string fileName = "file.txt"; // имя файла

        // создаем файл и записываем в него строки
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine("Волшебная строка");
            writer.WriteLine("Обычная строка");
            writer.WriteLine("Самая интересная строка");
            writer.WriteLine("Спокойная строка");
            writer.WriteLine("Интригующая строка");
        }

        // a) выводим весь файл на экран
        Console.WriteLine("Содержимое файла:");
        using (StreamReader reader = new StreamReader(fileName))
        {
            Console.WriteLine(reader.ReadToEnd());
        }
        Console.WriteLine();

        // b) подсчитываем количество строк
        int linesCount = File.ReadAllLines(fileName).Length;
        Console.WriteLine($"Количество строк в файле: {linesCount}");

        // c) подсчитываем количество символов в каждой строке
        Console.WriteLine("Количество символов в каждой строке:");
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"{line} - {line.Length} символов");
            }
        }
        Console.WriteLine();

        // d) удаляем последнюю строку из файла, записываем результат в новый файл
        string newFileName = "new_file.txt";
        List<string> lines = File.ReadAllLines(fileName).ToList();
        lines.RemoveAt(lines.Count - 1);
        File.WriteAllLines(newFileName, lines);
        Console.WriteLine($"Удалена последняя строка из файла {fileName}, результат записан в файл {newFileName}");
        Console.WriteLine();

        // e) выводим на экран строки с s1 по s2
        int s1 = 1; // начальная строка
        int s2 = 2; // конечная строка
        Console.WriteLine($"Строки с {s1} по {s2}:");
        lines = File.ReadAllLines(fileName).ToList();
        for (int i = s1 - 1; i < s2 && i < lines.Count; i++)
        {
            Console.WriteLine(lines[i]);
        }
        Console.WriteLine();

        // f) находим длину самой длинной строки и выводим ее на экран
        int maxLineLength = File.ReadAllLines(fileName).Max(line => line.Length);
        Console.WriteLine($"Длина самой длинной строки: {maxLineLength}");
        string maxLengthLine = File.ReadAllLines(fileName).FirstOrDefault(line => line.Length == maxLineLength);
        if (maxLengthLine != null)
        {
            Console.WriteLine($"Самая длинная строка: {maxLengthLine}");
        }
        Console.WriteLine();

        // g) выводим на экран все строки начинающиеся с заданной буквы
        Console.WriteLine("Введите букву для поиска строк: ");
        char letter = Convert.ToChar(Console.Read());
        Console.WriteLine($"Строки, начинающиеся на букву '{letter}':");
        lines = File.ReadAllLines(fileName).ToList();
        foreach (string line in lines)
        {
            if (line.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(line);
            }
        }
        Console.WriteLine();

        // h) переписать его строки в другой файл, порядок строк во втором файле должен быть обратным по отношению к порядку строк в заданном файле.
        string reverseFilePath = @"./reverse.txt";
        List<string> reversedLines = File.ReadAllLines(fileName).Reverse().ToList();
            File.WriteAllLines(reverseFilePath, reversedLines);

        Console.WriteLine($"Строки из файла записаны в файл {reverseFilePath} в обратном порядке.");
    }
}