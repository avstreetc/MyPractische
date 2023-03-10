using System;

class a2
{
    static void Main()
    {
        // Запросить у пользователя ввод строки
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        // Преобразовать строку в новую строку без заглавных символов
        string output = RemoveUpperCase(input);

        // Вывести новую строку на экран
        Console.WriteLine("Результат:");
        Console.WriteLine(output);
    }

    // Функция, которая удаляет из строки все заглавные символы
    static string RemoveUpperCase(string input)
    {
        string output = "";

        // Перебрать все символы входной строки
        foreach (char c in input)
        {
            // Если символ не является заглавным, добавить его в выходную строку
            if (!char.IsUpper(c))
            {
                output += c;
            }
        }
        return output;
    }
}