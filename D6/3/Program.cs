using System;

class a3
{
    static void Main(string[] args)
    {
        Console.Write("Введите предложение: ");
        string sentence = Console.ReadLine();
        string sentence1 = sentence;
        string sentence2 = sentence;
        string sentence3 = sentence;
        string sentence4 = sentence;


        // Меняем местами первое и последнее слова
        string[] words = sentence1.Split(' ');
        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;
        sentence1 = string.Join(" ", words);
        Console.WriteLine("1.Переставим первым и последним словами: "); Console.WriteLine(sentence1);

        // Склеиваем второе и третье слова
        words = sentence2.Split(' ');
        words[1] += words[2];
        for (int i = 2; i < words.Length - 1; i++)
        {
            words[i] = words[i + 1];
        }
        Array.Resize(ref words, words.Length - 1);
        sentence2 = string.Join(" ", words);
        Console.WriteLine("2.Объединим вторым и третьим словами: "); Console.WriteLine(sentence2);

        // Переворачиваем третье слово
        words = sentence3.Split(' ');
        char[] chars = words[2].ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        Console.WriteLine("3.Третье слово в обратном порядке: "); Console.WriteLine(sentence3);

        // Вырезаем первые две буквы из первого слова
        words = sentence4.Split(' ');
        words[0] = words[0].Substring(2);
        sentence4 = string.Join(" ", words);
        Console.WriteLine("4.Первое слово без первых двух букв: "); Console.WriteLine(sentence4);
    }
}