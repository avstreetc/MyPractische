using System;

class a3
{
    static void Main(string[] args)
    {
        Console.Write("Номер телевизионного канала: ");
        int channelNumber = int.Parse(Console.ReadLine());

        switch (channelNumber)
        {
            case 1:
                Console.WriteLine("Наиболее популярные программы канала 1: новости, сериалы");
                break;
            case 2:
                Console.WriteLine("Наиболее популярные программы канала 2: спорт, фильмы");
                break;
            case 3:
                Console.WriteLine("Наиболее популярные программы канала 3: детские передачи, комедии");
                break;
            default:
                Console.WriteLine("Такой канал не найден");
                break;
        }
    }
}