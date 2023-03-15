//using System;
using System.Text.RegularExpressions;

Console.WriteLine("Введите текст, мы выведем всю почту");
// Заданный текст
string text = Console.ReadLine();

// Регулярное выражение для поиска email адресов
string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

// Ищем все email адреса в заданном тексте
MatchCollection matches = Regex.Matches(text, pattern);

// Выводим найденные адреса
Console.WriteLine("Найденные e-mail адреса:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}