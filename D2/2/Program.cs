using System;

// класс Печатное издание
class PrintPublication
{
    // cвойства
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // конструктор класса Печатное издание
    public PrintPublication(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    // метод печати информации о PrintPublication
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
    }
}

// класс Книга : наследуется от класса Печатное издание
class Book : PrintPublication
{
    public string Publisher { get; set; }

    public Book(string title, string author, int year, string publisher) : base(title, author, year)
    {
        Publisher = publisher;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Книга: {Title}, Автор: {Author}, Год: {Year}, Издательство: {Publisher}");
    }
}

// класс Журнал : наследуется от класса Печатное издание
class Magazine : PrintPublication
{ 
    public int Number { get; set; }

    public Magazine(string title, string author, int year, int number) : base(title, author, year)
    {
        Number = number;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Журнал: {Title}, Автор: {Author}, Год: {Year}, Номер: {Number}");
    }
}

// Класс Учебник : наследуется от Книга
class Textbook : Book
{
    public string Subject { get; set; }

    public Textbook(string title, string author, int year, string publisher, string subject) : base(title, author, year, publisher)
    {
        Subject = subject;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Учебник: {Title}, Автор: {Author}, Год: {Year}, Издательство: {Publisher}, Предмет: {Subject}");
    }
}

class a2
{
    static void Main(string[] args)
    {
        // cоздание объекта класса Печатное издание и выводим информацию по шаблону
        PrintPublication publication = new PrintPublication("Моя книга", "Я", 2022);
        publication.PrintInfo();

        // Создание объекта класса Книга
        Book book = new Book("Фотосессия без премий", "Варченя Артём", 2022, "ГГКТТИД");
        book.PrintInfo();

        // Создание объекта класса Журнал.
        Magazine magazine = new Magazine("Всё о Геншине", "Беленица Людмила", 2022, 1);
        magazine.PrintInfo();

        // Создание объекта класса Учебник.
        Textbook textbook = new Textbook("Тупой и умный c#", "Саливончик Антон", 2022, 
            "Сам сделал", "Информатика");
        textbook.PrintInfo();
    }
}