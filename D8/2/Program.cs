// Создайте перечисление, в котором будут содержаться должности
//сотрудников как имена констант. Присвойте каждой константе значение,
//задающее количество часов, которые должен отработать сотрудник за месяц.

using System;

enum Post
{
    Менеджер = 16,
    Программист = 20,
    Дизайнер = 28,
    Фотограф = 39
}

class Accauntant
{
    public bool AskForBonus(Post post, int hours) => (int)post > hours;
    
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество часов, начиная с которого сотруднику положена премия: ");
        int hours = int.Parse(Console.ReadLine());
        Accauntant accauntant = new Accauntant();


        bool bonusIsGiven = false;
        foreach (Post post in Enum.GetValues(typeof(Post)))
        {
            if (accauntant.AskForBonus(post, hours))
            {
                Console.WriteLine($"Премия положена для должности {post}");
                bonusIsGiven = true;
            }
        }

        if (!bonusIsGiven)
        {
            Console.WriteLine("Премия не положена для ни одной должности");
        }
    }
}