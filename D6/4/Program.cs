using System;

class a4
{
    static void Main(string[] args)
    {
        //Александр Сергеевич Пушкин 9
        Console.WriteLine("Введите ФИО");
        string fullName = Console.ReadLine(); 
        fullName = fullName.Replace(" ", ""); //уберём пробелы к чёрту

        int sum = 0;
        foreach (char c in fullName)
        {
            sum += char.ToUpper(c) - 64;
        }

        while (sum > 9)
        {
            int newSum = 0;
            while (sum != 0)
            {
                newSum += sum % 10;
                sum /= 10;
            }
            sum = newSum;
        }
        Console.WriteLine("Код личности: " + sum);
    }
}