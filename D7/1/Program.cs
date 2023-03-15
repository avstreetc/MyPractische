using System.Text.RegularExpressions;

Console.WriteLine("Напишите текст: ");
string text = Console.ReadLine();

// Создаем регулярное выражение, которое находит слова, содержащие не более одного дефиса
Regex regex = new Regex(@"\b\w*-\w*\b");

Console.WriteLine();
Console.WriteLine("Слова содержащие не более одного дефиса: ");

// Находим все совпадения 
MatchCollection matches = regex.Matches(text);

// Выводим найденные слова
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}