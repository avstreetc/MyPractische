using System;
using System.Collections.Generic;
using System.IO;

class a4
{
    static void Main(string[] args)
    {
        string inputFileName = "first.txt";
        string evenFileName = "second.txt";
        string oddFileName = "third.txt";

        // Читаем все строки из исходного файла
        string[] allLines = File.ReadAllLines(inputFileName);

        // Создаем списки для четных и нечетных строк
        List<string> evenLines = new List<string>();
        List<string> oddLines = new List<string>();

        // Разделяем строки по четности и сохраняем в соответствующие списки
        for (int i = 0; i < allLines.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenLines.Add(allLines[i]);
            }
            else
            {
                oddLines.Add(allLines[i]);
            }
        }

        // Записываем четные строки в файл
        File.WriteAllLines(evenFileName, evenLines);

        // Записываем нечетные строки в файл
        File.WriteAllLines(oddFileName, oddLines);
    }
}
