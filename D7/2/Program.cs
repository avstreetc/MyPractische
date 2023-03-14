using System.Text.RegularExpressions;

// num 2 This pizza is very tasty*/.
Console.WriteLine("Введите текст, а мы определим, на английском ли он: ");
string text = Console.ReadLine();

//шаблон-экзмепляр регулярного выражения
Regex regRus = new Regex("[а-яА-Я]");
Regex reg = new Regex("[a-zA-Z]");

// рег для поиска англ в тексте
MatchCollection matchesEng = reg.Matches(text);
MatchCollection matchesRus = regRus.Matches(text);

// счёт символов англ и рашн
int matchEngCount = matchesEng.Count;
int matchRusCount = matchesRus.Count;


if (Regex.IsMatch(text, @"\p{IsBasicLatin}"))
{
    Console.WriteLine("Text is in English");
}
else
{
    Console.WriteLine("Текст на русском");
}