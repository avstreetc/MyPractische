﻿using System.Text.RegularExpressions;

// num 2 This pizza is very tasty*/.
Console.WriteLine("Введите текст, а мы определим, на английском ли он: ");
string text = Console.ReadLine();

//регулярное выражения
Regex regex = new Regex("[^a-zA-Z]");
string cleanText = regex.Replace(text, "");

if (!Regex.IsMatch(cleanText, @"^[a-zA-Z]+$"))
{
    Console.WriteLine("Введенный текст не на английском языке");
}
else
{
    Console.WriteLine("Введенный текст на английском языке");
}