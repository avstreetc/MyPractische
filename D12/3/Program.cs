using System;

class a3
{
    delegate string StringDelegate(string str);
    static void Main(string[] args)
    {
        // экземпляр делегата, для ссылки на методы
        StringDelegate stringDelegate = null;

        stringDelegate += RemoveSpaces;
        stringDelegate += ToUpperCase;
        stringDelegate += AddExclamationMark;

        //вызов
        string input = Console.ReadLine();

        // вызов методов через делегат
        string result = AddExclamationMark(ToUpperCase(RemoveSpaces(input)));

        Console.WriteLine(result);
    }

static string RemoveSpaces(string str)
{
    return str.Replace(" ", "");
}

static string ToUpperCase(string str)
{
    return str.ToUpper();
}

static string AddExclamationMark(string str)
{
    return str + "!";
}
}
