int[,] tickets = new int[18, 36]; // двумерный массив 

// случайными значения
Random rnd = new Random();
for (int i = 0; i < 18; i++)
{
    for (int j = 0; j < 36; j++)
    {
        tickets[i, j] = rnd.Next(0, 2);
    }
}

for (int i = 0; i < 18; i++) // выводим массивчик 
{
    for (int j = 0; j < 36; j++) { Console.Write(tickets[i, j] + " "); }
    Console.WriteLine();
}


// Проверяем каждый вагон на наличие свободных мест
for (int i = 0; i < 18; i++)
{
    bool freeSeats = false; // Флаг, указывающий на наличие свободных мест в вагоне
    for (int j = 0; j < 36; j++)
    {
        if (tickets[i, j] == 0) // Если нашли свободное место в вагоне, устанавливаем флаг и выходим из цикла
        {
            freeSeats = true;
            break;
        }
    }
    if (freeSeats) // Если в вагоне есть свободные места, выводим сообщение на экран
    {
        Console.WriteLine("В вагоне " + (i + 1) + " есть свободные места.");
    }
}